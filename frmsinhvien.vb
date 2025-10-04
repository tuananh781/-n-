Imports System.Data
Imports System.Data.SqlClient

Public Class frmsinhvien
    Public isEdit As Boolean = False
    Private DBA As New DataBaseAccess

    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtmasv.Text) OrElse
               String.IsNullOrEmpty(txtten.Text) OrElse
               String.IsNullOrEmpty(txtdiachi.Text) OrElse
               String.IsNullOrEmpty(txtidlop.Text)
    End Function

    Private Function InsertSV() As Boolean
        Dim sqlQuery As String = "INSERT INTO [dbo].[sinhvien] ([MaSV], [TenSv], [Diachi], [idlop]) " &
                                 String.Format("VALUES ('{0}', N'{1}', N'{2}', '{3}')", txtmasv.Text, txtten.Text, txtdiachi.Text, txtidlop.Text)
        Return DBA.ExecuteNonQuery(sqlQuery)
    End Function

    Private Function UpdateSV() As Boolean
        Dim sqlQuery As String = "UPDATE [dbo].[sinhvien] SET " &
                                 String.Format("[TenSv] = N'{0}', [Diachi] = N'{1}', [idlop] = '{2}' WHERE [MaSV] = '{3}'",
                                               txtten.Text, txtdiachi.Text, txtidlop.Text, txtmasv.Text)
        Return DBA.ExecuteNonQuery(sqlQuery)
    End Function

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        If IsEmpty() Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As Boolean
        If isEdit Then
            result = UpdateSV()
        Else
            result = InsertSV()
        End If

        If result Then
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.No
        End If

        Me.Close()
    End Sub

    Private Sub btcancel_Click(sender As Object, e As EventArgs) Handles btcancel.Click
        Me.Close()
    End Sub
End Class
