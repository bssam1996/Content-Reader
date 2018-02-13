Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Public Class Form1
    Dim d As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If CheckBox1.Checked = False Then
                ListView1.Items.Clear()
                d = 0
            End If
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                Label1.Text = folderbrowserdialog1.SelectedPath
                If Label1.Text.Count = 3 Then
                    Label1.Text = folderbrowserdialog1.SelectedPath
                Else
                    Label1.Text = folderbrowserdialog1.SelectedPath + "\"
                End If
                Dim di As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
                Dim diar1 As IO.DirectoryInfo() = di.GetDirectories()
                Dim dra As IO.DirectoryInfo
                Dim diar2 As IO.FileInfo() = di.GetFiles
                Dim dra2 As IO.FileInfo
                Dim a As Double
                Dim b As String

                For Each dra In diar1
                    If CheckBox2.Checked = True Then
                        b = di.ToString & "\" & dra.ToString & "\"
                        a = GetFolderSize(b, True) / 1024 / 1024
                        d = d + a
                        a = Format(a, "Fixed")
                        b = a & " MB"
                        If a > 1000 Then
                            b = b & "(" & Format(a / 1024, "Fixed") & "GB)"
                        ElseIf a < 1 Then
                            b = b & "(" & Format(a * 1024, "Fixed") & "KB)"
                        End If
                        ListView1.Items.Add(dra.ToString).SubItems.Add(b)
                        If CheckBox5.Checked = True Then
                            Dim sdi As New IO.DirectoryInfo(di.ToString & "\" & dra.ToString)
                            Dim sdiar1 As IO.DirectoryInfo() = sdi.GetDirectories()
                            Dim sdra As IO.DirectoryInfo
                            Dim sdiar2 As IO.FileInfo() = sdi.GetFiles
                            Dim sdra2 As IO.FileInfo
                            For Each sdra In sdiar1
                                b = sdi.ToString & "\" & sdra.ToString & "\"
                                a = GetFolderSize(b, True) / 1024 / 1024
                                a = Format(a, "Fixed")
                                b = a & " MB"
                                If a > 1000 Then
                                    b = b & "(" & Format(a / 1024, "Fixed") & "GB)"
                                ElseIf a < 1 Then
                                    b = b & "(" & Format(a * 1024, "Fixed") & "KB)"
                                End If
                                ListView1.Items.Add("> " & sdra.ToString).SubItems.Add(b)
                            Next
                            For Each sdra2 In sdiar2
                                b = sdi.ToString & "\" & sdra2.ToString
                                Dim c = My.Computer.FileSystem.GetFileInfo(b)
                                a = c.Length / 1024 / 1024
                                a = Format(a, "Fixed")
                                b = a & " MB"
                                If a > 1000 Then
                                    b = b & "(" & Format(a / 1024, "Fixed") & "GB)"
                                ElseIf a < 1 Then
                                    b = b & "(" & Format(a * 1024, "Fixed") & "KB)"
                                End If
                                ListView1.Items.Add("> " & sdra2.ToString).SubItems.Add(b)
                            Next
                        End If
                    Else
                        ListView1.Items.Add(dra.ToString).SubItems.Add("None")
                        If CheckBox5.Checked = True Then
                            Dim sdi As New IO.DirectoryInfo(di.ToString & "\" & dra.ToString)
                            Dim sdiar1 As IO.DirectoryInfo() = sdi.GetDirectories()
                            Dim sdra As IO.DirectoryInfo
                            Dim sdiar2 As IO.FileInfo() = sdi.GetFiles
                            Dim sdra2 As IO.FileInfo
                            For Each sdra In sdiar1
                                ListView1.Items.Add("> " & sdra.ToString).SubItems.Add("None")
                            Next
                            For Each sdra2 In sdiar2
                                ListView1.Items.Add("> " & sdra2.ToString).SubItems.Add("None")
                            Next
                        End If
                    End If

                Next
                For Each dra2 In diar2
                    If CheckBox2.Checked = True Then
                        b = di.ToString & "\" & dra2.ToString
                        Dim c = My.Computer.FileSystem.GetFileInfo(b)
                        a = c.Length / 1024 / 1024
                        d = d + a
                        a = Format(a, "Fixed")
                        b = a & " MB"
                        If a > 1000 Then
                            b = b & "(" & Format(a / 1024, "Fixed") & "GB)"
                        ElseIf a < 1 Then
                            b = b & "(" & Format(a * 1024, "Fixed") & "KB)"
                        End If
                        ListView1.Items.Add(dra2.ToString).SubItems.Add(b)
                    Else
                        ListView1.Items.Add(dra2.ToString).SubItems.Add("None")
                    End If
                Next
                If CheckBox2.Checked = True Then
                    d = Format(d, "Fixed")
                    b = d & " MB"
                    If d > 1000 Then
                        b = b & "(" & Format(d / 1024, "Fixed") & "GB)"
                    ElseIf d < 1 Then
                        b = b & "(" & Format(d * 1024, "Fixed") & "KB)"
                    End If
                    Label2.Text = "Total Space : " & b
                End If
            End If
            Label3.Text = "Total Items : " & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label3.Text = "Total Items : " & ListView1.Items.Count
        Try
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                If SaveFileDialog1.FilterIndex = 2 Then
                    Dim headers = (From ch In ListView1.Columns Let header = DirectCast(ch, ColumnHeader) Select header.Text).ToArray()
                    Dim items() = (From item In ListView1.Items Let lvi = DirectCast(item, ListViewItem) Select (From subitem In lvi.SubItems Let si = DirectCast(subitem, ListViewItem.ListViewSubItem) Select si.Text).ToArray()).ToArray()
                    Dim table As String = String.Join(",", headers) & Environment.NewLine
                    For Each a In items
                        table &= String.Join(",", a) & Environment.NewLine
                    Next
                    table = table.TrimEnd(CChar(vbCr), CChar(vbLf))
                    IO.File.WriteAllText(SaveFileDialog1.FileName, table)

                Else
                    Dim myWriter As New IO.StreamWriter(SaveFileDialog1.FileName)
                    For Each myItem As ListViewItem In ListView1.Items
                        If ListView1.Items(1).SubItems(1).Text = "None" Then
                            Dim b As String = myItem.Text
                            b = Replace(b, ">", "         ")
                            myWriter.WriteLine(b)
                        Else
                            Dim b As String = myItem.Text
                            b = Replace(b, ">", "         ")
                            myWriter.WriteLine(b & "         " & "Size = " & myItem.SubItems(1).Text)
                        End If
                    Next
                    myWriter.Close()
                    If CheckBox3.Checked = True Then
                        System.IO.File.AppendAllText(SaveFileDialog1.FileName, Label3.Text & vbNewLine)
                    End If
                    If CheckBox4.Checked = True Then
                        System.IO.File.AppendAllText(SaveFileDialog1.FileName, Label2.Text & vbNewLine)
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("There was an error occured while saving" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Listview1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            DeleteThisItemToolStripMenuItem.PerformClick()
        End If
    End Sub

    Public abort As Boolean
    Function GetFolderSize(ByVal DirPath As String, ByVal includeSubFolders As Boolean) As Long
        Try
            Dim size As Long = 0
            Dim diBase As New DirectoryInfo(DirPath)
            Dim files() As FileInfo
            If includeSubFolders Then
                files = diBase.GetFiles("*", SearchOption.AllDirectories)

            Else
                files = diBase.GetFiles("*", SearchOption.TopDirectoryOnly)
            End If
            Dim ie As IEnumerator = files.GetEnumerator
            While ie.MoveNext And Not abort

                size += DirectCast(ie.Current, FileInfo).Length
            End While
            Return size
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If

    End Sub
    'k
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text <> "" Then

                If TextBox2.Text = "" Then
                    ListView1.Items.Add(TextBox1.Text).SubItems.Add("None")
                Else
                    Dim value As Integer = Val(TextBox2.Text)
                    value = Format(value, "Fixed")
                    Dim substring As String
                    substring = value & " MB"
                    If value > 1000 Then
                        substring = substring & "(" & Format(value / 1024, "Fixed") & "GB)"
                    ElseIf value < 1 Then
                        substring = substring & "(" & Format(value * 1024, "Fixed") & "KB)"
                    End If
                    ListView1.Items.Add(TextBox1.Text).SubItems.Add(substring)
                End If
                TextBox1.Text = ""
                TextBox2.Text = ""
                ListView1.SelectedIndices.Clear()
                ListView1.Items.Item(ListView1.Items.Count - 1).Selected = True
                ListView1.Select()
            Else
                MsgBox("Please type a name at least!", MsgBoxStyle.Critical, "Error")
            End If
            Label3.Text = "Total Items : " & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.ShowDialog(Me)
    End Sub

    Private Sub DeleteThisItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteThisItemToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then
            Try
                Dim current As Integer = ListView1.SelectedItems(0).Index
                For Each i As ListViewItem In ListView1.SelectedItems
                    ListView1.Items.Remove(i)
                Next
                Try
                    ListView1.SelectedIndices.Clear()
                    ListView1.Items(current).Selected = True
                    ListView1.Select()
                Catch
                End Try
                Label3.Text = "Total Items : " & ListView1.Items.Count
            Catch ex As Exception
                MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            ListView1.Items.Clear()
            Label2.Text = "Total Space : 0"
            Label3.Text = "Total Items : 0"
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Try
            If ListView1.Items.Count = 0 Then
                ClearAllToolStripMenuItem.Enabled = False
                DeleteThisItemToolStripMenuItem.Enabled = False
                MoveUpToolStripMenuItem.Enabled = False
                MoveDownToolStripMenuItem.Enabled = False
                AddItemAfterThisItemToolStripMenuItem.Enabled = False
                AddItemBeforeThisItemToolStripMenuItem.Enabled = False
                MoveFirstToolStripMenuItem.Enabled = False
                MoveLastToolStripMenuItem.Enabled = False
            Else
                ClearAllToolStripMenuItem.Enabled = True
            End If
            If ListView1.SelectedItems.Count = 0 Then
                DeleteThisItemToolStripMenuItem.Enabled = False
                MoveUpToolStripMenuItem.Enabled = False
                MoveDownToolStripMenuItem.Enabled = False
                AddItemAfterThisItemToolStripMenuItem.Enabled = False
                AddItemBeforeThisItemToolStripMenuItem.Enabled = False
                MoveFirstToolStripMenuItem.Enabled = False
                MoveLastToolStripMenuItem.Enabled = False
            Else
                DeleteThisItemToolStripMenuItem.Enabled = True
                If ListView1.SelectedItems.Count > 1 Then
                    MoveUpToolStripMenuItem.Enabled = False
                    MoveDownToolStripMenuItem.Enabled = False
                    AddItemAfterThisItemToolStripMenuItem.Enabled = False
                    AddItemBeforeThisItemToolStripMenuItem.Enabled = False
                    MoveFirstToolStripMenuItem.Enabled = False
                    MoveLastToolStripMenuItem.Enabled = False
                Else
                    If ListView1.SelectedItems(0).Index > 0 Then
                        MoveUpToolStripMenuItem.Enabled = True
                        MoveFirstToolStripMenuItem.Enabled = True
                    Else
                        MoveUpToolStripMenuItem.Enabled = False
                        MoveFirstToolStripMenuItem.Enabled = False
                    End If
                    If ListView1.SelectedItems(0).Index < ListView1.Items.Count - 2 Then
                        MoveDownToolStripMenuItem.Enabled = True
                        MoveLastToolStripMenuItem.Enabled = True
                    Else
                        MoveDownToolStripMenuItem.Enabled = False
                        MoveLastToolStripMenuItem.Enabled = False
                    End If
                    AddItemAfterThisItemToolStripMenuItem.Enabled = True
                    AddItemBeforeThisItemToolStripMenuItem.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label3.Text = "Total Items : " & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        If ListView1.Sorting = SortOrder.Ascending Then
            ListView1.Sorting = SortOrder.Descending
        Else
            ListView1.Sorting = SortOrder.Ascending
        End If
    End Sub

    Private Sub MoveUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveUpToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems.Count > 1 Then
                MsgBox("Please select only one item!", MsgBoxStyle.Exclamation, "Selecting more than one item")
            Else
                Dim b As String = ListView1.SelectedItems(0).Text
                Dim bsub As String = ListView1.SelectedItems(0).SubItems(1).Text
                Dim c As Integer = ListView1.SelectedItems(0).Index
                ListView1.SelectedItems(0).Text = ListView1.Items(c - 1).Text
                ListView1.SelectedItems(0).SubItems(1).Text = ListView1.Items(c - 1).SubItems(1).Text
                ListView1.Items(c - 1).Text = b
                ListView1.Items(c - 1).SubItems(1).Text = bsub
                ListView1.SelectedIndices.Clear()
                ListView1.Items(c - 1).Selected = True
                ListView1.Select()
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MoveDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems.Count > 1 Then
                MsgBox("Please select only one item!", MsgBoxStyle.Exclamation, "Selecting more than one item")
            Else
                Dim b As String = ListView1.SelectedItems(0).Text
                Dim bsub As String = ListView1.SelectedItems(0).SubItems(1).Text
                Dim c As Integer = ListView1.SelectedItems(0).Index
                ListView1.SelectedItems(0).Text = ListView1.Items(c + 1).Text
                ListView1.SelectedItems(0).SubItems(1).Text = ListView1.Items(c + 1).SubItems(1).Text
                ListView1.Items(c + 1).Text = b
                ListView1.Items(c + 1).SubItems(1).Text = bsub
                ListView1.SelectedIndices.Clear()
                ListView1.Items(c + 1).Selected = True
                ListView1.Select()
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MoveUpToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MoveDownToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim a As String = ListView1.SelectedItems(0).Text
            Dim b As String = ListView1.SelectedItems(0).SubItems(1).Text
            ListView1.SelectedItems(0).Remove()
            ListView1.Items.Insert(0, a).SubItems.Add(b)
            ListView1.SelectedIndices.Clear()
            ListView1.Items(0).Selected = True
            ListView1.Select()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim a As String = ListView1.SelectedItems(0).Text
            Dim b As String = ListView1.SelectedItems(0).SubItems(1).Text
            ListView1.SelectedItems(0).Remove()
            ListView1.Items.Insert(ListView1.Items.Count - 1, a).SubItems.Add(b)
            ListView1.SelectedIndices.Clear()
            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.Select()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        If ListView1.SelectedItems.Count = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
        Else
            If ListView1.SelectedItems.Count > 1 Then
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
            Else
                If ListView1.SelectedItems(0).Index > 0 Then
                    Button4.Enabled = True
                    Button6.Enabled = True
                Else
                    Button4.Enabled = False
                    Button6.Enabled = False
                End If
                If ListView1.SelectedItems(0).Index < ListView1.Items.Count - 1 Then
                    Button5.Enabled = True
                    Button7.Enabled = True
                Else
                    Button5.Enabled = False
                    Button7.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub MoveFirstToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveFirstToolStripMenuItem.Click
        Button6.PerformClick()
    End Sub

    Private Sub MoveLastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveLastToolStripMenuItem.Click
        Button7.PerformClick()
    End Sub

    Private Sub AddItemAfterThisItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemAfterThisItemToolStripMenuItem.Click
        Try
            Dim c As Integer = ListView1.SelectedItems(0).Index
            ListView1.Items.Insert(c + 1, TextBox1.Text).SubItems.Add("None")
            ListView1.SelectedIndices.Clear()
            ListView1.Items(c + 1).Selected = True
            ListView1.Select()
            Label3.Text = "Total Items : " & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddItemBeforeThisItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemBeforeThisItemToolStripMenuItem.Click
        Try
            Dim c As Integer = ListView1.SelectedItems(0).Index
            ListView1.Items.Insert(ListView1.SelectedItems(0).Index, TextBox1.Text).SubItems.Add("None")
            ListView1.SelectedIndices.Clear()
            ListView1.Items(c).Selected = True
            ListView1.Select()
            Label3.Text = "Total Items : " & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DetailsDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsDefaultToolStripMenuItem.Click
        ListView1.View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ListView1.View = View.List
    End Sub

    Private Sub TilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesToolStripMenuItem.Click
        ListView1.View = View.Tile
    End Sub
End Class
