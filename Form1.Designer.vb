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
        Label2 = New Label()
        txtSecondNumber = New TextBox()
        btnCalculate = New Button()
        txtFirstNumber = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 1
        Label2.Text = "Second Number"
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Location = New Point(385, 129)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(150, 31)
        txtSecondNumber.TabIndex = 2
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(159, 252)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(112, 34)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Location = New Point(385, 58)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(150, 31)
        txtFirstNumber.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtFirstNumber)
        Controls.Add(btnCalculate)
        Controls.Add(txtSecondNumber)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtFirstNumber As TextBox
End Class
