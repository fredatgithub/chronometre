﻿'
'The MIT License(MIT)
'Copyright(c) 2021-2024 Freddy Juhel
'Permission is hereby granted, free of charge, to any person obtaining a copy
'of this software and associated documentation files (the "Software"), to deal
'in the Software without restriction, including without limitation the rights
'to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
'copies of the Software, and to permit persons to whom the Software is
'furnished to do so, subject to the following conditions:
'The above copyright notice and this permission notice shall be included in all
'copies or substantial portions of the Software.
'THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
'IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
'FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
'AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
'LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
'OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
'SOFTWARE.

Imports System.Reflection

Public Class FormMain
  Dim _chronoStarted As Boolean = False
  Dim _startTime As New Date
  Dim _endTime As New Date
  Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
    LabelCompteur.Text = "00:00:00:0000000"
  End Sub

  Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
    If _chronoStarted Then
      _chronoStarted = False
      ButtonReset.Enabled = True
      If FrenchToolStripMenuItem.Checked Then
        ButtonStart.Text = "Commence"
      Else
        ButtonStart.Text = "Start"
      End If
    Else
      _chronoStarted = True
      _startTime = Now
      ButtonReset.Enabled = False
      If FrenchToolStripMenuItem.Checked Then
        ButtonStart.Text = "Arrête"
      Else
        ButtonStart.Text = "Stop"
      End If
    End If
  End Sub

  Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    _chronoStarted = False
    TimerChrono.Enabled = True
    TimerChrono.Interval = 1
    LabelCompteur.Text = "00:00:00:0000000"
    _startTime = Now
    _endTime = Now
    GetWindowValue()
    Text += DisplayTitle()
  End Sub

  Private Function DisplayTitle() As String
    Dim myAssembly As Assembly = Assembly.GetExecutingAssembly()
    Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(myAssembly.Location)
    Dim displayTitle2 As String = String.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart)
    Return displayTitle2
  End Function

  Private Sub GetWindowValue()
    Width = My.Settings.WindowWidth
    Height = My.Settings.WindowHeight
    If My.Settings.WindowTop < 0 Then
      Top = 0
    Else
      Top = My.Settings.WindowTop
    End If
    If My.Settings.WindowLeft < 0 Then
      Left = 0
    Else
      Left = My.Settings.WindowLeft
    End If
  End Sub

  Private Sub AproposdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
    AboutBox1.ShowDialog()
  End Sub

  Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
    LabelCompteur.Text = "00:00:00:0000000"
  End Sub

  Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
    Application.Exit()
  End Sub

  Private Sub SourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SourceToolStripMenuItem.Click
    DialogViewSource.Show()
  End Sub

  Private Sub TimerChrono_Tick(sender As Object, e As EventArgs) Handles TimerChrono.Tick
    If _chronoStarted Then
      _endTime = Now
      LabelCompteur.Text = (_endTime - _startTime).ToString
      LabelCompteur.Refresh()
    End If
  End Sub

  Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
    FrenchToolStripMenuItem.Checked = True
    EnglishToolStripMenuItem.Checked = False
    FileToolStripMenuItem.Text = "Fichier"
    ResetToolStripMenuItem.Text = "Mise à zéro"
    QuitToolStripMenuItem.Text = "Quitter"
    DisplayToolStripMenuItem.Text = "Afficher"
    SourceToolStripMenuItem.Text = "Source"
    LanguageToolStripMenuItem.Text = "Langue"
    FrenchToolStripMenuItem.Text = "Français"
    EnglishToolStripMenuItem.Text = "Anglais"
    HelpToolStripMenuItem.Text = "Aide"
    AboutToolStripMenuItem.Text = "A propos de"
    ButtonStart.Text = "Commence"
    ButtonReset.Text = "Mise à zéro"
  End Sub

  Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
    FrenchToolStripMenuItem.Checked = False
    EnglishToolStripMenuItem.Checked = True
    FileToolStripMenuItem.Text = "File"
    ResetToolStripMenuItem.Text = "Reset"
    QuitToolStripMenuItem.Text = "Quit"
    DisplayToolStripMenuItem.Text = "Display"
    SourceToolStripMenuItem.Text = "Source"
    LanguageToolStripMenuItem.Text = "Language"
    FrenchToolStripMenuItem.Text = "French"
    EnglishToolStripMenuItem.Text = "English"
    HelpToolStripMenuItem.Text = "Help"
    AboutToolStripMenuItem.Text = "About"
    ButtonStart.Text = "Start"
    ButtonReset.Text = "Reset"
  End Sub

  Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    SaveWindowValue()
  End Sub

  Private Sub SaveWindowValue()
    My.Settings.WindowHeight = Height
    My.Settings.WindowWidth = Width
    My.Settings.WindowLeft = Left
    My.Settings.WindowTop = Top
    My.Settings.Save()
  End Sub
End Class
