Option Strict Off
Option Explicit On
Friend Class Form9
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
				r = MsgBox("INSERER AU MOINS UNE LIGNE AVANT D'AJOUTER DANS LA BASE DE DONNEES", MsgBoxStyle.OKOnly, "ERREUR")
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
			r = MsgBox("INSERER AU MOINS UNE CASE AVANT DE MODIFIER DANS LA BASE DE DONNEES", MsgBoxStyle.OKOnly, "ERREUR")
			Beep_Renamed(8000, 100)
		Else
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("VOULEZ VOUS VRAIMENT MODIFIER?", MsgBoxStyle.YesNo, "ATTENTION")
			Beep_Renamed(8000, 100)
			With Adodc1.Recordset
				'UPGRADE_WARNING: Couldn't resolve default property of object Var. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Var = Text1.Text
			End With
		End If
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
			r = MsgBox("INSERER AU MOINS UNE CASE AVANT DE SUPPRIMMER DANS LA BASE DE DONNEES", MsgBoxStyle.OKOnly, "ERREUR")
			Beep_Renamed(8000, 100)
		Else
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("VOULEZ VOUS VRAIMENT SUPPRIMMER?", MsgBoxStyle.YesNo, "ATTENTION")
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
			r = MsgBox("INSERER AU MOINS UNE CASE AVANT D'ENREGISTRER DANS LA BASE DE DONNEES", MsgBoxStyle.OKOnly, "ERREUR")
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
			r = MsgBox("INSERER AU MOINS UNE CASE AVANT DE RECHERCHER DANS LA BASE DE DONNEES", MsgBoxStyle.OKOnly, "ERREUR")
			Beep_Renamed(8000, 100)
		Else
			Timer1.Interval = 30
			Timer1.Enabled = True
			Adodc1.RecordSource = "select * from CAISSE where NOM_ENREGISTREMENT like '%" & (Text7.Text) & "%'"
			Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdText
			Adodc1.Refresh()
		End If
	End Sub
	
	'UPGRADE_ISSUE: Label event Label8.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Label8_Change()
		Dim r As Object
		If CDbl(Label8.Text) = 100 Then
			'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Timer1.Interval = 0
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			'UPGRADE_WARNING: Couldn't resolve default property of object r. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			r = MsgBox("FINI", MsgBoxStyle.OKOnly, "GENI CALCUL 2")
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
		Label8.Text = CStr(ProgressBar1.Value)
	End Sub
End Class