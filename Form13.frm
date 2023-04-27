VERSION 5.00
Begin VB.Form Form13 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CALCULATOR"
   ClientHeight    =   5580
   ClientLeft      =   150
   ClientTop       =   795
   ClientWidth     =   4230
   LinkTopic       =   "Form13"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Form13.frx":0000
   ScaleHeight     =   5580
   ScaleMode       =   0  'User
   ScaleWidth      =   4484.583
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      BackColor       =   &H80000002&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   30
      Top             =   600
      Width           =   3615
   End
   Begin VB.CommandButton Command29 
      BackColor       =   &H000000FF&
      Caption         =   "CLOSE"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   5040
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.CommandButton Command28 
      BackColor       =   &H00808080&
      Caption         =   "X^2"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   3720
      Width           =   855
   End
   Begin VB.CommandButton Command27 
      BackColor       =   &H00808080&
      Caption         =   "X^y"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   3720
      Width           =   855
   End
   Begin VB.CommandButton Command26 
      BackColor       =   &H00808080&
      Caption         =   "10^y"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   4320
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command25 
      BackColor       =   &H00808080&
      Caption         =   "SqRoot"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command24 
      BackColor       =   &H00808080&
      Caption         =   "Log"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command23 
      Caption         =   "ln"
      Height          =   495
      Left            =   5400
      TabIndex        =   22
      Top             =   4320
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command22 
      BackColor       =   &H00808080&
      Caption         =   "e^y"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command21 
      BackColor       =   &H00808080&
      Caption         =   "TAN"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command20 
      BackColor       =   &H00808080&
      Caption         =   "COS"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command15 
      BackColor       =   &H00808080&
      Caption         =   "SIN"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command19 
      BackColor       =   &H00808080&
      Caption         =   "*"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3000
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   3720
      Width           =   855
   End
   Begin VB.CommandButton Command18 
      BackColor       =   &H00808080&
      Caption         =   "/"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3000
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command17 
      BackColor       =   &H00808080&
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3000
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command16 
      BackColor       =   &H00808080&
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3000
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command14 
      BackColor       =   &H00808080&
      Caption         =   "="
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   4320
      Width           =   1815
   End
   Begin VB.CommandButton Command12 
      BackColor       =   &H00808080&
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command11 
      BackColor       =   &H00808080&
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1080
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command10 
      BackColor       =   &H00808080&
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2040
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   3120
      Width           =   855
   End
   Begin VB.CommandButton Command9 
      BackColor       =   &H00808080&
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command8 
      BackColor       =   &H00808080&
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1080
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command7 
      BackColor       =   &H00808080&
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2040
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   2520
      Width           =   855
   End
   Begin VB.CommandButton Command6 
      BackColor       =   &H00808080&
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command5 
      BackColor       =   &H00808080&
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1080
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command4 
      BackColor       =   &H00808080&
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2040
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1920
      Width           =   855
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00808080&
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2040
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   3720
      Width           =   855
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00808080&
      Caption         =   "."
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1080
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   3720
      Width           =   855
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00808080&
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   3720
      Width           =   855
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H80000002&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3615
   End
   Begin VB.TextBox Text3 
      BackColor       =   &H80000002&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   28
      Top             =   1080
      Width           =   3615
   End
   Begin VB.Menu View 
      Caption         =   "MODE"
      Begin VB.Menu STANDARD 
         Caption         =   "STANDARD"
      End
      Begin VB.Menu SCIENTIFIC 
         Caption         =   "SCIENTIFIC"
      End
   End
   Begin VB.Menu EDIT 
      Caption         =   "EDIT"
      Begin VB.Menu COPY 
         Caption         =   "COPY"
         Shortcut        =   ^C
      End
      Begin VB.Menu PASTE 
         Caption         =   "PASTE"
         Shortcut        =   ^V
      End
   End
End
Attribute VB_Name = "Form13"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

Dim a As Double
Dim b As Double
Dim op As Integer
Dim fn As Double
Dim r As Double

