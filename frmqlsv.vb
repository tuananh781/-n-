Imports System.Data
Imports System.Data.SqlClient

Public Class frmqlsv
    Private DBA As New DataBaseAccess()
    Private isload As Boolean = False

    '=== Load danh sách lớp ===
    Private Sub LoadData()
        Dim sqlQuery As String = "SELECT [idlop], [tenlop] FROM [dbo].[lop]"
        Dim dtable As DataTable = DBA.GetDataTable(sqlQuery)
        Me.cbclass.DataSource = dtable
        Me.cbclass.ValueMember = "idlop"
        Me.cbclass.DisplayMember = "tenlop"
    End Sub

    '=== Load danh sách sinh viên theo lớp ===
    Private Sub LoadDataGr(idlop As String)
        Dim sqlQuery As String = $"SELECT [MaSV], [TenSv], [Diachi], [idlop] FROM [dbo].[sinhvien] WHERE [idlop] = '{idlop}'"
        Dim dtable As DataTable = DBA.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dtable
        With Me.dgvsinhvien
            .Columns(0).HeaderText = "Mã SV"
            .Columns(1).HeaderText = "Tên SV"
            .Columns(2).HeaderText = "Địa chỉ"
            .Columns(3).HeaderText = "Mã lớp"
        End With
    End Sub

    '=== Form load ===
    Private Sub frmqlsv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbtk.SelectedIndex = 0
        isload = False
        LoadData()
        isload = True

        If cbclass.SelectedValue IsNot Nothing AndAlso Not TypeOf cbclass.SelectedValue Is DataRowView Then
            LoadDataGr(cbclass.SelectedValue.ToString())
        End If
    End Sub

    '=== Khi chọn lớp ===
    Private Sub cbclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclass.SelectedIndexChanged
        If Not isload Then Exit Sub
        If cbclass.SelectedValue Is Nothing OrElse TypeOf cbclass.SelectedValue Is DataRowView Then Exit Sub
        LoadDataGr(cbclass.SelectedValue.ToString())
    End Sub

    '=== Tìm kiếm sinh viên ===
    Private Sub tksinhvien(idlop As String, value As String)
        If String.IsNullOrWhiteSpace(value) Then
            LoadDataGr(idlop)
            Exit Sub
        End If

        Dim sqlQuery As String = $"SELECT [MaSV], [TenSv], [Diachi], [idlop] FROM [dbo].[sinhvien] WHERE [idlop] = '{idlop}'"
        If Me.cbtk.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND MaSV LIKE '{0}%'", value)
        ElseIf Me.cbtk.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND TenSV LIKE N'{0}%'", value)
        End If

        Dim dtable As DataTable = DBA.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dtable
    End Sub

    '=== Khi thay đổi combobox tìm kiếm ===
    Private Sub cbtk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtk.SelectedIndexChanged
        If cbclass.SelectedValue Is Nothing OrElse TypeOf cbclass.SelectedValue Is DataRowView Then Exit Sub
        tksinhvien(cbclass.SelectedValue.ToString(), txttk.Text)
    End Sub

    '=== Khi gõ trong ô tìm kiếm ===
    Private Sub txttk_TextChanged(sender As Object, e As EventArgs) Handles txttk.TextChanged
        If cbclass.SelectedValue Is Nothing OrElse TypeOf cbclass.SelectedValue Is DataRowView Then Exit Sub
        tksinhvien(cbclass.SelectedValue.ToString(), txttk.Text)
    End Sub

    '=== Thêm sinh viên ===
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim frm As New frmsinhvien
        frm.txtidlop.Text = Me.cbclass.SelectedValue.ToString()
        frm.Text = "Thêm sinh viên"
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataGr(Me.cbclass.SelectedValue)
        End If
    End Sub

    '=== Sửa sinh viên ===
    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        If dgvsinhvien.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim frm As New frmsinhvien
        frm.txtmasv.Text = dgvsinhvien.CurrentRow.Cells(0).Value.ToString()
        frm.txtten.Text = dgvsinhvien.CurrentRow.Cells(1).Value.ToString()
        frm.txtdiachi.Text = dgvsinhvien.CurrentRow.Cells(2).Value.ToString()
        frm.txtidlop.Text = dgvsinhvien.CurrentRow.Cells(3).Value.ToString()
        frm.Text = "Sửa sinh viên"
        frm.isEdit = True
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            LoadDataGr(Me.cbclass.SelectedValue)
        End If
    End Sub

    '=== Xóa sinh viên ===
    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        If dgvsinhvien.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim masv As String = dgvsinhvien.CurrentRow.Cells(0).Value.ToString()
        If MessageBox.Show("Bạn có chắc muốn xóa sinh viên có mã: " & masv & " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sql As String = $"DELETE FROM [dbo].[sinhvien] WHERE MaSV = '{masv}'"
            If DBA.ExecuteNonQuery(sql) Then
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataGr(Me.cbclass.SelectedValue)
            End If
        End If
    End Sub
End Class
