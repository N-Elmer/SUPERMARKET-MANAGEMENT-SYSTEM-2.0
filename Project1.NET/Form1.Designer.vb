<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Private ADOBind_Adodc2 As VB6.MBindingCollection
	Public WithEvents VOIR_INSTRUCTIONS As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CACHER_INSTRUCTIONS As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Adodc2 As VB6.ADODC
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Adodc1 As VB6.ADODC
	Public WithEvents Command29 As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents ProgressBar1 As AxComctlLib.AxProgressBar
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.VOIR_INSTRUCTIONS = New System.Windows.Forms.ToolStripMenuItem
		Me.CACHER_INSTRUCTIONS = New System.Windows.Forms.ToolStripMenuItem
		Me.Adodc2 = New VB6.ADODC
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Adodc1 = New VB6.ADODC
		Me.Command29 = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.Option2 = New System.Windows.Forms.RadioButton
		Me.Option1 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Text6 = New System.Windows.Forms.TextBox
		Me.Text5 = New System.Windows.Forms.TextBox
		Me.Text4 = New System.Windows.Forms.TextBox
		Me.ProgressBar1 = New AxComctlLib.AxProgressBar
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.MainMenu1.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.Cyan
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "PAGE D'ACCUEIL"
		Me.ClientSize = New System.Drawing.Size(718, 495)
		Me.Location = New System.Drawing.Point(10, 53)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("Form1.BackgroundImage"), System.Drawing.Image)
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
		Me.Name = "Form1"
		Me.VOIR_INSTRUCTIONS.Name = "VOIR_INSTRUCTIONS"
		Me.VOIR_INSTRUCTIONS.Text = "VOIR_INSTRUCTIONS"
		Me.VOIR_INSTRUCTIONS.Checked = False
		Me.VOIR_INSTRUCTIONS.Enabled = True
		Me.VOIR_INSTRUCTIONS.Visible = True
		Me.CACHER_INSTRUCTIONS.Name = "CACHER_INSTRUCTIONS"
		Me.CACHER_INSTRUCTIONS.Text = "CACHER_INSTRUCTIONS"
		Me.CACHER_INSTRUCTIONS.Checked = False
		Me.CACHER_INSTRUCTIONS.Enabled = True
		Me.CACHER_INSTRUCTIONS.Visible = True
		Me.Adodc2.Size = New System.Drawing.Size(80, 22)
		Me.Adodc2.Location = New System.Drawing.Point(624, 440)
		Me.Adodc2.Visible = 0
		Me.Adodc2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.Adodc2.ConnectionTimeout = 15
		Me.Adodc2.CommandTimeout = 30
		Me.Adodc2.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.Adodc2.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc2.CommandType = ADODB.CommandTypeEnum.adCmdTable
		Me.Adodc2.CacheSize = 50
		Me.Adodc2.MaxRecords = 0
		Me.Adodc2.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.Adodc2.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.Adodc2.BackColor = System.Drawing.SystemColors.Window
		Me.Adodc2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Adodc2.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.Adodc2.Enabled = True
		Me.Adodc2.UserName = ""
		Me.Adodc2.RecordSource = "DONNEESUTILISATEUR"
		Me.Adodc2.Text = "Adodc2"
		Me.Adodc2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
		Me.Adodc2.Name = "Adodc2"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.BackColor = System.Drawing.SystemColors.Highlight
		Me.Command3.Text = "SAVEGARDER"
		Me.Command3.Enabled = False
		Me.Command3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.Size = New System.Drawing.Size(161, 25)
		Me.Command3.Location = New System.Drawing.Point(16, 400)
		Me.Command3.TabIndex = 27
		Me.Command3.CausesValidation = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.BackColor = System.Drawing.SystemColors.Highlight
		Me.Command2.Text = "OK"
		Me.Command2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.Size = New System.Drawing.Size(161, 25)
		Me.Command2.Location = New System.Drawing.Point(16, 312)
		Me.Command2.TabIndex = 23
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Adodc1.Size = New System.Drawing.Size(80, 22)
		Me.Adodc1.Location = New System.Drawing.Point(624, 416)
		Me.Adodc1.Visible = 0
		Me.Adodc1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdText
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = System.Drawing.SystemColors.Window
		Me.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Adodc1.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.Adodc1.Enabled = True
		Me.Adodc1.UserName = ""
		Me.Adodc1.RecordSource = "select * from text1"
		Me.Adodc1.Text = "Adodc1"
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
		Me.Adodc1.Name = "Adodc1"
		Me.Command29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command29.BackColor = System.Drawing.Color.Red
		Me.Command29.Text = "FERMER"
		Me.Command29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command29.Size = New System.Drawing.Size(105, 41)
		Me.Command29.Location = New System.Drawing.Point(272, 448)
		Me.Command29.TabIndex = 18
		Me.Command29.CausesValidation = True
		Me.Command29.Enabled = True
		Me.Command29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command29.TabStop = True
		Me.Command29.Name = "Command29"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.Frame6.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame6.Size = New System.Drawing.Size(57, 33)
		Me.Frame6.Location = New System.Drawing.Point(312, 232)
		Me.Frame6.TabIndex = 15
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label6.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Label6.Text = "%"
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label6.Size = New System.Drawing.Size(25, 33)
		Me.Label6.Location = New System.Drawing.Point(32, 8)
		Me.Label6.TabIndex = 17
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Label5.Text = "0"
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label5.Size = New System.Drawing.Size(57, 33)
		Me.Label5.Location = New System.Drawing.Point(-8, 8)
		Me.Label5.TabIndex = 16
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Frame5.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame5.Size = New System.Drawing.Size(249, 25)
		Me.Frame5.Location = New System.Drawing.Point(464, 464)
		Me.Frame5.TabIndex = 13
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.Text3.AutoSize = False
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text3.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Text3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Text3.Size = New System.Drawing.Size(249, 25)
		Me.Text3.Location = New System.Drawing.Point(0, 0)
		Me.Text3.TabIndex = 14
		Me.Text3.Text = "NOUS PRENONS SOINS DE VOTRE  FUTURE"
		Me.Text3.AcceptsReturn = True
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
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
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame4.Text = "LANGUE / LANGUAGE"
		Me.Frame4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Frame4.Size = New System.Drawing.Size(257, 49)
		Me.Frame4.Location = New System.Drawing.Point(8, 440)
		Me.Frame4.TabIndex = 10
		Me.Frame4.Enabled = True
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.Option2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.BackColor = System.Drawing.Color.FromARGB(128, 255, 255)
		Me.Option2.Text = "FRANCAIS"
		Me.Option2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Option2.Size = New System.Drawing.Size(97, 25)
		Me.Option2.Location = New System.Drawing.Point(136, 16)
		Me.Option2.TabIndex = 12
		Me.Option2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.CausesValidation = True
		Me.Option2.Enabled = True
		Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option2.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option2.TabStop = True
		Me.Option2.Checked = False
		Me.Option2.Visible = True
		Me.Option2.Name = "Option2"
		Me.Option1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.BackColor = System.Drawing.Color.FromARGB(128, 255, 255)
		Me.Option1.Text = "ENGLISH"
		Me.Option1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Option1.Size = New System.Drawing.Size(97, 25)
		Me.Option1.Location = New System.Drawing.Point(16, 16)
		Me.Option1.TabIndex = 11
		Me.Option1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.CausesValidation = True
		Me.Option1.Enabled = True
		Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option1.TabStop = True
		Me.Option1.Checked = False
		Me.Option1.Visible = True
		Me.Option1.Name = "Option1"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame3.Size = New System.Drawing.Size(705, 81)
		Me.Frame3.Location = New System.Drawing.Point(8, 32)
		Me.Frame3.TabIndex = 8
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label4.Text = "BIEN VENU DANS GENI CALCUL"
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label4.Size = New System.Drawing.Size(441, 41)
		Me.Label4.Location = New System.Drawing.Point(128, 24)
		Me.Label4.TabIndex = 9
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.BackColor = System.Drawing.SystemColors.Highlight
		Me.Command1.Text = "LOGIN"
		Me.Command1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(161, 25)
		Me.Command1.Location = New System.Drawing.Point(16, 240)
		Me.Command1.TabIndex = 7
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame2.Size = New System.Drawing.Size(361, 57)
		Me.Frame2.Location = New System.Drawing.Point(8, 120)
		Me.Frame2.TabIndex = 4
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label3.Text = "ACCUEIL"
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label3.Size = New System.Drawing.Size(305, 33)
		Me.Label3.Location = New System.Drawing.Point(24, 16)
		Me.Label3.TabIndex = 6
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Frame1.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Frame1.Size = New System.Drawing.Size(361, 257)
		Me.Frame1.Location = New System.Drawing.Point(8, 176)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Text6.AutoSize = False
		Me.Text6.Enabled = False
		Me.Text6.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text6.Size = New System.Drawing.Size(137, 25)
		Me.Text6.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.Text6.Location = New System.Drawing.Point(168, 200)
		Me.Text6.PasswordChar = ChrW(42)
		Me.Text6.TabIndex = 22
		Me.Text6.AcceptsReturn = True
		Me.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text6.BackColor = System.Drawing.SystemColors.Window
		Me.Text6.CausesValidation = True
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
		Me.Text5.AutoSize = False
		Me.Text5.Enabled = False
		Me.Text5.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text5.Size = New System.Drawing.Size(137, 25)
		Me.Text5.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.Text5.Location = New System.Drawing.Point(168, 176)
		Me.Text5.PasswordChar = ChrW(42)
		Me.Text5.TabIndex = 21
		Me.Text5.AcceptsReturn = True
		Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text5.BackColor = System.Drawing.SystemColors.Window
		Me.Text5.CausesValidation = True
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
		Me.Text4.AutoSize = False
		Me.Text4.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text4.Size = New System.Drawing.Size(137, 25)
		Me.Text4.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.Text4.Location = New System.Drawing.Point(168, 112)
		Me.Text4.PasswordChar = ChrW(42)
		Me.Text4.TabIndex = 20
		Me.Text4.AcceptsReturn = True
		Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(137, 25)
		Me.ProgressBar1.Location = New System.Drawing.Point(168, 64)
		Me.ProgressBar1.TabIndex = 19
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.Text2.AutoSize = False
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.Size = New System.Drawing.Size(137, 25)
		Me.Text2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.Text2.Location = New System.Drawing.Point(168, 40)
		Me.Text2.PasswordChar = ChrW(42)
		Me.Text2.TabIndex = 5
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
		Me.Text1.AutoSize = False
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Text1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.Size = New System.Drawing.Size(137, 25)
		Me.Text1.Location = New System.Drawing.Point(168, 16)
		Me.Text1.TabIndex = 3
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
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label9.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label9.Text = "NOUVEAU MOT DE PASSE"
		Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label9.Size = New System.Drawing.Size(161, 25)
		Me.Label9.Location = New System.Drawing.Point(8, 200)
		Me.Label9.TabIndex = 26
		Me.Label9.Enabled = True
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label9.Name = "Label9"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label8.Text = "NOUVEU UTILISATEUR"
		Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label8.Size = New System.Drawing.Size(161, 25)
		Me.Label8.Location = New System.Drawing.Point(8, 176)
		Me.Label8.TabIndex = 25
		Me.Label8.Enabled = True
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label8.Name = "Label8"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label7.Text = "CLE "
		Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label7.Size = New System.Drawing.Size(161, 25)
		Me.Label7.Location = New System.Drawing.Point(8, 112)
		Me.Label7.TabIndex = 24
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label7.Name = "Label7"
		Me.Line1.BorderColor = System.Drawing.Color.White
		Me.Line1.BorderWidth = 2
		Me.Line1.X1 = 0
		Me.Line1.X2 = 360
		Me.Line1.Y1 = 99
		Me.Line1.Y2 = 99
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label2.Text = "MOT DE PASSE"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label2.Size = New System.Drawing.Size(161, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 40)
		Me.Label2.TabIndex = 2
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Name = "Label2"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label1.Text = "NOM UTILISATEUR"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.Label1.Size = New System.Drawing.Size(161, 25)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 1
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Name = "Label1"
		Me.Label10.BackColor = System.Drawing.Color.FromARGB(0, 192, 192)
		Me.Label10.Text = "FAITES UN LOGIN AVEC UN COMPTE EXISTANT, SI VOUS N'AVEZ PAS DE COMPTE OU VOUS AVEZ OUBLIE VOTRE MOT DE PASSE, ENTRER LA CLE DE VOTRE LOGICIEL PUIS CLIQUER SUR OK  ENSUITE  ENTRER UN NOUVEU NOM ET UN NOUVEU MOT DE PASSE PUIS CLIQUER SUR SAUVEGARDER ENSUITE ENTRER VOTRE NOUVEAU NOM ET MOT DE PASS ET CLICKER SUR LOGIN"
		Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.Black
		Me.Label10.Size = New System.Drawing.Size(217, 193)
		Me.Label10.Location = New System.Drawing.Point(496, 112)
		Me.Label10.TabIndex = 28
		Me.Label10.Visible = False
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.Enabled = True
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label10.Name = "Label10"
		Me.Controls.Add(Adodc2)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(Command29)
		Me.Controls.Add(Frame6)
		Me.Controls.Add(Frame5)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label10)
		Me.Frame6.Controls.Add(Label6)
		Me.Frame6.Controls.Add(Label5)
		Me.Frame5.Controls.Add(Text3)
		Me.Frame4.Controls.Add(Option2)
		Me.Frame4.Controls.Add(Option1)
		Me.Frame3.Controls.Add(Label4)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Text6)
		Me.Frame1.Controls.Add(Text5)
		Me.Frame1.Controls.Add(Text4)
		Me.Frame1.Controls.Add(ProgressBar1)
		Me.Frame1.Controls.Add(Text2)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(ShapeContainer1)
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.VOIR_INSTRUCTIONS, Me.CACHER_INSTRUCTIONS})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
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
		ADOBind_Adodc2 = New VB6.MBindingCollection()
		ADOBind_Adodc2.DataSource = CType(Adodc2, MSDATASRC.DataSource)
		ADOBind_Adodc2.Add(Text6, "Text", "MOT_DE_PASSE", Nothing, "Text6")
		ADOBind_Adodc2.Add(Text5, "Text", "UTILISATEUR", Nothing, "Text5")
		ADOBind_Adodc2.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_Adodc2.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_Adodc2.Clear()
		ADOBind_Adodc2.Dispose()
		ADOBind_Adodc2 = Nothing
	End Sub
#End Region 
End Class