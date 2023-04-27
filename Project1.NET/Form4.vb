Option Strict Off
Option Explicit On
Friend Class Form4
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
			With Adodc1.Recordset
				'UPGRADE_WARNING: Couldn't resolve default property of object Var. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Var = Text1.Text
			End With
		End If
	End Sub
	
	Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
		End
		Beep_Renamed(8000, 100)
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
			r = MsgBox("ENTER ATLEAST ONE LINE BEFORE SEARCHING DATABASE", MsgBoxStyle.OKOnly, "ERROR")
			Beep_Renamed(8000, 100)
		Else
			Timer1.Interval = 30
			Timer1.Enabled = True
			Adodc1.RecordSource = "select * from SUPPLIER where SUPPLIER_NAME like '%" & (Text6.Text) & "%'"
			Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdText
			Adodc1.Refresh()
		End If
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
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
	
	'UPGRADE_ISSUE: Label event Label7.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Label7_Change()
		Dim r As Object
		If CDbl(Label7.Text) = 100 Then
			'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Timer1.Interval = 0
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("DONE", MsgBoxStyle.OKOnly, "GENI CALCUL 2")
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
		Label7.Text = CStr(ProgressBar1.Value)
	End Sub
End Class