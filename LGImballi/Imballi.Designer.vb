<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imballi
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
        Me.Alt_B = New System.Windows.Forms.TextBox()
        Me.Larg = New System.Windows.Forms.TextBox()
        Me.Lung = New System.Windows.Forms.TextBox()
        Me.Alt_I = New System.Windows.Forms.TextBox()
        Me.Larg_I = New System.Windows.Forms.TextBox()
        Me.Lungh_I = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mat = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Alt_B
        '
        Me.Alt_B.Location = New System.Drawing.Point(94, 42)
        Me.Alt_B.Name = "Alt_B"
        Me.Alt_B.Size = New System.Drawing.Size(100, 20)
        Me.Alt_B.TabIndex = 0
        '
        'Larg
        '
        Me.Larg.Location = New System.Drawing.Point(94, 88)
        Me.Larg.Name = "Larg"
        Me.Larg.Size = New System.Drawing.Size(100, 20)
        Me.Larg.TabIndex = 1
        '
        'Lung
        '
        Me.Lung.Location = New System.Drawing.Point(94, 143)
        Me.Lung.Name = "Lung"
        Me.Lung.Size = New System.Drawing.Size(100, 20)
        Me.Lung.TabIndex = 2
        '
        'Alt_I
        '
        Me.Alt_I.Location = New System.Drawing.Point(255, 42)
        Me.Alt_I.Name = "Alt_I"
        Me.Alt_I.Size = New System.Drawing.Size(100, 20)
        Me.Alt_I.TabIndex = 3
        '
        'Larg_I
        '
        Me.Larg_I.Location = New System.Drawing.Point(255, 88)
        Me.Larg_I.Name = "Larg_I"
        Me.Larg_I.Size = New System.Drawing.Size(100, 20)
        Me.Larg_I.TabIndex = 4
        '
        'Lungh_I
        '
        Me.Lungh_I.Location = New System.Drawing.Point(255, 143)
        Me.Lungh_I.Name = "Lungh_I"
        Me.Lungh_I.Size = New System.Drawing.Size(100, 20)
        Me.Lungh_I.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Calcola"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mat
        '
        Me.Mat.Location = New System.Drawing.Point(255, 194)
        Me.Mat.Name = "Mat"
        Me.Mat.Size = New System.Drawing.Size(100, 20)
        Me.Mat.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 263)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Imballi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 320)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lungh_I)
        Me.Controls.Add(Me.Larg_I)
        Me.Controls.Add(Me.Alt_I)
        Me.Controls.Add(Me.Lung)
        Me.Controls.Add(Me.Larg)
        Me.Controls.Add(Me.Alt_B)
        Me.Name = "Imballi"
        Me.Text = "Imballi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Alt_B As TextBox
    Friend WithEvents Larg As TextBox
    Friend WithEvents Lung As TextBox
    Friend WithEvents Alt_I As TextBox
    Friend WithEvents Larg_I As TextBox
    Friend WithEvents Lungh_I As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Mat As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
