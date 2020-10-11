<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnINPUT = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.Button()
        Me.btnCREATE = New System.Windows.Forms.Button()
        Me.btnSAVETOFILE = New System.Windows.Forms.Button()
        Me.txtDispaly = New System.Windows.Forms.TextBox()
        Me.txtfiledisplay = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnINPUT
        '
        Me.btnINPUT.Location = New System.Drawing.Point(24, 27)
        Me.btnINPUT.Name = "btnINPUT"
        Me.btnINPUT.Size = New System.Drawing.Size(227, 38)
        Me.btnINPUT.TabIndex = 0
        Me.btnINPUT.Text = "INPUT"
        Me.btnINPUT.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(24, 71)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(227, 28)
        Me.txtDisplay.TabIndex = 2
        Me.txtDisplay.Text = "DISPLAY"
        Me.txtDisplay.UseVisualStyleBackColor = True
        '
        'btnCREATE
        '
        Me.btnCREATE.Location = New System.Drawing.Point(24, 105)
        Me.btnCREATE.Name = "btnCREATE"
        Me.btnCREATE.Size = New System.Drawing.Size(227, 33)
        Me.btnCREATE.TabIndex = 3
        Me.btnCREATE.Text = "CREATE FILE"
        Me.btnCREATE.UseVisualStyleBackColor = True
        '
        'btnSAVETOFILE
        '
        Me.btnSAVETOFILE.Location = New System.Drawing.Point(24, 144)
        Me.btnSAVETOFILE.Name = "btnSAVETOFILE"
        Me.btnSAVETOFILE.Size = New System.Drawing.Size(227, 34)
        Me.btnSAVETOFILE.TabIndex = 4
        Me.btnSAVETOFILE.Text = "SAVE TO FILE"
        Me.btnSAVETOFILE.UseVisualStyleBackColor = True
        '
        'txtDispaly
        '
        Me.txtDispaly.Location = New System.Drawing.Point(275, 27)
        Me.txtDispaly.Multiline = True
        Me.txtDispaly.Name = "txtDispaly"
        Me.txtDispaly.Size = New System.Drawing.Size(513, 141)
        Me.txtDispaly.TabIndex = 5
        '
        'txtfiledisplay
        '
        Me.txtfiledisplay.Location = New System.Drawing.Point(24, 218)
        Me.txtfiledisplay.Name = "txtfiledisplay"
        Me.txtfiledisplay.Size = New System.Drawing.Size(227, 20)
        Me.txtfiledisplay.TabIndex = 6
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(24, 184)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(227, 28)
        Me.btnRead.TabIndex = 7
        Me.btnRead.Text = "READ FROM FILE"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 258)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtfiledisplay)
        Me.Controls.Add(Me.txtDispaly)
        Me.Controls.Add(Me.btnSAVETOFILE)
        Me.Controls.Add(Me.btnCREATE)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnINPUT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnINPUT As Button
    Friend WithEvents txtDisplay As Button
    Friend WithEvents btnCREATE As Button
    Friend WithEvents btnSAVETOFILE As Button
    Friend WithEvents txtDispaly As TextBox
    Friend WithEvents txtfiledisplay As TextBox
    Friend WithEvents btnRead As Button
End Class
