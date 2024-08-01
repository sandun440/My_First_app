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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnCalculate = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstNumber = New TextBox()
        txtSecondNumber = New TextBox()
        txtTotal = New TextBox()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnCalculate.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(199, 261)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Padding = New Padding(10)
        btnCalculate.Size = New Size(200, 69)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(12, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 24)
        Label1.TabIndex = 1
        Label1.Text = "First number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(12, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 24)
        Label2.TabIndex = 2
        Label2.Text = "Second number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(12, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 24)
        Label3.TabIndex = 3
        Label3.Text = "Total"
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Font = New Font("Arial Narrow", 13.8F)
        txtFirstNumber.Location = New Point(199, 42)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(200, 34)
        txtFirstNumber.TabIndex = 4
        txtFirstNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Font = New Font("Arial Narrow", 13.8F)
        txtSecondNumber.Location = New Point(199, 97)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(200, 34)
        txtSecondNumber.TabIndex = 5
        txtSecondNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = SystemColors.ButtonHighlight
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Arial Narrow", 18.0F)
        txtTotal.ForeColor = Color.Black
        txtTotal.Location = New Point(199, 180)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(200, 42)
        txtTotal.TabIndex = 6
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnReset.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.Brown
        btnReset.Location = New Point(23, 261)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(170, 69)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(460, 357)
        Controls.Add(btnReset)
        Controls.Add(txtTotal)
        Controls.Add(txtSecondNumber)
        Controls.Add(txtFirstNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCalculate)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "My First App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnReset As Button

End Class
