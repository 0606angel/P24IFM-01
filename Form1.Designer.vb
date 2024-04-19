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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enter_nqf_credit_input = New System.Windows.Forms.TextBox()
        Me.calculateBTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total_hours_output = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.average_hours_per_week_output = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter NQF Credit:"
        '
        'enter_nqf_credit_input
        '
        Me.enter_nqf_credit_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enter_nqf_credit_input.Location = New System.Drawing.Point(231, 28)
        Me.enter_nqf_credit_input.Name = "enter_nqf_credit_input"
        Me.enter_nqf_credit_input.Size = New System.Drawing.Size(144, 27)
        Me.enter_nqf_credit_input.TabIndex = 1
        '
        'calculateBTN
        '
        Me.calculateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateBTN.Location = New System.Drawing.Point(81, 94)
        Me.calculateBTN.Name = "calculateBTN"
        Me.calculateBTN.Size = New System.Drawing.Size(210, 65)
        Me.calculateBTN.TabIndex = 2
        Me.calculateBTN.Text = "Calculate"
        Me.calculateBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "total hours:"
        '
        'total_hours_output
        '
        Me.total_hours_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_hours_output.Location = New System.Drawing.Point(301, 202)
        Me.total_hours_output.Name = "total_hours_output"
        Me.total_hours_output.Size = New System.Drawing.Size(112, 27)
        Me.total_hours_output.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "average hours per week:"
        '
        'average_hours_per_week_output
        '
        Me.average_hours_per_week_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.average_hours_per_week_output.Location = New System.Drawing.Point(301, 266)
        Me.average_hours_per_week_output.Name = "average_hours_per_week_output"
        Me.average_hours_per_week_output.Size = New System.Drawing.Size(112, 27)
        Me.average_hours_per_week_output.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.average_hours_per_week_output)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.total_hours_output)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.calculateBTN)
        Me.Controls.Add(Me.enter_nqf_credit_input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents enter_nqf_credit_input As TextBox
    Friend WithEvents calculateBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents total_hours_output As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents average_hours_per_week_output As TextBox
End Class
