<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmqlsv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbtk = New Label()
        Label2 = New Label()
        dgvsinhvien = New DataGridView()
        btthem = New Button()
        btsua = New Button()
        btxoa = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        GroupBox1 = New GroupBox()
        cbclass = New ComboBox()
        txttk = New TextBox()
        cbtk = New ComboBox()
        CType(dgvsinhvien, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbtk
        ' 
        lbtk.AutoSize = True
        lbtk.Location = New Point(37, 55)
        lbtk.Name = "lbtk"
        lbtk.Size = New Size(70, 20)
        lbtk.TabIndex = 0
        lbtk.Text = "Tìm kiếm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 1
        Label2.Text = "Class:"
        ' 
        ' dgvsinhvien
        ' 
        dgvsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvsinhvien.Location = New Point(25, 96)
        dgvsinhvien.Name = "dgvsinhvien"
        dgvsinhvien.RowHeadersWidth = 51
        dgvsinhvien.Size = New Size(879, 500)
        dgvsinhvien.TabIndex = 2
        ' 
        ' btthem
        ' 
        btthem.Location = New Point(935, 130)
        btthem.Name = "btthem"
        btthem.Size = New Size(239, 29)
        btthem.TabIndex = 4
        btthem.Text = "Thêm"
        btthem.UseVisualStyleBackColor = True
        ' 
        ' btsua
        ' 
        btsua.Location = New Point(935, 187)
        btsua.Name = "btsua"
        btsua.Size = New Size(239, 29)
        btsua.TabIndex = 5
        btsua.Text = "Sửa"
        btsua.UseVisualStyleBackColor = True
        ' 
        ' btxoa
        ' 
        btxoa.Location = New Point(935, 242)
        btxoa.Name = "btxoa"
        btxoa.Size = New Size(239, 29)
        btxoa.TabIndex = 6
        btxoa.Text = "Xóa"
        btxoa.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbclass)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(943, 330)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(239, 213)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' cbclass
        ' 
        cbclass.FormattingEnabled = True
        cbclass.Location = New Point(24, 117)
        cbclass.Name = "cbclass"
        cbclass.Size = New Size(207, 36)
        cbclass.TabIndex = 8
        ' 
        ' txttk
        ' 
        txttk.Location = New Point(382, 56)
        txttk.Name = "txttk"
        txttk.Size = New Size(522, 27)
        txttk.TabIndex = 8
        ' 
        ' cbtk
        ' 
        cbtk.FormattingEnabled = True
        cbtk.Items.AddRange(New Object() {"MaSV", "TenSV"})
        cbtk.Location = New Point(128, 55)
        cbtk.Name = "cbtk"
        cbtk.Size = New Size(209, 28)
        cbtk.TabIndex = 9
        ' 
        ' frmqlsv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1203, 618)
        Controls.Add(cbtk)
        Controls.Add(txttk)
        Controls.Add(GroupBox1)
        Controls.Add(btxoa)
        Controls.Add(btsua)
        Controls.Add(btthem)
        Controls.Add(dgvsinhvien)
        Controls.Add(lbtk)
        Name = "frmqlsv"
        Text = "QUẢN LÍ SINH VIÊN"
        CType(dgvsinhvien, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbtk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvsinhvien As DataGridView
    Friend WithEvents btthem As Button
    Friend WithEvents btsua As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbclass As ComboBox
    Friend WithEvents txttk As TextBox
    Friend WithEvents cbtk As ComboBox

End Class
