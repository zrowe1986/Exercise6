<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblLength = New Label()
        lblWidth = New Label()
        txtLength = New TextBox()
        txtWidth = New TextBox()
        txtHeight = New TextBox()
        lblHeight = New Label()
        txtOpenings = New TextBox()
        lblOpenings = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblArea = New Label()
        lblGallons = New Label()
        Label1 = New Label()
        txtArea = New TextBox()
        txtGallons = New TextBox()
        txtBuy = New TextBox()
        SuspendLayout()
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLength.Location = New Point(27, 25)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(103, 15)
        lblLength.TabIndex = 0
        lblLength.Text = "Room Length (ft)"
        ' 
        ' lblWidth
        ' 
        lblWidth.AutoSize = True
        lblWidth.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWidth.Location = New Point(27, 64)
        lblWidth.Name = "lblWidth"
        lblWidth.Size = New Size(98, 15)
        lblWidth.TabIndex = 1
        lblWidth.Text = "Room Width (ft)"
        ' 
        ' txtLength
        ' 
        txtLength.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        txtLength.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLength.Location = New Point(194, 17)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(100, 23)
        txtLength.TabIndex = 2
        ' 
        ' txtWidth
        ' 
        txtWidth.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        txtWidth.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWidth.Location = New Point(194, 56)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(100, 23)
        txtWidth.TabIndex = 3
        ' 
        ' txtHeight
        ' 
        txtHeight.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        txtHeight.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHeight.Location = New Point(194, 100)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(100, 23)
        txtHeight.TabIndex = 5
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeight.Location = New Point(27, 108)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(93, 15)
        lblHeight.TabIndex = 4
        lblHeight.Text = "Wall Height (ft)"
        ' 
        ' txtOpenings
        ' 
        txtOpenings.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        txtOpenings.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOpenings.Location = New Point(194, 141)
        txtOpenings.Name = "txtOpenings"
        txtOpenings.Size = New Size(100, 23)
        txtOpenings.TabIndex = 7
        ' 
        ' lblOpenings
        ' 
        lblOpenings.AutoSize = True
        lblOpenings.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOpenings.Location = New Point(27, 149)
        lblOpenings.Name = "lblOpenings"
        lblOpenings.Size = New Size(153, 15)
        lblOpenings.TabIndex = 6
        lblOpenings.Text = "Doors and Windows (sq ft)"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(27, 199)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(116, 43)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(178, 199)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(116, 43)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(333, 199)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(116, 43)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblArea
        ' 
        lblArea.AutoSize = True
        lblArea.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArea.Location = New Point(27, 296)
        lblArea.Name = "lblArea"
        lblArea.Size = New Size(87, 15)
        lblArea.TabIndex = 11
        lblArea.Text = "Paintable Area"
        ' 
        ' lblGallons
        ' 
        lblGallons.AutoSize = True
        lblGallons.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGallons.Location = New Point(27, 335)
        lblGallons.Name = "lblGallons"
        lblGallons.Size = New Size(94, 15)
        lblGallons.TabIndex = 12
        lblGallons.Text = "Gallons Needed"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 373)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 13
        Label1.Text = "Gallons To Buy"
        ' 
        ' txtArea
        ' 
        txtArea.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        txtArea.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtArea.ForeColor = SystemColors.Window
        txtArea.Location = New Point(194, 288)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(100, 23)
        txtArea.TabIndex = 14
        ' 
        ' txtGallons
        ' 
        txtGallons.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        txtGallons.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGallons.ForeColor = SystemColors.Window
        txtGallons.Location = New Point(194, 327)
        txtGallons.Name = "txtGallons"
        txtGallons.Size = New Size(100, 23)
        txtGallons.TabIndex = 15
        ' 
        ' txtBuy
        ' 
        txtBuy.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        txtBuy.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuy.ForeColor = SystemColors.Window
        txtBuy.Location = New Point(194, 365)
        txtBuy.Name = "txtBuy"
        txtBuy.Size = New Size(100, 23)
        txtBuy.TabIndex = 16
        ' 
        ' Exercise6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(txtBuy)
        Controls.Add(txtGallons)
        Controls.Add(txtArea)
        Controls.Add(Label1)
        Controls.Add(lblGallons)
        Controls.Add(lblArea)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtOpenings)
        Controls.Add(lblOpenings)
        Controls.Add(txtHeight)
        Controls.Add(lblHeight)
        Controls.Add(txtWidth)
        Controls.Add(txtLength)
        Controls.Add(lblWidth)
        Controls.Add(lblLength)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Exercise6"
        Text = "Paint Estimator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtOpenings As TextBox
    Friend WithEvents lblOpenings As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblArea As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtBuy As TextBox

End Class