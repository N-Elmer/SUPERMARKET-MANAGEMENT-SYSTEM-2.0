<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form8
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
	Public WithEvents Adodc1 As VB6.ADODC
	Public WithEvents Command10 As System.Windows.Forms.Button
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Command7 As System.Windows.Forms.Button
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents ProgressBar1 As AxComctlLib.AxProgressBar
	Public WithEvents Calendar1 As AxMSACAL.AxCalendar
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form8))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command29 = New System.Windows.Forms.Button
		Me.Adodc1 = New VB6.ADODC
		Me.Command10 = New System.Windows.Forms.Button
		Me.Command9 = New System.Windows.Forms.Button
		Me.Command8 = New System.Windows.Forms.Button
		Me.Command7 = New System.Windows.Forms.Button
		Me.Command6 = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.ProgressBar1 = New AxComctlLib.AxProgressBar
		Me.Calendar1 = New AxMSACAL.AxCalendar
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Image2 = New System.Windows.Forms.PictureBox
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
		Me.Text = "CUSTOMMER"
		Me.ClientSize = New System.Drawing.Size(718, 479)
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
		Me.Name = "Form8"
		Me.Command29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command29.BackColor = System.Drawing.Color.Red
		Me.Command29.Text = "CLOSE"
		Me.Command29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command29.Size = New System.Drawing.Size(105, 33)
		Me.Command29.Location = New System.Drawing.Point(608, 432)
		Me.Command29.TabIndex = 26
		Me.Command29.Visible = False
		Me.Command29.CausesValidation = True
		Me.Command29.Enabled = True
		Me.Command29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command29.TabStop = True
		Me.Command29.Name = "Command29"
		Me.Adodc1.Size = New System.Drawing.Size(80, 22)
		Me.Adodc1.Location = New System.Drawing.Point(352, 232)
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
		Me.Adodc1.RecordSource = "CUSTOMMER"
		Me.Adodc1.Text = "Adodc1"
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DATA BASE1.mdb;Persist Security Info=False"
		Me.Adodc1.Name = "Adodc1"
		Me.Command10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command10.BackColor = System.Drawing.Color.Cyan
		Me.Command10.Text = "+"
		Me.Command10.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command10.Size = New System.Drawing.Size(41, 25)
		Me.Command10.Location = New System.Drawing.Point(504, 320)
		Me.Command10.TabIndex = 23
		Me.Command10.Visible = False
		Me.Command10.CausesValidation = True
		Me.Command10.Enabled = True
		Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command10.TabStop = True
		Me.Command10.Name = "Command10"
		Me.Command9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command9.BackColor = System.Drawing.Color.Cyan
		Me.Command9.Text = ">"
		Me.Command9.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9.Size = New System.Drawing.Size(33, 25)
		Me.Command9.Location = New System.Drawing.Point(544, 320)
		Me.Command9.TabIndex = 22
		Me.Command9.CausesValidation = True
		Me.Command9.Enabled = True
		Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command9.TabStop = True
		Me.Command9.Name = "Command9"
		Me.Command8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command8.BackColor = System.Drawing.Color.Cyan
		Me.Command8.Text = "<"
		Me.Command8.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command8.Size = New System.Drawing.Size(33, 25)
		Me.Command8.Location = New System.Drawing.Point(472, 320)
		Me.Command8.TabIndex = 21
		Me.Command8.CausesValidation = True
		Me.Command8.Enabled = True
		Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command8.TabStop = True
		Me.Command8.Name = "Command8"
		Me.Command7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command7.BackColor = System.Drawing.Color.Cyan
		Me.Command7.Text = "|>"
		Me.Command7.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command7.Size = New System.Drawing.Size(33, 25)
		Me.Command7.Location = New System.Drawing.Point(576, 320)
		Me.Command7.TabIndex = 20
		Me.Command7.CausesValidation = True
		Me.Command7.Enabled = True
		Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command7.TabStop = True
		Me.Command7.Name = "Command7"
		Me.Command6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command6.BackColor = System.Drawing.Color.Cyan
		Me.Command6.Text = "<|"
		Me.Command6.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command6.Size = New System.Drawing.Size(33, 25)
		Me.Command6.Location = New System.Drawing.Point(440, 320)
		Me.Command6.TabIndex = 19
		Me.Command6.CausesValidation = True
		Me.Command6.Enabled = True
		Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command6.TabStop = True
		Me.Command6.Name = "Command6"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.Text3.AutoSize = False
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.Size = New System.Drawing.Size(105, 33)
		Me.Text3.Location = New System.Drawing.Point(504, 352)
		Me.Text3.TabIndex = 15
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
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.BackColor = System.Drawing.Color.Cyan
		Me.Command5.Text = "SEARCH A NAME"
		Me.Command5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.Size = New System.Drawing.Size(105, 33)
		Me.Command5.Location = New System.Drawing.Point(608, 352)
		Me.Command5.TabIndex = 14
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
		Me.Command4.Location = New System.Drawing.Point(608, 312)
		Me.Command4.TabIndex = 13
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
		Me.Command3.Location = New System.Drawing.Point(608, 272)
		Me.Command3.TabIndex = 12
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
		Me.Command2.Location = New System.Drawing.Point(608, 232)
		Me.Command2.TabIndex = 11
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
		Me.Command1.Location = New System.Drawing.Point(608, 192)
		Me.Command1.TabIndex = 10
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame5.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame5.Size = New System.Drawing.Size(209, 49)
		Me.Frame5.Location = New System.Drawing.Point(224, 168)
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
		Me.Text2.TabIndex = 8
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
		Me.Frame4.Location = New System.Drawing.Point(8, 168)
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
		Me.Label2.Text = "CUSTOMMER_NAME"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label2.Size = New System.Drawing.Size(209, 33)
		Me.Label2.Location = New System.Drawing.Point(0, 8)
		Me.Label2.TabIndex = 6
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
		Me.Text1.TabIndex = 7
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
		Me.Label1.Text = "CUSTOMMER_NUM"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label1.Size = New System.Drawing.Size(209, 33)
		Me.Label1.Location = New System.Drawing.Point(0, 8)
		Me.Label1.TabIndex = 5
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame1.Size = New System.Drawing.Size(433, 73)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.BackColor = System.Drawing.Color.Cyan
		Me.Label3.Text = "CUSTOMMER"
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label3.Size = New System.Drawing.Size(433, 41)
		Me.Label3.Location = New System.Drawing.Point(0, 16)
		Me.Label3.TabIndex = 9
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DataGrid1.Size = New System.Drawing.Size(425, 209)
		Me.DataGrid1.Location = New System.Drawing.Point(8, 256)
		Me.DataGrid1.TabIndex = 24
		Me.DataGrid1.Name = "DataGrid1"
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(209, 33)
		Me.ProgressBar1.Location = New System.Drawing.Point(504, 392)
		Me.ProgressBar1.TabIndex = 25
		Me.ProgressBar1.Name = "ProgressBar1"
		Calendar1.OcxState = CType(resources.GetObject("Calendar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Calendar1.Size = New System.Drawing.Size(265, 161)
		Me.Calendar1.Location = New System.Drawing.Point(448, 8)
		Me.Calendar1.TabIndex = 18
		Me.Calendar1.Name = "Calendar1"
		Me.Image1.Size = New System.Drawing.Size(153, 121)
		Me.Image1.Location = New System.Drawing.Point(448, 192)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Image1.Name = "Image1"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.Cyan
		Me.Label5.Text = "%"
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label5.Size = New System.Drawing.Size(25, 33)
		Me.Label5.Location = New System.Drawing.Point(544, 432)
		Me.Label5.TabIndex = 17
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.Color.Cyan
		Me.Label4.Text = "0"
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label4.Size = New System.Drawing.Size(41, 33)
		Me.Label4.Location = New System.Drawing.Point(504, 432)
		Me.Label4.TabIndex = 16
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Image2.Enabled = False
		Me.Image2.Size = New System.Drawing.Size(720, 480)
		Me.Image2.Location = New System.Drawing.Point(0, 0)
		Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image2.Visible = True
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		Me.Controls.Add(Command29)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(Command10)
		Me.Controls.Add(Command9)
		Me.Controls.Add(Command8)
		Me.Controls.Add(Command7)
		Me.Controls.Add(Command6)
		Me.Controls.Add(Text3)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame5)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(Calendar1)
		Me.Controls.Add(Image1)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Image2)
		Me.Frame5.Controls.Add(Text2)
		Me.Frame4.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Text1)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label3)
		CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
		ADOBind_Adodc1.Add(Text2, "Text", "CUSTOMMER_NAME", Nothing, "Text2")
		ADOBind_Adodc1.Add(Text1, "Text", "CUSTOMMER_NUM", Nothing, "Text1")
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