VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{8E27C92E-1264-101C-8A2F-040224009C02}#7.0#0"; "MSCAL.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "msdatgrd.ocx"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.5#0"; "comctl32.ocx"
Begin VB.Form Form8 
   BackColor       =   &H00FFFF00&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CUSTOMMER"
   ClientHeight    =   7185
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   10770
   LinkTopic       =   "Form8"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7185
   ScaleWidth      =   10770
   StartUpPosition =   3  'Windows Default
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
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   6480
      Visible         =   0   'False
      Width           =   1575
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   5280
      Top             =   3480
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DATA BASE1.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DATA BASE1.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "CUSTOMMER"
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
   Begin VB.CommandButton Command10 
      BackColor       =   &H00FFFF00&
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7560
      MaskColor       =   &H00FFFF00&
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   4800
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.CommandButton Command9 
      BackColor       =   &H00FFFF00&
      Caption         =   ">"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8160
      MaskColor       =   &H00FFFF00&
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   4800
      Width           =   495
   End
   Begin VB.CommandButton Command8 
      BackColor       =   &H00FFFF00&
      Caption         =   "<"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      MaskColor       =   &H00FFFF00&
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   4800
      Width           =   495
   End
   Begin VB.CommandButton Command7 
      BackColor       =   &H00FFFF00&
      Caption         =   "|>"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8640
      MaskColor       =   &H00FFFF00&
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   4800
      Width           =   495
   End
   Begin VB.CommandButton Command6 
      BackColor       =   &H00FFFF00&
      Caption         =   "<|"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6600
      MaskColor       =   &H00FFFF00&
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   4800
      Width           =   495
   End
   Begin VB.Timer Timer1 
      Left            =   8760
      Top             =   6600
   End
   Begin VB.TextBox Text3 
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
      Height          =   495
      Left            =   7560
      TabIndex        =   15
      Top             =   5280
      Width           =   1575
   End
   Begin VB.CommandButton Command5 
      BackColor       =   &H00FFFF00&
      Caption         =   "SEARCH A NAME"
      DownPicture     =   "Form8.frx":0000
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   5280
      Width           =   1575
   End
   Begin VB.CommandButton Command4 
      BackColor       =   &H00FFFF00&
      Caption         =   "SAVE"
      DownPicture     =   "Form8.frx":1677C
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   4680
      Width           =   1575
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00FFFF00&
      Caption         =   "DELETE"
      DownPicture     =   "Form8.frx":2CEF8
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   4080
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00FFFF00&
      Caption         =   "MODIFY"
      DownPicture     =   "Form8.frx":43674
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3480
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00FFFF00&
      Caption         =   "ADD"
      DownPicture     =   "Form8.frx":59DF0
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9120
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   2880
      Width           =   1575
   End
   Begin VB.Frame Frame5 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   4
      Top             =   2520
      Width           =   3135
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
         DataField       =   "CUSTOMMER_NAME"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         TabIndex        =   8
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   3
      Top             =   2520
      Width           =   3135
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "CUSTOMMER_NAME"
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
         Left            =   0
         TabIndex        =   6
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   2
      Top             =   1440
      Width           =   3135
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         DataField       =   "CUSTOMMER_NUM"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         TabIndex        =   7
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   1
      Top             =   1440
      Width           =   3135
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "CUSTOMMER_NUM"
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
         Left            =   0
         TabIndex        =   5
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00808000&
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6495
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "CUSTOMMER"
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
         Left            =   0
         TabIndex        =   9
         Top             =   240
         Width           =   6495
      End
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "Form8.frx":7056C
      Height          =   3135
      Left            =   120
      TabIndex        =   24
      Top             =   3840
      Width           =   6375
      _ExtentX        =   11245
      _ExtentY        =   5530
      _Version        =   393216
      BackColor       =   16776960
      ForeColor       =   0
      HeadLines       =   1
      RowHeight       =   18
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Times New Roman"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   "CUSTOMMER"
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin ComctlLib.ProgressBar ProgressBar1 
      Height          =   495
      Left            =   7560
      TabIndex        =   25
      Top             =   5880
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   873
      _Version        =   327682
      BorderStyle     =   1
      Appearance      =   0
   End
   Begin MSACAL.Calendar Calendar1 
      Height          =   2415
      Left            =   6720
      TabIndex        =   18
      Top             =   120
      Width           =   3975
      _Version        =   524288
      _ExtentX        =   7011
      _ExtentY        =   4260
      _StockProps     =   1
      BackColor       =   16776960
      Year            =   2019
      Month           =   1
      Day             =   30
      DayLength       =   1
      MonthLength     =   2
      DayFontColor    =   0
      FirstDay        =   1
      GridCellEffect  =   1
      GridFontColor   =   10485760
      GridLinesColor  =   -2147483632
      ShowDateSelectors=   -1  'True
      ShowDays        =   -1  'True
      ShowHorizontalGrid=   -1  'True
      ShowTitle       =   -1  'True
      ShowVerticalGrid=   -1  'True
      TitleFontColor  =   10485760
      ValueIsNull     =   0   'False
      BeginProperty DayFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty GridFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty TitleFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Image Image1 
      BorderStyle     =   1  'Fixed Single
      Height          =   1815
      Left            =   6720
      Stretch         =   -1  'True
      Top             =   2880
      Width           =   2295
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF00&
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
      Left            =   8160
      TabIndex        =   17
      Top             =   6480
      Width           =   375
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF00&
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
      ForeColor       =   &H00400000&
      Height          =   495
      Left            =   7560
      TabIndex        =   16
      Top             =   6480
      Width           =   615
   End
   Begin VB.Image Image2 
      Enabled         =   0   'False
      Height          =   7200
      Left            =   0
      Picture         =   "Form8.frx":70581
      Top             =   0
      Width           =   10800
   End
