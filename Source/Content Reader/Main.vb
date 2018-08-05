Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Public Class Main
    Dim d As Double
    Private Sub LocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationButton.Click
        Try
            If DontClear.Checked = False Then
                ItemsList.Items.Clear()
                d = 0
            End If
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                adding(FolderBrowserDialog1.SelectedPath)
            End If
            Label3.Text = "Total Items : " & ItemsList.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub adding(path As String)
        LocationLabel.Text = path
        If LocationLabel.Text.Count = 3 Then
            LocationLabel.Text = path
        Else
            LocationLabel.Text = path + "\"
        End If
        Dim di As New IO.DirectoryInfo(path)
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
                ItemsList.Items.Add(dra.ToString).SubItems.Add(b)
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
                        ItemsList.Items.Add("> " & sdra.ToString).SubItems.Add(b)
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
                        ItemsList.Items.Add("> " & sdra2.ToString).SubItems.Add(b)
                    Next
                End If
            Else
                ItemsList.Items.Add(dra.ToString).SubItems.Add("None")
                If CheckBox5.Checked = True Then
                    Dim sdi As New IO.DirectoryInfo(di.ToString & "\" & dra.ToString)
                    Dim sdiar1 As IO.DirectoryInfo() = sdi.GetDirectories()
                    Dim sdra As IO.DirectoryInfo
                    Dim sdiar2 As IO.FileInfo() = sdi.GetFiles
                    Dim sdra2 As IO.FileInfo
                    For Each sdra In sdiar1
                        ItemsList.Items.Add("> " & sdra.ToString).SubItems.Add("None")
                    Next
                    For Each sdra2 In sdiar2
                        ItemsList.Items.Add("> " & sdra2.ToString).SubItems.Add("None")
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
                ItemsList.Items.Add(dra2.ToString).SubItems.Add(b)
            Else
                ItemsList.Items.Add(dra2.ToString).SubItems.Add("None")
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
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label3.Text = "Total Items : " & ItemsList.Items.Count
        Try
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                If SaveFileDialog1.FilterIndex = 2 Then
                    Dim headers = (From ch In ItemsList.Columns Let header = DirectCast(ch, ColumnHeader) Select header.Text).ToArray()
                    Dim items() = (From item In ItemsList.Items Let lvi = DirectCast(item, ListViewItem) Select (From subitem In lvi.SubItems Let si = DirectCast(subitem, ListViewItem.ListViewSubItem) Select si.Text).ToArray()).ToArray()
                    Dim table As String = String.Join(",", headers) & Environment.NewLine
                    For Each a In items
                        table &= String.Join(",", a) & Environment.NewLine
                    Next
                    table = table.TrimEnd(CChar(vbCr), CChar(vbLf))
                    IO.File.WriteAllText(SaveFileDialog1.FileName, table)

                Else
                    Dim myWriter As New IO.StreamWriter(SaveFileDialog1.FileName)
                    For Each myItem As ListViewItem In ItemsList.Items
                        If ItemsList.Items(1).SubItems(1).Text = "None" Then
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
                    If AddTotalSpace.Checked = True Then
                        System.IO.File.AppendAllText(SaveFileDialog1.FileName, Label2.Text & vbNewLine)
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("There was an error occured while saving" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Listview1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ItemsList.KeyDown
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
                    ItemsList.Items.Add(TextBox1.Text).SubItems.Add("None")
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
                    ItemsList.Items.Add(TextBox1.Text).SubItems.Add(substring)
                End If
                TextBox1.Text = ""
                TextBox2.Text = ""
                ItemsList.SelectedIndices.Clear()
                ItemsList.Items.Item(ItemsList.Items.Count - 1).Selected = True
                ItemsList.Select()
            Else
                MsgBox("Please type a name at least!", MsgBoxStyle.Critical, "Error")
            End If
            Label3.Text = "Total Items : " & ItemsList.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog(Me)
    End Sub

    Private Sub DeleteThisItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteThisItemToolStripMenuItem.Click
        If ItemsList.Items.Count > 0 Then
            Try
                Dim current As Integer = ItemsList.SelectedItems(0).Index
                For Each i As ListViewItem In ItemsList.SelectedItems
                    ItemsList.Items.Remove(i)
                Next
                Try
                    ItemsList.SelectedIndices.Clear()
                    ItemsList.Items(current).Selected = True
                    ItemsList.Select()
                Catch
                End Try
                Label3.Text = "Total Items : " & ItemsList.Items.Count
            Catch ex As Exception
                MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            ItemsList.Items.Clear()
            Label2.Text = "Total Space : 0"
            Label3.Text = "Total Items : 0"
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ListContextMenuStrip.Opening
        Try
            If ItemsList.Items.Count = 0 Then
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
            If ItemsList.SelectedItems.Count = 0 Then
                DeleteThisItemToolStripMenuItem.Enabled = False
                MoveUpToolStripMenuItem.Enabled = False
                MoveDownToolStripMenuItem.Enabled = False
                AddItemAfterThisItemToolStripMenuItem.Enabled = False
                AddItemBeforeThisItemToolStripMenuItem.Enabled = False
                MoveFirstToolStripMenuItem.Enabled = False
                MoveLastToolStripMenuItem.Enabled = False
            Else
                DeleteThisItemToolStripMenuItem.Enabled = True
                If ItemsList.SelectedItems.Count > 1 Then
                    MoveUpToolStripMenuItem.Enabled = False
                    MoveDownToolStripMenuItem.Enabled = False
                    AddItemAfterThisItemToolStripMenuItem.Enabled = False
                    AddItemBeforeThisItemToolStripMenuItem.Enabled = False
                    MoveFirstToolStripMenuItem.Enabled = False
                    MoveLastToolStripMenuItem.Enabled = False
                Else
                    If ItemsList.SelectedItems(0).Index > 0 Then
                        MoveUpToolStripMenuItem.Enabled = True
                        MoveFirstToolStripMenuItem.Enabled = True
                    Else
                        MoveUpToolStripMenuItem.Enabled = False
                        MoveFirstToolStripMenuItem.Enabled = False
                    End If
                    If ItemsList.SelectedItems(0).Index < ItemsList.Items.Count - 2 Then
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
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
            Me.TitleLabel.Text = "B++ -Content-Reader- V" + Application.ProductVersion
            If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Content-Reader") Is Nothing Then
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\", True).CreateSubKey("Content-Reader")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "", """" & Application.ExecutablePath & """")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "Path", """" & Application.StartupPath & """")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "3")
            Else
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "").ToString = "1" Then
                    System.Threading.Thread.Sleep(2000)
                    Dim location As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "", Nothing).ToString
                    location = location.Replace(Chr(34), "")
                    My.Computer.FileSystem.CopyFile(Application.ExecutablePath, location, True)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "2")
                    Process.Start(location)
                    End
                ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "").ToString = "2" Then
                    System.Threading.Thread.Sleep(2000)
                    System.IO.Directory.Delete(Application.StartupPath + "\update", True)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "3")
                Else
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "", """" & Application.ExecutablePath & """")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "Path", """" & Application.StartupPath & """")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Content-Reader", "ulevel", "3")
                End If
            End If
            Label3.Text = "Total Items : " & ItemsList.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ItemsList.ColumnClick
        If ItemsList.Sorting = SortOrder.Ascending Then
            ItemsList.Sorting = SortOrder.Descending
        Else
            ItemsList.Sorting = SortOrder.Ascending
        End If
    End Sub

    Private Sub MoveUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveUpToolStripMenuItem.Click
        Try
            If ItemsList.SelectedItems.Count > 1 Then
                MsgBox("Please select only one item!", MsgBoxStyle.Exclamation, "Selecting more than one item")
            Else
                Dim b As String = ItemsList.SelectedItems(0).Text
                Dim bsub As String = ItemsList.SelectedItems(0).SubItems(1).Text
                Dim c As Integer = ItemsList.SelectedItems(0).Index
                ItemsList.SelectedItems(0).Text = ItemsList.Items(c - 1).Text
                ItemsList.SelectedItems(0).SubItems(1).Text = ItemsList.Items(c - 1).SubItems(1).Text
                ItemsList.Items(c - 1).Text = b
                ItemsList.Items(c - 1).SubItems(1).Text = bsub
                ItemsList.SelectedIndices.Clear()
                ItemsList.Items(c - 1).Selected = True
                ItemsList.Select()
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MoveDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem.Click
        Try
            If ItemsList.SelectedItems.Count > 1 Then
                MsgBox("Please select only one item!", MsgBoxStyle.Exclamation, "Selecting more than one item")
            Else
                Dim b As String = ItemsList.SelectedItems(0).Text
                Dim bsub As String = ItemsList.SelectedItems(0).SubItems(1).Text
                Dim c As Integer = ItemsList.SelectedItems(0).Index
                ItemsList.SelectedItems(0).Text = ItemsList.Items(c + 1).Text
                ItemsList.SelectedItems(0).SubItems(1).Text = ItemsList.Items(c + 1).SubItems(1).Text
                ItemsList.Items(c + 1).Text = b
                ItemsList.Items(c + 1).SubItems(1).Text = bsub
                ItemsList.SelectedIndices.Clear()
                ItemsList.Items(c + 1).Selected = True
                ItemsList.Select()
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
            Dim a As String = ItemsList.SelectedItems(0).Text
            Dim b As String = ItemsList.SelectedItems(0).SubItems(1).Text
            ItemsList.SelectedItems(0).Remove()
            ItemsList.Items.Insert(0, a).SubItems.Add(b)
            ItemsList.SelectedIndices.Clear()
            ItemsList.Items(0).Selected = True
            ItemsList.Select()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim a As String = ItemsList.SelectedItems(0).Text
            Dim b As String = ItemsList.SelectedItems(0).SubItems(1).Text
            ItemsList.SelectedItems(0).Remove()
            ItemsList.Items.Insert(ItemsList.Items.Count - 1, a).SubItems.Add(b)
            ItemsList.SelectedIndices.Clear()
            ItemsList.Items(ItemsList.Items.Count - 1).Selected = True
            ItemsList.Select()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ItemsList.ItemSelectionChanged
        If ItemsList.SelectedItems.Count = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
        Else
            If ItemsList.SelectedItems.Count > 1 Then
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
            Else
                If ItemsList.SelectedItems(0).Index > 0 Then
                    Button4.Enabled = True
                    Button6.Enabled = True
                Else
                    Button4.Enabled = False
                    Button6.Enabled = False
                End If
                If ItemsList.SelectedItems(0).Index < ItemsList.Items.Count - 1 Then
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
            Dim c As Integer = ItemsList.SelectedItems(0).Index
            ItemsList.Items.Insert(c + 1, TextBox1.Text).SubItems.Add("None")
            ItemsList.SelectedIndices.Clear()
            ItemsList.Items(c + 1).Selected = True
            ItemsList.Select()
            Label3.Text = "Total Items : " & ItemsList.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddItemBeforeThisItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemBeforeThisItemToolStripMenuItem.Click
        Try
            Dim c As Integer = ItemsList.SelectedItems(0).Index
            ItemsList.Items.Insert(ItemsList.SelectedItems(0).Index, TextBox1.Text).SubItems.Add("None")
            ItemsList.SelectedIndices.Clear()
            ItemsList.Items(c).Selected = True
            ItemsList.Select()
            Label3.Text = "Total Items : " & ItemsList.Items.Count
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DetailsDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsDefaultToolStripMenuItem.Click
        ItemsList.View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ItemsList.View = View.List
    End Sub

    Private Sub TilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesToolStripMenuItem.Click
        ItemsList.View = View.Tile
    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ItemsList.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                For i As Integer = 0 To filePaths.Count - 1
                    If Directory.Exists(filePaths(i)) Then
                        adding(filePaths(i))
                    ElseIf File.Exists(filePaths(i)) Then
                        Dim a As Double
                        Dim b As String
                        If CheckBox2.Checked = True Then
                            Dim c = My.Computer.FileSystem.GetFileInfo(filePaths(i))
                            a = c.Length / 1024 / 1024
                            d = d + a
                            a = Format(a, "Fixed")
                            b = a & " MB"
                            If a > 1000 Then
                                b = b & "(" & Format(a / 1024, "Fixed") & "GB)"
                            ElseIf a < 1 Then
                                b = b & "(" & Format(a * 1024, "Fixed") & "KB)"
                            End If
                            ItemsList.Items.Add(System.IO.Path.GetFileName(filePaths(i))).SubItems.Add(b)
                        Else
                            ItemsList.Items.Add(System.IO.Path.GetFileName(filePaths(i))).SubItems.Add("None")
                        End If

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
                Next
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ItemsList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If OptionsPanel.Width = 200 Then
            While OptionsPanel.Width > 50
                OptionsPanel.Width -= 5
                MenuButton.Location = New Point(MenuButton.Location.X - 5, MenuButton.Location.Y)
                ItemsList.Location = New Point(ItemsList.Location.X - 5, ItemsList.Location.Y)
                ItemsList.Width = ItemsList.Width + 5
                System.Threading.Thread.Sleep(1)
            End While
            NameColumn.Width += 125
            SizeColumn.Width += 25
        Else
            While OptionsPanel.Width < 200
                OptionsPanel.Width += 5
                MenuButton.Location = New Point(MenuButton.Location.X + 5, MenuButton.Location.Y)
                ItemsList.Location = New Point(ItemsList.Location.X + 5, ItemsList.Location.Y)
                ItemsList.Width = ItemsList.Width - 5
                System.Threading.Thread.Sleep(1)
            End While
            NameColumn.Width -= 125
            SizeColumn.Width -= 25
        End If
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub TopPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseDown, TitleLabel.MouseDown, LocationLabel.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TopPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseMove, TitleLabel.MouseMove, LocationLabel.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TopPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseUp, TitleLabel.MouseUp, LocationLabel.MouseUp
        drag = False
    End Sub

    Private Sub ContentIcon_Click(sender As Object, e As EventArgs) Handles ContentIcon.Click
        About.ShowDialog()
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = Not (AlwaysOnTopToolStripMenuItem.Checked)
        AlwaysOnTopToolStripMenuItem.Checked = Not (AlwaysOnTopToolStripMenuItem.Checked)
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Try
            If My.Computer.Network.IsAvailable Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/bssam1996/Content-Reader/master/Version")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim modnewestversion As String = newestversion.Replace(".", "")
                Dim currentversion As String = Application.ProductVersion
                currentversion = currentversion.Replace(".", "")
                If Integer.Parse(modnewestversion) <= Integer.Parse(currentversion) Then
                    MsgBox("You are up to date!", MsgBoxStyle.Information, "Version is up to date")
                Else
                    If MsgBox("Update Found Version : " + newestversion + vbNewLine + "Would you like to update now?", vbInformation + vbYesNo) = MsgBoxResult.Yes Then
                        updateform.ShowDialog()
                    End If
                End If
            Else
                MsgBox("Please Check your network!", MsgBoxStyle.Critical, "Network Unavailable")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
