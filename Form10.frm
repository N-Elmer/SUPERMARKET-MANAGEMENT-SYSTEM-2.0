VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{8E27C92E-1264-101C-8A2F-040224009C02}#7.0#0"; "MSCAL.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "msdatgrd.ocx"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.5#0"; "comctl32.ocx"
Begin VB.Form Form10 
   BackColor       =   &H00FFFF00&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "SAVE"
   ClientHeight    =   7185
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   15810
   LinkTopic       =   "Form10"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7185
   ScaleWidth      =   15810
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
      Left            =   7680
      Style           =   1  'Graphical
      TabIndex        =   37
      Top             =   2160
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.Timer Timer1 
      Left            =   15120
      Top             =   2760
   End
   Begin VB.TextBox Text7 
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
      Left            =   9240
      TabIndex        =   31
      Top             =   2760
      Width           =   1575
   End
   Begin VB.CommandButton Command5 
      BackColor       =   &H00FFFF00&
      Caption         =   "SEARCH A NAME"
      DownPicture     =   "Form10.frx":0000
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
      Left            =   7680
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   2760
      Width           =   1575
   End
   Begin VB.CommandButton Command4 
      BackColor       =   &H00FFFF00&
      Caption         =   "SAVE"
      DownPicture     =   "Form10.frx":11C3A
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
      Left            =   12360
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   3360
      Width           =   1575
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00FFFF00&
      Caption         =   "DELETE"
      DownPicture     =   "Form10.frx":23874
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
      Left            =   10800
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   3360
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00FFFF00&
      Caption         =   "MODIFY"
      DownPicture     =   "Form10.frx":354AE
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
      Left            =   9240
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   3360
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00FFFF00&
      Caption         =   "ADD"
      DownPicture     =   "Form10.frx":470E8
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
      Left            =   7680
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   3360
      Width           =   1575
   End
   Begin VB.Frame Frame13 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   12
      Top             =   6240
      Width           =   3135
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         DataField       =   "REMARK"
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
         TabIndex        =   25
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame12 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   11
      Top             =   6240
      Width           =   3135
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "REMARK"
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
         TabIndex        =   18
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame11 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   10
      Top             =   5280
      Width           =   3135
      Begin VB.TextBox Text5 
         Alignment       =   2  'Center
         DataField       =   "RECORD_DATE"
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "M/d/yyyy"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   3
         EndProperty
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
         TabIndex        =   24
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame10 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   9
      Top             =   5280
      Width           =   3135
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "RECORD_DATE"
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
         TabIndex        =   17
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame9 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   8
      Top             =   4320
      Width           =   3135
      Begin VB.TextBox Text4 
         Alignment       =   2  'Center
         DataField       =   "RECORD_TIME"
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "h:mm:ss AMPM"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   4
         EndProperty
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
         TabIndex        =   23
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame8 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   7
      Top             =   4320
      Width           =   3135
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "RECORD_TIME"
         BeginProperty DataFormat 
            Type            =   0
            Format          =   "h:mm:ss AMPM"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
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
         TabIndex        =   16
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame7 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   6
      Top             =   3360
      Width           =   3135
      Begin VB.TextBox Text3 
         Alignment       =   2  'Center
         DataField       =   "RECORD_QUANTITY"
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
         TabIndex        =   22
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame6 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   5
      Top             =   3360
      Width           =   3135
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "RECORD_QUANTITY"
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
         TabIndex        =   15
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame5 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   3360
      TabIndex        =   4
      Top             =   2400
      Width           =   3135
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
         DataField       =   "RECORD_NAME"
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
         TabIndex        =   21
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00808000&
      Height          =   735
      Left            =   120
      TabIndex        =   3
      Top             =   2400
      Width           =   3135
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "RECORD_NAME"
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
         TabIndex        =   14
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
         DataField       =   "RECORD_NUMBER"
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
         TabIndex        =   20
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
         Caption         =   "RECORD_NUMBER"
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
         TabIndex        =   13
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
      Width           =   7455
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "SAVE"
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
         TabIndex        =   19
         Top             =   240
         Width           =   7455
      End
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "Form10.frx":58D22
      Height          =   3015
      Left            =   7680
      TabIndex        =   35
      Top             =   3960
      Width           =   8055
      _ExtentX        =   14208
      _ExtentY        =   5318
      _Version        =   393216
      AllowUpdate     =   -1  'True
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
      Caption         =   "SAVE"
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
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   14520
      Top             =   3600
      Width           =   1215
      _ExtentX        =   2143
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
      RecordSource    =   "SAVE"
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
   Begin ComctlLib.ProgressBar ProgressBar1 
      Height          =   495
      Left            =   10920
      TabIndex        =   36
      Top             =   2760
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   873
      _Version        =   327682
      BorderStyle     =   1
      Appearance      =   0
   End
   Begin MSACAL.Calendar Calendar1 
      Height          =   2415
      Left            =   10920
      TabIndex        =   32
      Top             =   120
      Width           =   4815
      _Version        =   524288
      _ExtentX        =   8493
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
   Begin VB.Label Label9 
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
      Left            =   14640
      TabIndex        =   34
      Top             =   2760
      Width           =   375
   End
   Begin VB.Label Label8 
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
      Left            =   14040
      TabIndex        =   33
      Top             =   2760
      Width           =   615
   End
   Begin VB.Image Image1 
      Height          =   7200
      Left            =   0
      Picture         =   "Form10.frx":58D37
      Top             =   0
      Width           =   10845
   End
   Begin VB.Image Image2 
      Height          =   7200
      Left            =   9600
      Picture         =   "Form10.frx":6A971
      Top             =   0
      Width           =   10800
   End
End
Attribute VB_Name = "Form10"
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
With Adodc1.Recordset
Var = Text1.Text
End With
End If
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
Adodc1.RecordSource = "select * from SAVE where RECORD_NAME like '%" & (Text7.Text) & "%'"
Adodc1.CommandType = adCmdText
Adodc1.Refresh
End If
End Sub

Private Sub Label8_Change()
If Label8.Caption = 100 Then
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
Label8.Caption = ProgressBar1.Value
End Sub