End
Attribute VB_Name = "Form8"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

Private Sub Command1_Click()
Beep 8000, 100
With Adodc1.Recordset
If Text1.Text = Text Then
Beep 500, 500
Beep 500, 500
r = MsgBox("ENTER ATLEAST ONE LINE BEFORE ADDING IN DATABASE", vbOKOnly, "ERROR")
Beep 8000, 100
Else
.AddNew
End If
End With
End Sub


Private Sub Command10_Click()
Beep 8000, 100
With CommonDialog1
.DialogTitle = "OPEN IMAGE"
.Filter = "images files(*.jpg)|*.jpg|allfiles(*.*)|*.*"
.ShowSave
End With
Image1.Picture = LoadPicture(CommonDialog1.FileName)
End Sub

Private Sub Command2_Click()
Beep 8000, 100
If Text1.Text = Text Then
Beep 500, 500
Beep 500, 500
r = MsgBox("ENTER ATLEAST ONE LINE BEFORE MODIFING IN DATABASE", vbOKOnly, "ERROR")
Beep 8000, 100
Else
Beep 500, 500
Beep 500, 500
r = MsgBox("DO YOU REALLY WANT TO MODIFY?", vbYesNo, "WARNING")
Beep 8000, 100
End If
Var = Text1.Text
SavePicture Image1.Picture, App.Path & "\images\" & Var & ".jpg"
End Sub

Private Sub Command29_Click()
Beep 8000, 100
End
End Sub

Private Sub Command3_Click()
Beep 8000, 100
If Text1.Text = Text Then
Beep 500, 500
Beep 500, 500
r = MsgBox("ENTER ATLEAST ONE LINE BEFORE DELETING FROM DATABASE", vbOKOnly, "ERROR")
Beep 8000, 100
Else
Beep 500, 500
Beep 500, 500
r = MsgBox("DO YOU REALLY WISH TO DELETE?", vbYesNo, "WARNING")
Beep 8000, 100
If r <> 6 Then Exit Sub
With Adodc1.Recordset
.Move aa
.Delete
End With
End If
End Sub

Private Sub Command4_Click()
Beep 8000, 100
If Text1.Text = Text Then
Beep 500, 500
Beep 500, 500
r = MsgBox("ENTER ATLEAST ONE LINE BEFORE SAVING IN DATABASE", vbOKOnly, "ERROR")
Beep 8000, 100
Else
With Adodc1.Recordset
Timer1.Interval = 5
Timer1.Enabled = True
.Update
End With
End If
End Sub

Private Sub Command5_Click()
Beep 8000, 100
If Text1.Text = Text Then
Beep 500, 500
Beep 500, 500
r = MsgBox("ENTER ATLEAST ONE LINE BEFORE SEARCHING DATABASE", vbOKOnly, "ERROR")
Beep 8000, 100
Else
Timer1.Interval = 30
Timer1.Enabled = True
Adodc1.RecordSource = "select * from CUSTOMMER where CUSTOMMER_NAME like '%" & (Text3.Text) & "%'"
Adodc1.CommandType = adCmdText
Adodc1.Refresh
End If
End Sub

Private Sub Command6_Click()
Adodc1.Recordset.MoveFirst
Beep 8000, 100
importimage
End Sub

Private Sub Command7_Click()
Adodc1.Recordset.MoveLast
Beep 8000, 100
importimage
End Sub

Private Sub Command8_Click()
If Adodc1.Recordset.BOF Then Adodc1.Recordset.MoveFirst
Adodc1.Recordset.MovePrevious
If Adodc1.Recordset.BOF And Adodc1.Recordset.RecordCount > 0 Then Adodc1.Recordset.MoveLast
Beep 8000, 100
importimage
End Sub

Private Sub Command9_Click()
If Adodc1.Recordset.BOF Then Adodc1.Recordset.MoveFirst
Adodc1.Recordset.MoveNext
If Adodc1.Recordset.EOF And Adodc1.Recordset.RecordCount > 0 Then Adodc1.Recordset.MoveFirst
Beep 8000, 100
importimage
End Sub

Public Sub importimage()
With Adodc1.Recordset
.Find "CUSTOMMER_NUM='" & Text1.Text & "'"
If Dir$(App.Path & "\images\" & Trim(!CUSTOMMER_NUM) & ".jpg") <> "" Then
Set Image1.Picture = LoadPicture(App.Path & "\images\" & Trim(!CUSTOMMER_NUM) & ".jpg")
Else
Set Image1.Picture = Nothing
End If
End With
End Sub

Private Sub CommonDialog1_Click()

End Sub

Private Sub Form_Load()
importimage
End Sub

Private Sub Label4_Change()
If Label4.Caption = 100 Then
Timer1.Interval = 0
Beep 500, 500
Beep 500, 500
r = MsgBox("DONE", vbOKOnly, "GENIUS CALCULATOR 2")
Beep 8000, 100
Command2.Visible = True
End If
End Sub

Private Sub Timer1_Timer()
If ProgressBar1.Value = 100 Then
ProgressBar1.Value = 0
Else
ProgressBar1.Value = Val(ProgressBar1.Value) + Val(1)
End If
Label4.Caption = ProgressBar1.Value
End Sub