Private Sub Command1_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 0
End Sub

Private Sub Command10_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 3
End Sub

Private Sub Command11_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 2
End Sub

Private Sub Command12_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 1
End Sub

Private Sub Command14_Click()
Beep 8000, 100
If op = 1 Then
a = Text2.Text
b = Text1.Text
Text3.Text = a + b
ElseIf op = 2 Then
a = Text2.Text
b = Text1.Text
Text3.Text = a - b
ElseIf op = 3 Then
a = Text2.Text
b = Text1.Text
Text3.Text = a / b
ElseIf op = 4 Then
a = Text2.Text
b = Text1.Text
Text3.Text = a * b
ElseIf op = 5 Then
a = Text2.Text
b = Text1.Text
Text3.Text = a ^ b
End If
End Sub

Private Sub Command15_Click()
fn = Math.Sin(Text1.Text * 3.14159265358979 / 180)
Text3.Text = fn
End Sub

Private Sub Command16_Click()
Beep 8000, 100
op = 1
Text2.Text = Text1.Text
Text1.Text = " "
End Sub

Private Sub Command17_Click()
Beep 8000, 100
op = 2
Text2.Text = Text1.Text
Text1.Text = " "
End Sub

Private Sub Command18_Click()
Beep 8000, 100
op = 3
Text2.Text = Text1.Text
Text1.Text = " "
End Sub

Private Sub Command19_Click()
Beep 8000, 100
op = 4
Text2.Text = Text1.Text
Text1.Text = " "
End Sub

Private Sub Command2_Click()
Beep 8000, 100
Text1.Text = Text1.Text & "."
End Sub

Private Sub Command20_Click()
fn = Math.Cos(Text1.Text * 3.14159265358979 / 180)
Text3.Text = fn
End Sub

Private Sub Command21_Click()
fn = Math.Tan(Text1.Text * 3.14159265358979 / 180)
Text3.Text = fn
End Sub

Private Sub Command22_Click()
b = Text1.Text
fn = 2.71828182845905 ^ b
Text3.Text = fn
End Sub

Private Sub Command24_Click()
fn = Math.Log(Text1.Text)
Text3.Text = fn * 0.434294481903252
End Sub

Private Sub Command25_Click()
fn = Math.Sqr(Text1.Text)
Text3.Text = fn
End Sub

Private Sub Command26_Click()
b = Text1.Text
fn = 10 ^ b
Text3.Text = fn
End Sub

Private Sub Command27_Click()
op = 5
Text2.Text = Text1.Text
Text1.Text = " "
End Sub

Private Sub Command28_Click()
b = Text1.Text
fn = b ^ 2
Text3.Text = fn
End Sub

Private Sub Command29_Click()
Beep 8000, 100
End
End Sub

Private Sub Command3_Click()
Beep 8000, 100
Dim txtclear
For Each txtclear In Form13
If TypeOf txtclear Is TextBox Then
txtclear.Text = ""
End If
Next
End Sub

Private Sub Command4_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 9
End Sub

Private Sub Command5_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 8
End Sub

Private Sub Command6_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 7
End Sub

Private Sub Command7_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 6
End Sub

Private Sub Command8_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 5
End Sub

Private Sub Command9_Click()
Beep 8000, 100
Text1.Text = Text1.Text & 4
End Sub

Private Sub COPY_Click()
Beep 8000, 100
r = Text1.Text
End Sub

Private Sub HELP_Click()

End Sub

Private Sub PASTE_Click()
Beep 8000, 100
Text1.Text = r
End Sub

Private Sub SCIENTIFIC_Click()
Beep 8000, 100
Me.Width = 6580
Text1.Width = 5950
Text2.Width = 5950
Text3.Width = 5950
End Sub

Private Sub STANDARD_Click()
Beep 8000, 100
Me.Width = 4280
Text1.Width = 3950
Text2.Width = 3950
Text3.Width = 3950
End Sub
