Public Class Form1
    Dim num As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Integer = Val(InputBox("请输入层数"))
        For i As Integer = 1 To n
            Dim item As String = ""
            For k As Integer = n - i To 0 Step -1
                item = item & Space(1)
            Next
            For j As Integer = 1 To -1 + 2 * i
                item = item & CStr(i)
            Next
            ListBox1.Items.Add(item)
        Next
        'ListBox1.Items.Add("     1")
        'ListBox1.Items.Add("    222")
        'ListBox1.Items.Add("   33333")
        'ListBox1.Items.Add("  4444444")
        'ListBox1.Items.Add(" 555555555")
        'ListBox1.Items.Add("66666666666")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.Items.Count > 0 Then
            If ListBox2.Items.Count = 0 Then
                ListBox2.Items.Insert(0, ListBox1.Items(0))
                ListBox1.Items.Remove(ListBox1.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox1.Items(0) < ListBox2.Items(0) Then
                    ListBox2.Items.Insert(0, ListBox1.Items(0))
                    ListBox1.Items.Remove(ListBox1.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox2.Items.Count > 0 Then
            If ListBox3.Items.Count = 0 Then
                ListBox3.Items.Insert(0, ListBox2.Items(0))
                ListBox2.Items.Remove(ListBox2.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox2.Items(0) < ListBox3.Items(0) Then
                    ListBox3.Items.Insert(0, ListBox2.Items(0))
                    ListBox2.Items.Remove(ListBox2.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox2.Items.Count > 0 Then
            If ListBox1.Items.Count = 0 Then
                ListBox1.Items.Insert(0, ListBox2.Items(0))
                ListBox2.Items.Remove(ListBox2.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox2.Items(0) < ListBox1.Items(0) Then
                    ListBox1.Items.Insert(0, ListBox2.Items(0))
                    ListBox2.Items.Remove(ListBox2.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox3.Items.Count > 0 Then
            If ListBox2.Items.Count = 0 Then
                ListBox2.Items.Insert(0, ListBox3.Items(0))
                ListBox3.Items.Remove(ListBox3.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox3.Items(0) < ListBox2.Items(0) Then
                    ListBox2.Items.Insert(0, ListBox3.Items(0))
                    ListBox3.Items.Remove(ListBox3.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListBox1.Items.Count > 0 Then
            If ListBox3.Items.Count = 0 Then
                ListBox3.Items.Insert(0, ListBox1.Items(0))
                ListBox1.Items.Remove(ListBox1.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox1.Items(0) < ListBox3.Items(0) Then
                    ListBox3.Items.Insert(0, ListBox1.Items(0))
                    ListBox1.Items.Remove(ListBox1.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListBox3.Items.Count > 0 Then
            If ListBox1.Items.Count = 0 Then
                ListBox1.Items.Insert(0, ListBox3.Items(0))
                ListBox3.Items.Remove(ListBox3.Items(0))
            Else
                'If ListBox1.Items(0) > ListBox1.Items(0) Then
                'MsgBox("大数不能在小数上")
                If ListBox3.Items(0) < ListBox1.Items(0) Then
                    ListBox1.Items.Insert(0, ListBox3.Items(0))
                    ListBox3.Items.Remove(ListBox3.Items(0))
                Else
                    MsgBox("大数不能放在小数上")
                End If
            End If
        Else
            MsgBox("没有什么可以移了")
        End If
        num += 1
        Label2.Text = num
    End Sub
End Class
