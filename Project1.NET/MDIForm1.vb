Option Strict Off
Option Explicit On
Friend Class MDIForm1
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Beep was upgraded to Beep_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Declare Function Beep_Renamed Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
	
	Public Sub CAI_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CAI.Click
		Beep_Renamed(8000, 100)
		Form9.Show()
	End Sub
	
	Public Sub CALCULATOR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CALCULATOR.Click
		Beep_Renamed(8000, 100)
		Form13.Show()
	End Sub
	
	Public Sub CALCULATRICE_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CALCULATRICE.Click
		Beep_Renamed(8000, 100)
		Form14.Show()
	End Sub
	
	Public Sub CLT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CLT.Click
		Beep_Renamed(8000, 100)
		Form7.Show()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Beep_Renamed(8000, 100)
		MsgBox("DECONNEXION", MsgBoxStyle.OKOnly, "FERMER")
		End
	End Sub
	
	Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
		Beep_Renamed(8000, 100)
		MsgBox("LOGING YOU OUT", MsgBoxStyle.OKOnly, "CLOSING")
		End
	End Sub
	
	Public Sub CUS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CUS.Click
		Beep_Renamed(8000, 100)
		Form8.Show()
	End Sub
	
	Public Sub FO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FO.Click
		Beep_Renamed(8000, 100)
		Form3.Show()
	End Sub
	
	Public Sub SAV_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SAV.Click
		Beep_Renamed(8000, 100)
		Form10.Show()
	End Sub
	
	Public Sub SM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SM.Click
		Beep_Renamed(8000, 100)
		Form6.Show()
	End Sub
	
	Public Sub ST_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ST.Click
		Beep_Renamed(8000, 100)
		Form12.Show()
	End Sub
	
	Public Sub STO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles STO.Click
		Beep_Renamed(8000, 100)
		Form11.Show()
	End Sub
	
	Public Sub SUP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SUP.Click
		Beep_Renamed(8000, 100)
		Form4.Show()
	End Sub
	
	Public Sub SUPP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SUPP.Click
		Beep_Renamed(8000, 100)
		Form5.Show()
	End Sub
End Class