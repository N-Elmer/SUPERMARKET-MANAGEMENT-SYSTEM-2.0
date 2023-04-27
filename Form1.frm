VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.5#0"; "comctl32.ocx"
Begin VB.Form Form1 
   BackColor       =   &H00FFFF00&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PAGE D'ACCUEIL"
   ClientHeight    =   7065
   ClientLeft      =   150
   ClientTop       =   795
   ClientWidth     =   10770
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Form1.frx":0000
   ScaleHeight     =   7065
   ScaleWidth      =   10770
   StartUpPosition =   3  'Windows Default
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   330
      Left            =   9360
      Top             =   6240
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "DONNEESUTILISATEUR"
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
      Caption         =   "SAVEGARDER"
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
      TabIndex        =   27
      Top             =   5640
      Width           =   2415
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H8000000D&
      Caption         =   "OK"
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
      TabIndex        =   23
      Top             =   4320
      Width           =   2415
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   9360
      Top             =   5880
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CREDENTIELS.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from text1"
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
      Caption         =   "FERMER"
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
      Left            =   4080
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   6360
      Width           =   1575
   End
   Begin VB.Timer Timer1 
      Left            =   8880
      Top             =   6000
   End
   Begin VB.Frame Frame6 
      BackColor       =   &H00808000&
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
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   495
         Left            =   480
         TabIndex        =   17
         Top             =   120
         Width           =   375
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H00808000&
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
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
         Width           =   855
      End
   End
   Begin VB.Frame Frame5 
      BackColor       =   &H00808000&
      Height          =   375
      Left            =   6960
      TabIndex        =   13
      Top             =   6600
      Width           =   3735
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
         Height          =   375
         Left            =   0
         TabIndex        =   14
         Text            =   "NOUS PRENONS SOINS DE VOTRE  FUTURE"
         Top             =   0
         Width           =   3735
      End
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00808000&
      Caption         =   "LANGUE / LANGUAGE"
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
      TabIndex        =   10
      Top             =   6240
      Width           =   3855
      Begin VB.OptionButton Option2 
         BackColor       =   &H00FFFF80&
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
         Left            =   2040
         MaskColor       =   &H00400000&
         TabIndex        =   12
         Top             =   240
         Width           =   1455
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00FFFF80&
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
         Left            =   240
         MaskColor       =   &H00400000&
         TabIndex        =   11
         Top             =   240
         Width           =   1455
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00808000&
      Height          =   1215
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   10575
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         Caption         =   "BIEN VENU DANS GENI CALCUL"
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
         Left            =   1920
         TabIndex        =   9
         Top             =   360
         Width           =   6615
      End
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H8000000D&
      Caption         =   "LOGIN"
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
      TabIndex        =   7
      Top             =   3240
      Width           =   2415
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00808000&
      Height          =   855
      Left            =   120
      TabIndex        =   4
      Top             =   1440
      Width           =   5415
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         Caption         =   "ACCUEIL"
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
         Left            =   360
         TabIndex        =   6
         Top             =   240
         Width           =   4575
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00808000&
      ForeColor       =   &H8000000B&
      Height          =   3855
      Left            =   120
      TabIndex        =   0
      Top             =   2280
      Width           =   5415
      Begin VB.TextBox Text6 
         DataField       =   "MOT_DE_PASSE"
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
         Left            =   2520
         PasswordChar    =   "*"
         TabIndex        =   22
         Top             =   3000
         Width           =   2055
      End
      Begin VB.TextBox Text5 
         DataField       =   "UTILISATEUR"
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
         Left            =   2520
         PasswordChar    =   "*"
         TabIndex        =   21
         Top             =   2640
         Width           =   2055
      End
      Begin VB.TextBox Text4 
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
         Left            =   2520
         PasswordChar    =   "*"
         TabIndex        =   20
         Top             =   1680
         Width           =   2055
      End
      Begin ComctlLib.ProgressBar ProgressBar1 
         Height          =   375
         Left            =   2520
         TabIndex        =   19
         Top             =   960
         Width           =   2055
         _ExtentX        =   3625
         _ExtentY        =   661
         _Version        =   327682
         Appearance      =   0
      End
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
         Left            =   2520
         PasswordChar    =   "*"
         TabIndex        =   5
         Top             =   600
         Width           =   2055
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
         Left            =   2520
         TabIndex        =   3
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "NOUVEAU MOT DE PASSE"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   26
         Top             =   3000
         Width           =   2415
      End
      Begin VB.Label Label8 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "NOUVEU UTILISATEUR"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00400000&
         Height          =   375
         Left            =   120
         TabIndex        =   25
         Top             =   2640
         Width           =   2415
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "CLE "
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
         TabIndex        =   24
         Top             =   1680
         Width           =   2415
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         BorderWidth     =   2
         X1              =   0
         X2              =   5400
         Y1              =   1680
         Y2              =   1680
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "MOT DE PASSE"
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
         TabIndex        =   2
         Top             =   600
         Width           =   2415
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00C0C000&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "NOM UTILISATEUR"
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
         TabIndex        =   1
         Top             =   240
         Width           =   2415
      End
   End
   Begin VB.Label Label10 
      BackColor       =   &H00C0C000&
      BorderStyle     =   1  'Fixed Single
      Caption         =   $"Form1.frx":17146
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
      Height          =   2895
      Left            =   7440
      TabIndex        =   28
      Top             =   1320
      Visible         =   0   'False
      Width           =   3255
   End
   Begin VB.Menu VOIR_INSTRUCTIONS 
      Caption         =   "VOIR_INSTRUCTIONS"
   End
   Begin VB.Menu CACHER_INSTRUCTIONS 
      Caption         =   "CACHER_INSTRUCTIONS"
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long


