Option Strict Off
Option Explicit On
Friend Class Form8
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Beep was upgraded to Beep_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Declare Function Beep_Renamed Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim r As Object
		Beep_Renamed(8000, 100)
		With Adodc1.Recordset
			If Text1.Text = Text Then
				Beep_Renamed(500, 500)
				Beep_Renamed(500, 500)
				'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = MsgBox("ENTER ATLEAST ONE LINE BEFORE ADDING IN DATABASE", MsgBoxStyle.OKOnly, "ERROR")
				Beep_Renamed(8000, 100)
			Else
				.AddNew()
			End If
		End With
	End Sub
	
	
	Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
		Dim CommonDialog1 As Object
		Beep_Renamed(8000, 100)
		With CommonDialog1
			'UPGRADE_WARNING: Couldn't resolve default property of object CommonDialog1.DialogTitle. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.DialogTitle = "OPEN IMAGE"
			'UPGRADE_WARNING: Couldn't resolve default property of object CommonDialog1.Filter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Filter = "images files(*.jpg)|*.jpg|allfiles(*.*)|*.*"
			'UPGRADE_WARNING: Couldn't resolve default property of object CommonDialog1.ShowSave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ShowSave()
		End With
		'UPGRADE_WARNING: Couldn't resolve default property of object CommonDialog1.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Image1.Image = System.Drawing.Image.FromFile(CommonDialog1.FileName)
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim Var As Object
		Dim r As Object
		Beep_Renamed(8000, 100)
		If Text1.Text = Text Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("ENTER ATLEAST ONE LINE BEFORE MODIFING IN DATABASE", MsgBoxStyle.OKOnly, "ERROR")
			Beep_Renamed(8000, 100)
		Else
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("DO YOU REALLY WANT TO MODIFY?", MsgBoxStyle.YesNo, "WARNING")
			Beep_Renamed(8000, 100)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Var. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Var = Text1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object Var. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: SavePicture was upgraded to System.Drawing.Image.Save and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		Image1.Image.Save(My.Application.Info.DirectoryPath & "\images\" & Var & ".jpg")
	End Sub
	
	Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
		Beep_Renamed(8000, 100)
		End
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim aa As Object
		Dim r As Object
		Beep_Renamed(8000, 100)
		If Text1.Text = Text Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("ENTER ATLEAST ONE LINE BEFORE DELETING FROM DATABASE", MsgBoxStyle.OKOnly, "ERROR")
			Beep_Renamed(8000, 100)
		Else
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("DO YOU REALLY WISH TO DELETE?", MsgBoxStyle.YesNo, "WARNING")
			Beep_Renamed(8000, 100)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If r <> 6 Then Exit Sub
			With Adodc1.Recordset
				'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Move(aa)
				.Delete()
			End With
		End If
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Dim r As Object
		Beep_Renamed(8000, 100)
		If Text1.Text = Text Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("ENTER ATLEAST ONE LINE BEFORE SAVING IN DATABASE", MsgBoxStyle.OKOnly, "ERROR")
			Beep_Renamed(8000, 100)
		Else
			With Adodc1.Recordset
				Timer1.Interval = 5
				Timer1.Enabled = True
				.Update()
			End With
		End If
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Dim r As Object
		Beep_Renamed(8000, 100)
		If Text1.Text = Text Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("ENTER ATLEAST ONE LINE BEFORE SEARCHING DATABASE", MsgBoxStyle.OKOnly, "ERROR")
			Beep_Renamed(8000, 100)
		Else
			Timer1.Interval = 30
			Timer1.Enabled = True
			Adodc1.RecordSource = "select * from CUSTOMMER where CUSTOMMER_NAME like '%" & (Text3.Text) & "%'"
			Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdText
			Adodc1.Refresh()
		End If
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Adodc1.Recordset.MoveFirst()
		Beep_Renamed(8000, 100)
		importimage()
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		Adodc1.Recordset.MoveLast()
		Beep_Renamed(8000, 100)
		importimage()
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		If Adodc1.Recordset.BOF Then Adodc1.Recordset.MoveFirst()
		Adodc1.Recordset.MovePrevious()
		If Adodc1.Recordset.BOF And Adodc1.Recordset.RecordCount > 0 Then Adodc1.Recordset.MoveLast()
		Beep_Renamed(8000, 100)
		importimage()
	End Sub
	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		If Adodc1.Recordset.BOF Then Adodc1.Recordset.MoveFirst()
		Adodc1.Recordset.MoveNext()
		If Adodc1.Recordset.EOF And Adodc1.Recordset.RecordCount > 0 Then Adodc1.Recordset.MoveFirst()
		Beep_Renamed(8000, 100)
		importimage()
	End Sub
	
	Public Sub importimage()
		With Adodc1.Recordset
			.Find("CUSTOMMER_NUM='" & Text1.Text & "'")
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Dir(My.Application.Info.DirectoryPath & "\images\" & Trim(.Fields("CUSTOMMER_NUM").Value) & ".jpg") <> "" Then
				Image1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\images\" & Trim(.Fields("CUSTOMMER_NUM").Value) & ".jpg")
			Else
				'UPGRADE_NOTE: Object Image1.Picture may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				Image1.Image = Nothing
			End If
		End With
	End Sub
	
	Private Sub CommonDialog1_Click()
		
	End Sub
	
	Private Sub Form8_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		importimage()
	End Sub
	
	'UPGRADE_ISSUE: Label event Label4.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Label4_Change()
		Dim r As Object
		If CDbl(Label4.Text) = 100 Then
			'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Timer1.Interval = 0
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("DONE", MsgBoxStyle.OKOnly, "GENIUS CALCULATOR 2")
			Beep_Renamed(8000, 100)
			Command2.Visible = True
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If ProgressBar1.Value = 100 Then
			ProgressBar1.Value = 0
		Else
			ProgressBar1.Value = Val(CStr(ProgressBar1.Value)) + Val(CStr(1))
		End If
		Label4.Text = CStr(ProgressBar1.Value)
	End Sub
End Class