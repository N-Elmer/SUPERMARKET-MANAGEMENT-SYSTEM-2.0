Option Strict Off
Option Explicit On
Friend Class Form13
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Beep was upgraded to Beep_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Declare Function Beep_Renamed Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
	
	Dim a As Double
	Dim b As Double
	Dim op As Short
	Dim fn As Double
	Dim r As Double
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 0
	End Sub
	
	Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 3
	End Sub
	
	Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 2
	End Sub
	
	Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 1
	End Sub
	
	Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command14.Click
		Beep_Renamed(8000, 100)
		If op = 1 Then
			a = CDbl(Text2.Text)
			b = CDbl(Text1.Text)
			Text3.Text = CStr(a + b)
		ElseIf op = 2 Then 
			a = CDbl(Text2.Text)
			b = CDbl(Text1.Text)
			Text3.Text = CStr(a - b)
		ElseIf op = 3 Then 
			a = CDbl(Text2.Text)
			b = CDbl(Text1.Text)
			Text3.Text = CStr(a / b)
		ElseIf op = 4 Then 
			a = CDbl(Text2.Text)
			b = CDbl(Text1.Text)
			Text3.Text = CStr(a * b)
		ElseIf op = 5 Then 
			a = CDbl(Text2.Text)
			b = CDbl(Text1.Text)
			Text3.Text = CStr(a ^ b)
		End If
	End Sub
	
	Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command15.Click
		fn = System.Math.Sin(CDbl(Text1.Text) * 3.14159265358979 / 180)
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command16.Click
		Beep_Renamed(8000, 100)
		op = 1
		Text2.Text = Text1.Text
		Text1.Text = " "
	End Sub
	
	Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command17.Click
		Beep_Renamed(8000, 100)
		op = 2
		Text2.Text = Text1.Text
		Text1.Text = " "
	End Sub
	
	Private Sub Command18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command18.Click
		Beep_Renamed(8000, 100)
		op = 3
		Text2.Text = Text1.Text
		Text1.Text = " "
	End Sub
	
	Private Sub Command19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command19.Click
		Beep_Renamed(8000, 100)
		op = 4
		Text2.Text = Text1.Text
		Text1.Text = " "
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & "."
	End Sub
	
	Private Sub Command20_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command20.Click
		fn = System.Math.Cos(CDbl(Text1.Text) * 3.14159265358979 / 180)
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command21_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command21.Click
		fn = System.Math.Tan(CDbl(Text1.Text) * 3.14159265358979 / 180)
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command22_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command22.Click
		b = CDbl(Text1.Text)
		fn = 2.71828182845905 ^ b
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command24.Click
		fn = System.Math.Log(CDbl(Text1.Text))
		Text3.Text = CStr(fn * 0.434294481903252)
	End Sub
	
	Private Sub Command25_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command25.Click
		fn = System.Math.Sqrt(CDbl(Text1.Text))
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command26_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command26.Click
		b = CDbl(Text1.Text)
		fn = 10 ^ b
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command27_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command27.Click
		op = 5
		Text2.Text = Text1.Text
		Text1.Text = " "
	End Sub
	
	Private Sub Command28_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command28.Click
		b = CDbl(Text1.Text)
		fn = b ^ 2
		Text3.Text = CStr(fn)
	End Sub
	
	Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
		Beep_Renamed(8000, 100)
		End
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Beep_Renamed(8000, 100)
		Dim txtclear As Object
		For	Each txtclear In Me.Controls
			If TypeOf txtclear Is System.Windows.Forms.TextBox Then
				'UPGRADE_WARNING: Couldn't resolve default property of object txtclear.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				txtclear.Text = ""
			End If
		Next txtclear
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 9
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 8
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 7
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 6
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 5
	End Sub
	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		Beep_Renamed(8000, 100)
		Text1.Text = Text1.Text & 4
	End Sub
	
	Public Sub COPY_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles COPY.Click
		Beep_Renamed(8000, 100)
		r = CDbl(Text1.Text)
	End Sub
	
	Private Sub HELP_Click()
		
	End Sub
	
	Public Sub PASTE_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PASTE.Click
		Beep_Renamed(8000, 100)
		Text1.Text = CStr(r)
	End Sub
	
	Public Sub SCIENTIFIC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SCIENTIFIC.Click
		Beep_Renamed(8000, 100)
		Me.Width = VB6.TwipsToPixelsX(6580)
		Text1.Width = VB6.ToPixelsUserWidth(5950, 4484.58, 282)
		Text2.Width = VB6.ToPixelsUserWidth(5950, 4484.58, 282)
		Text3.Width = VB6.ToPixelsUserWidth(5950, 4484.58, 282)
	End Sub
	
	Public Sub STANDARD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles STANDARD.Click
		Beep_Renamed(8000, 100)
		Me.Width = VB6.TwipsToPixelsX(4280)
		Text1.Width = VB6.ToPixelsUserWidth(3950, 4484.58, 282)
		Text2.Width = VB6.ToPixelsUserWidth(3950, 4484.58, 282)
		Text3.Width = VB6.ToPixelsUserWidth(3950, 4484.58, 282)
	End Sub
End Class