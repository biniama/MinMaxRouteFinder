<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouteFinder
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtDestinationPlace = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileSelected = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(270, 156)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(47, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtDestinationPlace
        '
        Me.txtDestinationPlace.Location = New System.Drawing.Point(37, 156)
        Me.txtDestinationPlace.Name = "txtDestinationPlace"
        Me.txtDestinationPlace.Size = New System.Drawing.Size(199, 20)
        Me.txtDestinationPlace.TabIndex = 1
        Me.txtDestinationPlace.Text = "Saris"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter the destination place you want to go to:"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBrowse.Location = New System.Drawing.Point(474, 69)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 23)
        Me.btnBrowse.TabIndex = 22
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Please Select the location of the file:"
        '
        'txtFileSelected
        '
        Me.txtFileSelected.Location = New System.Drawing.Point(36, 72)
        Me.txtFileSelected.Name = "txtFileSelected"
        Me.txtFileSelected.ReadOnly = True
        Me.txtFileSelected.Size = New System.Drawing.Size(407, 20)
        Me.txtFileSelected.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRouteFinder
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 209)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFileSelected)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDestinationPlace)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmRouteFinder"
        Me.Text = "Route Finder Using Min-Max Algorithm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtDestinationPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileSelected As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
