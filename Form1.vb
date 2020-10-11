Option Strict On
Option Explicit On
Option Infer Off


Imports System.IO

Public Class Form1
    Private objFeedingScheme As FeedingScheme
    Private objOLDAGE As OldAge
    Private objOrphanage As Orphanage
    Private foundations() As Foundation
    Private NumFoundations As Integer


    Enum foundationtype As Integer
        OldAge
        feedingscheme
        orphanage
    End Enum
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDisplay_Click(sender As Object, e As EventArgs) Handles txtDisplay.Click

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

    End Sub
End Class
