'
'The MIT License(MIT)
'Copyright(c) 2015 Freddy Juhel
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
Public Class FormMain

    Dim _chronoStarted As Boolean = False
    Dim _tempsDepart As New Date
    Dim _tempsFin As New Date
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        LabelCompteur.Text = "00:00:00:0000000"
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If _chronoStarted Then
            _chronoStarted = False
            ButtonStart.Text = "Start"
            ButtonReset.Enabled = True
        Else
            _chronoStarted = True
            ButtonStart.Text = "Stop"
            _tempsDepart = Now
            ButtonReset.Enabled = False
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _chronoStarted = False
        TimerChrono.Enabled = True
        TimerChrono.Interval = 1
        LabelCompteur.Text = "00:00:00:0000000"
        _tempsDepart = Now
        _tempsFin = Now
    End Sub

    Private Shared Sub AproposdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀproposdeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        LabelCompteur.Text = "00:00:00:0000000"
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Shared Sub SourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SourceToolStripMenuItem.Click
        DialogViewSource.Show()
    End Sub

    Private Sub TimerChrono_Tick(sender As Object, e As EventArgs) Handles TimerChrono.Tick
        If _chronoStarted Then
            _tempsFin = Now
            LabelCompteur.Text = (_tempsFin - _tempsDepart).ToString
            LabelCompteur.Refresh()
        End If
    End Sub
End Class