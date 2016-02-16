<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class message_information
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
        Me.lbl_contentMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_information = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_msg_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_contentMessage
        '
        Me.lbl_contentMessage.AutoSize = True
        Me.lbl_contentMessage.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contentMessage.Location = New System.Drawing.Point(142, 95)
        Me.lbl_contentMessage.Name = "lbl_contentMessage"
        Me.lbl_contentMessage.Size = New System.Drawing.Size(137, 27)
        Me.lbl_contentMessage.TabIndex = 12
        Me.lbl_contentMessage.Text = "ពត៍មានសាររបស់អ្ន​ក!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Bokor", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 43)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ចំណងជើងសារ"
        '
        'lbl_information
        '
        Me.lbl_information.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_information.Location = New System.Drawing.Point(-1, 0)
        Me.lbl_information.Name = "lbl_information"
        Me.lbl_information.Size = New System.Drawing.Size(517, 59)
        Me.lbl_information.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Image = Global.VBLoan.My.Resources.Resources.information_icon
        Me.Label3.Location = New System.Drawing.Point(72, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 65)
        Me.Label3.TabIndex = 14
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(514, 230)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -4
        Me.LineShape1.X2 = 516
        Me.LineShape1.Y1 = 169
        Me.LineShape1.Y2 = 173
        '
        'btn_msg_ok
        '
        Me.btn_msg_ok.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_msg_ok.Location = New System.Drawing.Point(182, 179)
        Me.btn_msg_ok.Name = "btn_msg_ok"
        Me.btn_msg_ok.Size = New System.Drawing.Size(111, 38)
        Me.btn_msg_ok.TabIndex = 16
        Me.btn_msg_ok.Text = "យល់ព្រម"
        Me.btn_msg_ok.UseVisualStyleBackColor = True
        '
        'message_information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 230)
        Me.Controls.Add(Me.btn_msg_ok)
        Me.Controls.Add(Me.lbl_contentMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_information)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "message_information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "message_information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_information As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_msg_ok As System.Windows.Forms.Button
    Public WithEvents lbl_contentMessage As System.Windows.Forms.Label
End Class
