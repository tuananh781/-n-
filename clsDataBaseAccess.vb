Imports System.Data
Imports System.Data.SqlClient

Public Class DataBaseAccess
    Private connectionString As String = "Data Source=.;Initial Catalog=qlsv;Integrated Security=True"

    '=== Lấy dữ liệu dạng DataTable ===
    Public Function GetDataTable(sqlQuery As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sqlQuery, con)
                con.Open()
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    '=== Thực thi câu lệnh không trả dữ liệu (INSERT, UPDATE, DELETE) ===
    Public Function ExecuteNonQuery(sqlQuery As String) As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(sqlQuery, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thực thi SQL: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
