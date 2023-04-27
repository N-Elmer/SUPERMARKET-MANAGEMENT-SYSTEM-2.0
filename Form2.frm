VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.5#0"; "comctl32.ocx"
Begin VB.Form Form2 
   BackColor       =   &H00FFFF00&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "HOME PAGE"
   ClientHeight    =   7095
   ClientLeft      =   150
   ClientTop       =   795
   ClientWidth     =   10785
   FillColor       =   &H00FFFF00&
   BeginProperty Font 
      Name            =   "Times New Roman"
      Size            =   24
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Form2.frx":0000
   ScaleHeight     =   7095
   ScaleWidth      =   10785
   StartUpPosition =   3  'Windows Default
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   330
      Left            =   9360
      Top             =   6120
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIALS.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIALS.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "USERDATA"
      Caption         =   "Adodc2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H8000000D&
      Caption         =   "SAVE"
      DownPicture     =   "Form2.frx":DC8C
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      MaskColor       =   &H00808000&
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   5640
      Width           =   2175
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00808000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   10575
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         Caption         =   "WELCOME TO THE GENUIS CALCULATOR"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   615
         Left            =   840
         TabIndex        =   11
         Top             =   360
         Width           =   8895
      End
   End
   Begin VB.TextBox Text4 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      IMEMode         =   3  'DISABLE
      Left            =   2400
      PasswordChar    =   "*"
      TabIndex        =   20
      Top             =   3960
      Width           =   2295
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H8000000D&
      Caption         =   "OK"
      DownPicture     =   "Form2.frx":2AD89
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      MaskColor       =   &H00808000&
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   4320
      Width           =   2175
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   9360
      Top             =   5760
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   1
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIALS.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIALS.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from USERDATA"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
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
      Height          =   615
      Left            =   3960
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   6360
      Width           =   1575
   End
   Begin VB.Timer Timer1 
      Left            =   8880
      Top             =   5880
   End
   Begin VB.Frame Frame5 
      BackColor       =   &H00808000&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      TabIndex        =   13
      Top             =   6600
      Width           =   3495
      Begin VB.TextBox Text3 
         Alignment       =   2  'Center
         BackColor       =   &H00808000&
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   405
         Left            =   0
         TabIndex        =   14
         Text            =   "WE CARE FOR YOUR FUTURE"
         Top             =   0
         Width           =   3495
      End
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00808000&
      Caption         =   "LANGUAGE / LANGUE"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00400000&
      Height          =   735
      Left            =   120
      TabIndex        =   4
      Top             =   6240
      Width           =   3735
      Begin VB.OptionButton Option2 
         BackColor       =   &H00C0C000&
         Caption         =   "ENGLISH"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   2040
         MaskColor       =   &H00400000&
         TabIndex        =   6
         Top             =   240
         Width           =   1335
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00C0C000&
         Caption         =   "FRANCAIS"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   240
         MaskColor       =   &H00400000&
         TabIndex        =   5
         Top             =   240
         Width           =   1335
      End
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H8000000D&
      Caption         =   "LOGIN"
      DownPicture     =   "Form2.frx":47E86
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      MaskColor       =   &H00808000&
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   3240
      Width           =   2175
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00808000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   1
      Top             =   1560
      Width           =   5415
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         Caption         =   "HOME PAGE"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   495
         Left            =   720
         TabIndex        =   12
         Top             =   240
         Width           =   3975
      End
   End
   Begin VB.Frame Frame6 
      BackColor       =   &H00808000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4680
      TabIndex        =   15
      Top             =   3120
      Width           =   855
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H00808000&
         Caption         =   "%"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   495
         Left            =   360
         TabIndex        =   17
         Top             =   120
         Width           =   495
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H00808000&
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   495
         Left            =   -120
         TabIndex        =   16
         Top             =   120
         Width           =   735
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00808000&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3735
      Left            =   120
      TabIndex        =   2
      Top             =   2400
      Width           =   5415
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         IMEMode         =   3  'DISABLE
         Left            =   2280
         PasswordChar    =   "*"
         TabIndex        =   8
         Top             =   480
         Width           =   2295
      End
      Begin ComctlLib.ProgressBar ProgressBar1 
         Height          =   375
         Left            =   2280
         TabIndex        =   27
         Top             =   840
         Width           =   2295
         _ExtentX        =   4048
         _ExtentY        =   661
         _Version        =   327682
         Appearance      =   0
      End
      Begin VB.TextBox Text6 
         BackColor       =   &H00FFFFFF&
         DataField       =   "PASSWORD"
         DataSource      =   "Adodc2"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         IMEMode         =   3  'DISABLE
         Left            =   2280
         PasswordChar    =   "*"
         TabIndex        =   25
         Top             =   2880
         Width           =   2295
      End
      Begin VB.TextBox Text5 
         BackColor       =   &H00FFFFFF&
         DataField       =   "USER_NAME"
         DataSource      =   "Adodc2"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         IMEMode         =   3  'DISABLE
         Left            =   2280
         PasswordChar    =   "*"
         TabIndex        =   24
         Top             =   2520
         Width           =   2295
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2280
         TabIndex        =   7
         Top             =   120
         Width           =   2295
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "NEW PASSWORD"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   23
         Top             =   2880
         Width           =   2175
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         BorderWidth     =   2
         X1              =   0
         X2              =   5400
         Y1              =   1560
         Y2              =   1560
      End
      Begin VB.Label Label8 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "NEW USER NAME"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   22
         Top             =   2520
         Width           =   2175
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PRODUCT KEY"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   21
         Top             =   1560
         Width           =   2175
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PASSWORD"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   10
         Top             =   480
         Width           =   2175
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "USER NAME"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   9
         Top             =   120
         Width           =   2175
      End
   End
   Begin VB.Label Label10 
      BackColor       =   &H00C0C000&
      BorderStyle     =   1  'Fixed Single
      Caption         =   $"Form2.frx":64F83
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   2655
      Left            =   7200
      TabIndex        =   28
      Top             =   1440
      Visible         =   0   'False
      Width           =   3495
   End
   Begin VB.Menu SHOW_HELP 
      Caption         =   "SHOW_HELP"
   End
   Begin VB.Menu HIDE_HELP 
      Caption         =   "HIDE_HELP"
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

