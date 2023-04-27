Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form1
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Beep was upgraded to Beep_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Declare Function Beep_Renamed Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
	
	
	Public Sub CACHER_INSTRUCTIONS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CACHER_INSTRUCTIONS.Click
		Beep_Renamed(8000, 100)
		Label10.Visible = False
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Beep_Renamed(8000, 100)
		Adodc1.RecordSource = "select * from DONNEESUTILISATEUR where UTILISATEUR='" & Text1.Text & "' and MOT_DE_PASSE='" & Text2.Text & "'"
		Adodc1.Refresh()
		If Adodc1.Recordset.EOF Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			MsgBox("ERREUR, VERIFIER UTILISATEUR ET MOT DE PASSE ET RE-ESSAIYER", MsgBoxStyle.Critical, "ERREUR")
			Beep_Renamed(8000, 100)
			Text1.Text = ""
			Text2.Text = ""
			Text4.Text = ""
			Timer1.Interval = 10
			Timer1.Enabled = True
		Else
			MsgBox("REUSSITE", MsgBoxStyle.Information, "REUSSITE")
			Beep_Renamed(8000, 100)
			Me.Hide()
			MDIForm1.Show()
		End If
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Beep_Renamed(8000, 100)
		If Text4.Text = "ADMIN123456789" Then
			MsgBox("REUSSITE", MsgBoxStyle.Information, "REUSSITE")
			Beep_Renamed(8000, 100)
			Command3.Enabled = True
			Text5.Enabled = True
			Text6.Enabled = True
			Command3.Visible = True
			Text4.Text = ""
			With Adodc2.Recordset
				.AddNew()
			End With
		Else
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			MsgBox("ERREUR, CLE INCORRECT RE-ESSAIYER", MsgBoxStyle.Critical, "MAUVAISE CLE")
			Beep_Renamed(8000, 100)
			Text4.Text = ""
			Timer1.Interval = 10
			Timer1.Enabled = True
			Command3.Enabled = True
			Text5.Enabled = False
			Text6.Enabled = False
			Command3.Visible = False
		End If
	End Sub
	
	Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
		Beep_Renamed(8000, 100)
		MsgBox("DECONNEXION", MsgBoxStyle.Information, "DECONNEXION")
		Beep_Renamed(8000, 100)
		End
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Beep_Renamed(8000, 100)
		If Text5.Text = Text And Text6.Text = Text Then
			Beep_Renamed(500, 500)
			Beep_Renamed(500, 500)
			MsgBox("ERREUR, SAISISSEZ UN NOUVEU NOM ET MOT DE PASSE AVANT DE SUAVEGARDER", MsgBoxStyle.Critical, "ERREUR DE SAISI")
			Beep_Renamed(8000, 100)
		Else
			With Adodc2.Recordset
				Timer1.Interval = 10
				Timer1.Enabled = True
				.Update()
				Command3.Enabled = False
				Text4.Text = ""
				Text5.Enabled = False
				Text6.Enabled = False
			End With
		End If
	End Sub
	
	'UPGRADE_ISSUE: Label event Label5.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Label5_Change()
		If CDbl(Label5.Text) = 100 Then
			'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Timer1.Interval = 0
			Command1.Visible = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event Option1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
		If eventSender.Checked Then
			Beep_Renamed(8000, 100)
			Me.Hide()
			Form2.Show()
			Option1.Refresh()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event Option2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
		If eventSender.Checked Then
			Beep_Renamed(8000, 100)
			Me.Hide()
			Me.Show()
			Option2.Refresh()
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If ProgressBar1.Value = 100 Then
			ProgressBar1.Value = 0
		Else
			ProgressBar1.Value = Val(CStr(ProgressBar1.Value)) + Val(CStr(1))
		End If
		Label5.Text = CStr(ProgressBar1.Value)
	End Sub
	
	Public Sub VOIR_INSTRUCTIONS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VOIR_INSTRUCTIONS.Click
		Beep_Renamed(8000, 100)
		Label10.Visible = True
	End Sub
End Class