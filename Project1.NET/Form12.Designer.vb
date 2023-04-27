<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form12
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Private ADOBind_Adodc1 As VB6.MBindingCollection
	Public WithEvents Command29 As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Frame13 As System.Windows.Forms.GroupBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame12 As System.Windows.Forms.GroupBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Frame11 As System.Windows.Forms.GroupBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame10 As System.Windows.Forms.GroupBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents Adodc1 As VB6.ADODC
	Public WithEvents ProgressBar1 As AxComctlLib.AxProgressBar
	Public WithEvents Calendar1 As AxMSACAL.AxCalendar
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form12))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command29 = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Text7 = New System.Windows.Forms.TextBox
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame13 = New System.Windows.Forms.GroupBox
		Me.Text6 = New System.Windows.Forms.TextBox
		Me.Frame12 = New System.Windows.Forms.GroupBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame11 = New System.Windows.Forms.GroupBox
		Me.Text5 = New System.Windows.Forms.TextBox
		Me.Frame10 = New System.Windows.Forms.GroupBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.Text4 = New System.Windows.Forms.TextBox
		Me.Frame8 = New System.Windows.Forms.GroupBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.Adodc1 = New VB6.ADODC
		Me.ProgressBar1 = New AxComctlLib.AxProgressBar
		Me.Calendar1 = New AxMSACAL.AxCalendar
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Image2 = New System.Windows.Forms.PictureBox
		Me.Frame13.SuspendLayout()
		Me.Frame12.SuspendLayout()
		Me.Frame11.SuspendLayout()
		Me.Frame10.SuspendLayout()
		Me.Frame9.SuspendLayout()
		Me.Frame8.SuspendLayout()
		Me.Frame7.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.Cyan
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "STOCK"
		Me.ClientSize = New System.Drawing.Size(1054, 479)
		Me.Location = New System.Drawing.Point(3, 26)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form12"
		Me.Command29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command29.BackColor = System.Drawing.Color.Red
		Me.Command29.Text = "CLOSE"
		Me.Command29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command29.Size = New System.Drawing.Size(105, 33)
		Me.Command29.Location = New System.Drawing.Point(504, 136)
		Me.Command29.TabIndex = 37
		Me.Command29.Visible = False
		Me.Command29.CausesValidation = True
		Me.Command29.Enabled = True
		Me.Command29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command29.TabStop = True
		Me.Command29.Name = "Command29"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.Text7.AutoSize = False
		Me.Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text7.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text7.Size = New System.Drawing.Size(105, 33)
		Me.Text7.Location = New System.Drawing.Point(608, 184)
		Me.Text7.TabIndex = 31
		Me.Text7.AcceptsReturn = True
		Me.Text7.BackColor = System.Drawing.SystemColors.Window
		Me.Text7.CausesValidation = True
		Me.Text7.Enabled = True
		Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text7.HideSelection = True
		Me.Text7.ReadOnly = False
		Me.Text7.Maxlength = 0
		Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text7.MultiLine = False
		Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text7.TabStop = True
		Me.Text7.Visible = True
		Me.Text7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text7.Name = "Text7"
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.BackColor = System.Drawing.Color.Cyan
		Me.Command5.Text = "SEARCH A NAME"
		Me.Command5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.Size = New System.Drawing.Size(105, 33)
		Me.Command5.Location = New System.Drawing.Point(504, 184)
		Me.Command5.TabIndex = 30
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.BackColor = System.Drawing.Color.Cyan
		Me.Command4.Text = "SAVE"
		Me.Command4.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.Size = New System.Drawing.Size(105, 33)
		Me.Command4.Location = New System.Drawing.Point(816, 224)
		Me.Command4.TabIndex = 29
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.BackColor = System.Drawing.Color.Cyan
		Me.Command3.Text = "DELETE"
		Me.Command3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.Size = New System.Drawing.Size(105, 33)
		Me.Command3.Location = New System.Drawing.Point(712, 224)
		Me.Command3.TabIndex = 28
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.BackColor = System.Drawing.Color.Cyan
		Me.Command2.Text = "MODIFY"
		Me.Command2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.Size = New System.Drawing.Size(105, 33)
		Me.Command2.Location = New System.Drawing.Point(608, 224)
		Me.Command2.TabIndex = 27
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.BackColor = System.Drawing.Color.Cyan
		Me.Command1.Text = "ADD"
		Me.Command1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(105, 33)
		Me.Command1.Location = New System.Drawing.Point(504, 224)
		Me.Command1.TabIndex = 26
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame13.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame13.Size = New System.Drawing.Size(209, 49)
		Me.Frame13.Location = New System.Drawing.Point(224, 416)
		Me.Frame13.TabIndex = 12
		Me.Frame13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame13.Enabled = True
		Me.Frame13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame13.Visible = True
		Me.Frame13.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame13.Name = "Frame13"
		Me.Text6.AutoSize = False
		Me.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text6.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text6.Size = New System.Drawing.Size(209, 33)
		Me.Text6.Location = New System.Drawing.Point(0, 8)
		Me.Text6.TabIndex = 24
		Me.Text6.AcceptsReturn = True
		Me.Text6.BackColor = System.Drawing.SystemColors.Window
		Me.Text6.CausesValidation = True
		Me.Text6.Enabled = True
		Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text6.HideSelection = True
		Me.Text6.ReadOnly = False
		Me.Text6.Maxlength = 0
		Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text6.MultiLine = False
		Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text6.TabStop = True
		Me.Text6.Visible = True
		Me.Text6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text6.Name = "Text6"
		Me.Frame12.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame12.Size = New System.Drawing.Size(209, 49)
		Me.Frame12.Location = New System.Drawing.Point(8, 416)
		Me.Frame12.TabIndex = 11
		Me.Frame12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame12.Enabled = True
		Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame12.Visible = True
		Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame12.Name = "Frame12"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label6.BackColor = System.Drawing.Color.Cyan
		Me.Label6.Text = "REMARK"
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label6.Size = New System.Drawing.Size(209, 33)
		Me.Label6.Location = New System.Drawing.Point(0, 8)
		Me.Label6.TabIndex = 18
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Frame11.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame11.Size = New System.Drawing.Size(209, 49)
		Me.Frame11.Location = New System.Drawing.Point(224, 352)
		Me.Frame11.TabIndex = 10
		Me.Frame11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame11.Enabled = True
		Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame11.Visible = True
		Me.Frame11.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame11.Name = "Frame11"
		Me.Text5.AutoSize = False
		Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text5.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text5.Size = New System.Drawing.Size(209, 33)
		Me.Text5.Location = New System.Drawing.Point(0, 8)
		Me.Text5.TabIndex = 23
		Me.Text5.AcceptsReturn = True
		Me.Text5.BackColor = System.Drawing.SystemColors.Window
		Me.Text5.CausesValidation = True
		Me.Text5.Enabled = True
		Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text5.HideSelection = True
		Me.Text5.ReadOnly = False
		Me.Text5.Maxlength = 0
		Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text5.MultiLine = False
		Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text5.TabStop = True
		Me.Text5.Visible = True
		Me.Text5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text5.Name = "Text5"
		Me.Frame10.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame10.Size = New System.Drawing.Size(209, 49)
		Me.Frame10.Location = New System.Drawing.Point(8, 352)
		Me.Frame10.TabIndex = 9
		Me.Frame10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame10.Enabled = True
		Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame10.Visible = True
		Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame10.Name = "Frame10"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.Cyan
		Me.Label5.Text = "STOCK_DATE"
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label5.Size = New System.Drawing.Size(209, 33)
		Me.Label5.Location = New System.Drawing.Point(0, 8)
		Me.Label5.TabIndex = 17
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Frame9.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame9.Size = New System.Drawing.Size(209, 49)
		Me.Frame9.Location = New System.Drawing.Point(224, 288)
		Me.Frame9.TabIndex = 8
		Me.Frame9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.Text4.AutoSize = False
		Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text4.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text4.Size = New System.Drawing.Size(209, 33)
		Me.Text4.Location = New System.Drawing.Point(0, 8)
		Me.Text4.TabIndex = 22
		Me.Text4.AcceptsReturn = True
		Me.Text4.BackColor = System.Drawing.SystemColors.Window
		Me.Text4.CausesValidation = True
		Me.Text4.Enabled = True
		Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text4.HideSelection = True
		Me.Text4.ReadOnly = False
		Me.Text4.Maxlength = 0
		Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text4.MultiLine = False
		Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text4.TabStop = True
		Me.Text4.Visible = True
		Me.Text4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text4.Name = "Text4"
		Me.Frame8.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame8.Size = New System.Drawing.Size(209, 49)
		Me.Frame8.Location = New System.Drawing.Point(8, 288)
		Me.Frame8.TabIndex = 7
		Me.Frame8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame8.Enabled = True
		Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame8.Visible = True
		Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame8.Name = "Frame8"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.Color.Cyan
		Me.Label4.Text = "STOCK_TIME"
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label4.Size = New System.Drawing.Size(209, 33)
		Me.Label4.Location = New System.Drawing.Point(0, 8)
		Me.Label4.TabIndex = 16
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Frame7.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame7.Size = New System.Drawing.Size(209, 49)
		Me.Frame7.Location = New System.Drawing.Point(224, 224)
		Me.Frame7.TabIndex = 6
		Me.Frame7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame7.Visible = True
		Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame7.Name = "Frame7"
		Me.Text3.AutoSize = False
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.Size = New System.Drawing.Size(209, 33)
		Me.Text3.Location = New System.Drawing.Point(0, 8)
		Me.Text3.TabIndex = 21
		Me.Text3.AcceptsReturn = True
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.Visible = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text3.Name = "Text3"
		Me.Frame6.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame6.Size = New System.Drawing.Size(209, 49)
		Me.Frame6.Location = New System.Drawing.Point(8, 224)
		Me.Frame6.TabIndex = 5
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.BackColor = System.Drawing.Color.Cyan
		Me.Label3.Text = "STOCK_QUANTITY"
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label3.Size = New System.Drawing.Size(209, 33)
		Me.Label3.Location = New System.Drawing.Point(0, 8)
		Me.Label3.TabIndex = 15
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Frame5.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame5.Size = New System.Drawing.Size(209, 49)
		Me.Frame5.Location = New System.Drawing.Point(224, 160)
		Me.Frame5.TabIndex = 4
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.Text2.AutoSize = False
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.Size = New System.Drawing.Size(209, 33)
		Me.Text2.Location = New System.Drawing.Point(0, 8)
		Me.Text2.TabIndex = 20
		Me.Text2.AcceptsReturn = True
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame4.Size = New System.Drawing.Size(209, 49)
		Me.Frame4.Location = New System.Drawing.Point(8, 160)
		Me.Frame4.TabIndex = 3
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.BackColor = System.Drawing.Color.Cyan
		Me.Label2.Text = "STOCK_NAME"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label2.Size = New System.Drawing.Size(209, 33)
		Me.Label2.Location = New System.Drawing.Point(0, 8)
		Me.Label2.TabIndex = 14
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame3.Size = New System.Drawing.Size(209, 49)
		Me.Frame3.Location = New System.Drawing.Point(224, 96)
		Me.Frame3.TabIndex = 2
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Text1.AutoSize = False
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.Size = New System.Drawing.Size(209, 33)
		Me.Text1.Location = New System.Drawing.Point(0, 8)
		Me.Text1.TabIndex = 19
		Me.Text1.AcceptsReturn = True
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame2.Size = New System.Drawing.Size(209, 49)
		Me.Frame2.Location = New System.Drawing.Point(8, 96)
		Me.Frame2.TabIndex = 1
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.BackColor = System.Drawing.Color.Cyan
		Me.Label1.Text = "STOCK_NUM"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label1.Size = New System.Drawing.Size(209, 33)
		Me.Label1.Location = New System.Drawing.Point(0, 8)
		Me.Label1.TabIndex = 13
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame1.Size = New System.Drawing.Size(497, 73)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.BackColor = System.Drawing.Color.Cyan
		Me.Label7.Text = "STOCK"
		Me.Label7.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label7.Size = New System.Drawing.Size(497, 41)
		Me.Label7.Location = New System.Drawing.Point(0, 16)
		Me.Label7.TabIndex = 25
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DataGrid1.Size = New System.Drawing.Size(537, 201)
		Me.DataGrid1.Location = New System.Drawing.Point(504, 264)
		Me.DataGrid1.TabIndex = 36
		Me.DataGrid1.Name = "DataGrid1"
		Me.Adodc1.Size = New System.Drawing.Size(81, 22)
		Me.Adodc1.Location = New System.Drawing.Point(960, 240)
		Me.Adodc1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdTable
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = System.Drawing.SystemColors.Window
		Me.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Adodc1.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.Adodc1.Enabled = True
		Me.Adodc1.UserName = ""
		Me.Adodc1.RecordSource = "STOCK"
		Me.Adodc1.Text = "Adodc2"
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DATA BASE1.mdb;Persist Security Info=False"
		Me.Adodc1.Name = "Adodc1"
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(193, 33)
		Me.ProgressBar1.Location = New System.Drawing.Point(720, 184)
		Me.ProgressBar1.TabIndex = 33
		Me.ProgressBar1.Name = "ProgressBar1"
		Calendar1.OcxState = CType(resources.GetObject("Calendar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Calendar1.Size = New System.Drawing.Size(321, 161)
		Me.Calendar1.Location = New System.Drawing.Point(720, 8)
		Me.Calendar1.TabIndex = 35
		Me.Calendar1.Name = "Calendar1"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label9.BackColor = System.Drawing.Color.Cyan
		Me.Label9.Text = "%"
		Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label9.Size = New System.Drawing.Size(25, 33)
		Me.Label9.Location = New System.Drawing.Point(960, 184)
		Me.Label9.TabIndex = 32
		Me.Label9.Enabled = True
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.BackColor = System.Drawing.Color.Cyan
		Me.Label8.Text = "0"
		Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label8.Size = New System.Drawing.Size(41, 33)
		Me.Label8.Location = New System.Drawing.Point(920, 184)
		Me.Label8.TabIndex = 34
		Me.Label8.Enabled = True
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Image1.Size = New System.Drawing.Size(854, 480)
		Me.Image1.Location = New System.Drawing.Point(536, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Image2.Size = New System.Drawing.Size(754, 480)
		Me.Image2.Location = New System.Drawing.Point(0, 0)
		Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
		Me.Image2.Enabled = True
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image2.Visible = True
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		Me.Controls.Add(Command29)
		Me.Controls.Add(Text7)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame13)
		Me.Controls.Add(Frame12)
		Me.Controls.Add(Frame11)
		Me.Controls.Add(Frame10)
		Me.Controls.Add(Frame9)
		Me.Controls.Add(Frame8)
		Me.Controls.Add(Frame7)
		Me.Controls.Add(Frame6)
		Me.Controls.Add(Frame5)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(Calendar1)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Image1)
		Me.Controls.Add(Image2)
		Me.Frame13.Controls.Add(Text6)
		Me.Frame12.Controls.Add(Label6)
		Me.Frame11.Controls.Add(Text5)
		Me.Frame10.Controls.Add(Label5)
		Me.Frame9.Controls.Add(Text4)
		Me.Frame8.Controls.Add(Label4)
		Me.Frame7.Controls.Add(Text3)
		Me.Frame6.Controls.Add(Label3)
		Me.Frame5.Controls.Add(Text2)
		Me.Frame4.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Text1)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label7)
		CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame13.ResumeLayout(False)
		Me.Frame12.ResumeLayout(False)
		Me.Frame11.ResumeLayout(False)
		Me.Frame10.ResumeLayout(False)
		Me.Frame9.ResumeLayout(False)
		Me.Frame8.ResumeLayout(False)
		Me.Frame7.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		ADOBind_Adodc1 = New VB6.MBindingCollection()
		ADOBind_Adodc1.DataSource = CType(Adodc1, MSDATASRC.DataSource)
		ADOBind_Adodc1.Add(Text6, "Text", "REMARK", Nothing, "Text6")
		ADOBind_Adodc1.Add(Text5, "Text", "STOCK_DATE", Nothing, "Text5")
		ADOBind_Adodc1.Add(Text4, "Text", "STOCK_TIME", Nothing, "Text4")
		ADOBind_Adodc1.Add(Text3, "Text", "STOCK_QUANTITY", Nothing, "Text3")
		ADOBind_Adodc1.Add(Text2, "Text", "STOCK_NAME", Nothing, "Text2")
		ADOBind_Adodc1.Add(Text1, "Text", "STOCK_NUM", Nothing, "Text1")
		DataGrid1.DataSource = CType(Adodc1, MSDATASRC.DataSource)
		ADOBind_Adodc1.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_Adodc1.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_Adodc1.Clear()
		ADOBind_Adodc1.Dispose()
		ADOBind_Adodc1 = Nothing
		DataGrid1.DataSource = Nothing
	End Sub
#End Region 
End Class