Private Sub HIDE_HELP_Click()
Beep 8000, 100
Label10.Visible = False
End Sub

Private Sub Command1_Click()
Beep 8000, 100
Adodc1.RecordSource = "select * from USERDATA where USER_NAME='" + Text1.Text + "' and PASSWORD='" + Text2.Text + "'"
Adodc1.Refresh
If Adodc1.Recordset.EOF Then
Beep 500, 500
Beep 500, 500
MsgBox "ERROR, CHECK USERNAME AND PASSWORD THEN RETRY", vbCritical, "CREDENTIAL ERROR"
Beep 8000, 100
Text1.Text = ""
Text2.Text = ""
Text4.Text = ""
Timer1.Interval = 10
Timer1.Enabled = True
Else
MsgBox "SUCCESS", vbInformation, "SUCCESS"
Beep 8000, 100
Me.Hide
MDIForm1.Show
End If
End Sub

Private Sub Command2_Click()
Beep 8000, 100
If Text4.Text = "ADMIN123456789" Then
MsgBox "SUCCESS", vbInformation, "SUCCESS"
Beep 8000, 100
Command3.Enabled = True
Text5.Enabled = True
Text6.Enabled = True
Command3.Visible = True
Text4.Text = ""
With Adodc2.Recordset
.AddNew
End With
Else
Beep 500, 500
Beep 500, 500
MsgBox "ERROR, PRODUCT KEY THEN RETRY", vbCritical, "PRODUCT KEY ERROR"
Beep 8000, 100
Text4.Text = ""
Timer1.Interval = 10
Timer1.Enabled = True
Command3.Enabled = True
Text5.Enabled = False
Text6.Enabled = False
Command3.Visible = False
End If
End Sub

Private Sub Command29_Click()
Beep 8000, 100
MsgBox "LOGING OUT", vbInformation, "CLOSING"
Beep 8000, 100
End
End Sub


Private Sub Command3_Click()
Beep 8000, 100
If Text5.Text = Text And Text6.Text = Text Then
Beep 500, 500
Beep 500, 500
MsgBox "ERROR, TYPE IN NEW USER NAME AND NEW PASSWORD BEFORE SAVING", vbCritical, "INPUT ERROR"
Beep 8000, 100
Else
With Adodc2.Recordset
Timer1.Interval = 10
Timer1.Enabled = True
.Update
Command3.Enabled = False
Text4.Text = ""
Text5.Enabled = False
Text6.Enabled = False
End With
End If
End Sub

Private Sub Label5_Change()
If Label5.Caption = 100 Then
Timer1.Interval = 0
Command1.Visible = True
End If
End Sub

Private Sub Option1_Click()
Beep 8000, 100
Me.Hide
Form1.Show
Option2.Refresh
End Sub

Private Sub Option2_Click()
Beep 8000, 100
Me.Hide
Form2.Show
Option1.Refresh
End Sub

Private Sub SHOW_HELP_Click()
Beep 8000, 100
Label10.Visible = True
End Sub

Private Sub Timer1_Timer()
If ProgressBar1.Value = 100 Then
ProgressBar1.Value = 0
Else
ProgressBar1.Value = Val(ProgressBar1.Value) + Val(1)
End If
Label5.Caption = ProgressBar1.Value
End Sub

