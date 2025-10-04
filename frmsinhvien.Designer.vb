<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsinhvien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtmasv = New TextBox()
        txtidlop = New TextBox()
        txtdiachi = New TextBox()
        txtten = New TextBox()
        btok = New Button()
        btcancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 266)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 1
        Label1.Text = "Mã SV:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 2
        Label2.Text = "Tên:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 3
        Label3.Text = "Địa chỉ:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 4
        Label4.Text = "ID lớp:"
        ' 
        ' txtmasv
        ' 
        txtmasv.Location = New Point(164, 266)
        txtmasv.Name = "txtmasv"
        txtmasv.Size = New Size(302, 27)
        txtmasv.TabIndex = 6
        ' 
        ' txtidlop
        ' 
        txtidlop.Location = New Point(164, 64)
        txtidlop.Name = "txtidlop"
        txtidlop.ReadOnly = True
        txtidlop.Size = New Size(302, 27)
        txtidlop.TabIndex = 8
        ' 
        ' txtdiachi
        ' 
        txtdiachi.Location = New Point(164, 194)
        txtdiachi.Name = "txtdiachi"
        txtdiachi.Size = New Size(302, 27)
        txtdiachi.TabIndex = 9
        ' 
        ' txtten
        ' 
        txtten.Location = New Point(164, 128)
        txtten.Name = "txtten"
        txtten.Size = New Size(302, 27)
        txtten.TabIndex = 10
        ' 
        ' btok
        ' 
        btok.Location = New Point(164, 350)
        btok.Name = "btok"
        btok.Size = New Size(107, 51)
        btok.TabIndex = 11
        btok.Text = "&Ok"
        btok.UseVisualStyleBackColor = True
        ' 
        ' btcancel
        ' 
        btcancel.Location = New Point(338, 350)
        btcancel.Name = "btcancel"
        btcancel.Size = New Size(128, 51)
        btcancel.TabIndex = 12
        btcancel.Text = "&Cancel"
        btcancel.UseVisualStyleBackColor = True
        ' 
        ' frmsinhvien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 420)
        Controls.Add(btcancel)
        Controls.Add(btok)
        Controls.Add(txtten)
        Controls.Add(txtdiachi)
        Controls.Add(txtidlop)
        Controls.Add(txtmasv)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmsinhvien"
        Text = "frmsinhvien"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmasv As TextBox
    Friend WithEvents txtidlop As TextBox
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents txtten As TextBox
    Friend WithEvents btok As Button
    Friend WithEvents btcancel As Button
End Class
