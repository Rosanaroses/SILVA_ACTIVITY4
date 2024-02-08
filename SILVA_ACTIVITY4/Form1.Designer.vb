<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstNum = New TextBox()
        Label2 = New Label()
        txtSecondNum = New TextBox()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(14, 59)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(104, 23)
        txtFirstNum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second Number"
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(19, 133)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(105, 23)
        txtSecondNum.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(17, 174)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 25)
        Button1.TabIndex = 4
        Button1.Text = "Divide"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(22, 215)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(41, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(txtSecondNum)
        Controls.Add(Label2)
        Controls.Add(txtFirstNum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
