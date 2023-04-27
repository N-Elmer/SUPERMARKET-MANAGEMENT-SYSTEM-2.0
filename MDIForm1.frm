VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H00FFFF80&
   Caption         =   "MENU"
   ClientHeight    =   10635
   ClientLeft      =   225
   ClientTop       =   870
   ClientWidth     =   15615
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.PictureBox Picture1 
      Align           =   1  'Align Top
      Height          =   11520
      Left            =   0
      ScaleHeight     =   11460
      ScaleWidth      =   15555
      TabIndex        =   0
      Top             =   0
      Width           =   15615
      Begin VB.CommandButton Command1 
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
         Height          =   495
         Left            =   9720
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   0
         Width           =   1575
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
         Left            =   8040
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   0
         Width           =   1575
      End
      Begin VB.Image Image4 
         Height          =   7200
         Left            =   9960
         Picture         =   "MDIForm1.frx":0000
         Top             =   6000
         Width           =   10785
      End
      Begin VB.Image Image2 
         Height          =   7200
         Left            =   11280
         Picture         =   "MDIForm1.frx":1544D
         Top             =   0
         Width           =   10800
      End
      Begin VB.Image Image1 
         Height          =   7200
         Left            =   0
         Picture         =   "MDIForm1.frx":2BDC3
         Top             =   0
         Width           =   11310
      End
      Begin VB.Image Image3 
         Height          =   7200
         Left            =   0
         Picture         =   "MDIForm1.frx":39A4F
         Top             =   6720
         Width           =   12780
      End
   End
   Begin VB.Menu ENG 
      Caption         =   "ENGLISH"
      Begin VB.Menu SUP 
         Caption         =   "SUPPLIER"
         Shortcut        =   ^{F1}
      End
      Begin VB.Menu SM 
         Caption         =   "SUPERMARKET"
         Shortcut        =   ^{F2}
      End
      Begin VB.Menu CUS 
         Caption         =   "CUSTOMMER"
         Shortcut        =   ^{F3}
      End
      Begin VB.Menu SAV 
         Caption         =   "SAVE"
         Shortcut        =   ^{F4}
      End
      Begin VB.Menu ST 
         Caption         =   "STOCK"
         Shortcut        =   ^{F5}
      End
      Begin VB.Menu CALCULATOR 
         Caption         =   "CALCULATOR"
         Shortcut        =   ^{F6}
      End
   End
   Begin VB.Menu FRA 
      Caption         =   "FRANCAIS"
      Begin VB.Menu FO 
         Caption         =   "FOURNISSEUR"
         Shortcut        =   +{F1}
      End
      Begin VB.Menu SUPP 
         Caption         =   "SUPERMARCHE"
         Shortcut        =   +{F2}
      End
      Begin VB.Menu CLT 
         Caption         =   "CLIENT"
         Shortcut        =   +{F3}
      End
      Begin VB.Menu CAI 
         Caption         =   "CAISSE"
         Shortcut        =   +{F4}
      End
      Begin VB.Menu STO 
         Caption         =   "STOCK"
         Shortcut        =   +{F5}
      End
      Begin VB.Menu CALCULATRICE 
         Caption         =   "CALCULATRICE"
         Shortcut        =   +{F6}
      End
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

Private Sub CAI_Click()
Beep 8000, 100
Form9.Show
End Sub

Private Sub CALCULATOR_Click()
Beep 8000, 100
Form13.Show
End Sub

Private Sub CALCULATRICE_Click()
Beep 8000, 100
Form14.Show
End Sub

Private Sub CLT_Click()
Beep 8000, 100
Form7.Show
End Sub

Private Sub Command1_Click()
Beep 8000, 100
MsgBox "DECONNEXION", vbOKOnly, "FERMER"
End
End Sub

Private Sub Command29_Click()
Beep 8000, 100
MsgBox "LOGING YOU OUT", vbOKOnly, "CLOSING"
End
End Sub

Private Sub CUS_Click()
Beep 8000, 100
Form8.Show
End Sub

Private Sub FO_Click()
Beep 8000, 100
Form3.Show
End Sub

Private Sub SAV_Click()
Beep 8000, 100
Form10.Show
End Sub

Private Sub SM_Click()
Beep 8000, 100
Form6.Show
End Sub

Private Sub ST_Click()
Beep 8000, 100
Form12.Show
End Sub

Private Sub STO_Click()
Beep 8000, 100
Form11.Show
End Sub

Private Sub SUP_Click()
Beep 8000, 100
Form4.Show
End Sub

Private Sub SUPP_Click()
Beep 8000, 100
Form5.Show
End Sub
