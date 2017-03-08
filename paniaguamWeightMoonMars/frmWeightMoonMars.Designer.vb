<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeightMoonMars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeightMoonMars))
        Me.picMoonMars = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblStaticWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.rdoMars = New System.Windows.Forms.RadioButton()
        Me.rdoMoon = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWeight = New System.Windows.Forms.Label()
        CType(Me.picMoonMars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMoonMars
        '
        Me.picMoonMars.Image = CType(resources.GetObject("picMoonMars.Image"), System.Drawing.Image)
        Me.picMoonMars.Location = New System.Drawing.Point(65, 12)
        Me.picMoonMars.Name = "picMoonMars"
        Me.picMoonMars.Size = New System.Drawing.Size(305, 172)
        Me.picMoonMars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoonMars.TabIndex = 0
        Me.picMoonMars.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Black
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Indigo
        Me.lblHeader.Location = New System.Drawing.Point(143, 201)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(150, 26)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Moon or Mars?"
        '
        'lblStaticWeight
        '
        Me.lblStaticWeight.AutoSize = True
        Me.lblStaticWeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticWeight.ForeColor = System.Drawing.Color.White
        Me.lblStaticWeight.Location = New System.Drawing.Point(29, 244)
        Me.lblStaticWeight.Name = "lblStaticWeight"
        Me.lblStaticWeight.Size = New System.Drawing.Size(87, 19)
        Me.lblStaticWeight.TabIndex = 2
        Me.lblStaticWeight.Text = "Enter weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(133, 241)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(48, 26)
        Me.txtWeight.TabIndex = 0
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.rdoMars)
        Me.grpLocation.Controls.Add(Me.rdoMoon)
        Me.grpLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocation.ForeColor = System.Drawing.Color.White
        Me.grpLocation.Location = New System.Drawing.Point(206, 244)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(200, 100)
        Me.grpLocation.TabIndex = 4
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Convert weight"
        '
        'rdoMars
        '
        Me.rdoMars.AutoSize = True
        Me.rdoMars.Location = New System.Drawing.Point(12, 53)
        Me.rdoMars.Name = "rdoMars"
        Me.rdoMars.Size = New System.Drawing.Size(171, 23)
        Me.rdoMars.TabIndex = 1
        Me.rdoMars.Text = "Convert to Mars weight"
        Me.rdoMars.UseVisualStyleBackColor = True
        '
        'rdoMoon
        '
        Me.rdoMoon.AutoSize = True
        Me.rdoMoon.Checked = True
        Me.rdoMoon.Location = New System.Drawing.Point(12, 24)
        Me.rdoMoon.Name = "rdoMoon"
        Me.rdoMoon.Size = New System.Drawing.Size(176, 23)
        Me.rdoMoon.TabIndex = 0
        Me.rdoMoon.TabStop = True
        Me.rdoMoon.Text = "Convert to Moon weight"
        Me.rdoMoon.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Gray
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(16, 321)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Display"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(116, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.White
        Me.lblWeight.Location = New System.Drawing.Point(44, 270)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(0, 19)
        Me.lblWeight.TabIndex = 7
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWeightMoonMars
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(434, 363)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblStaticWeight)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picMoonMars)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmWeightMoonMars"
        Me.Text = "How much would you weigh on the Moon or Mars?"
        CType(Me.picMoonMars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMoonMars As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblStaticWeight As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents rdoMars As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMoon As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblWeight As System.Windows.Forms.Label

End Class