Private Sub CACHER_INSTRUCTIONS_Click()
Beep 8000, 100
Label10.Visible = False
End Sub

Private Sub Command1_Click()
Beep 8000, 100
Adodc1.RecordSource = "select * from DONNEESUTILISATEUR where UTILISATEUR='" + Text1.Text + "' and MOT_DE_PASSE='" + Text2.Text + "'"
Adodc1.Refresh
If Adodc1.Recordset.EOF Then
Beep 500, 500
Beep 500, 500
MsgBox "ERREUR, VERIFIER UTILISATEUR ET MOT DE PASSE ET RE-ESSAIYER", vbCritical, "ERREUR"
Beep 8000, 100
Text1.Text = ""
Text2.Text = ""
Text4.Text = ""
Timer1.Interval = 10
Timer1.Enabled = True
Else
MsgBox "REUSSITE", vbInformation, "REUSSITE"
Beep 8000, 100
Me.Hide
MDIForm1.Show
End If
End Sub

Private Sub Command2_Click()
Beep 8000, 100
If Text4.Text = "ADMIN123456789" Then
MsgBox "REUSSITE", vbInformation, "REUSSITE"
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
MsgBox "ERREUR, CLE INCORRECT RE-ESSAIYER", vbCritical, "MAUVAISE CLE"
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
MsgBox "DECONNEXION", vbInformation, "DECONNEXION"
Beep 8000, 100
End
End Sub

Private Sub Command3_Click()
Beep 8000, 100
If Text5.Text = Text And Text6.Text = Text Then
Beep 500, 500
Beep 500, 500
MsgBox "ERREUR, SAISISSEZ UN NOUVEU NOM ET MOT DE PASSE AVANT DE SUAVEGARDER", vbCritical, "ERREUR DE SAISI"
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
Form2.Show
Option1.Refresh
End Sub

Private Sub Option2_Click()
Beep 8000, 100
Me.Hide
Form1.Show
Option2.Refresh
End Sub

Private Sub Timer1_Timer()
If ProgressBar1.Value = 100 Then
ProgressBar1.Value = 0
Else
ProgressBar1.Value = Val(ProgressBar1.Value) + Val(1)
End If
Label5.Caption = ProgressBar1.Value
End Sub

Private Sub VOIR_INSTRUCTIONS_Click()
Beep 8000, 100
Label10.Visible = True
End Sub
