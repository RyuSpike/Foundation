Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO
Public Class Form1
    Private nfoundation() As Foundation
    Private nf As Integer

    Enum foundationtype
        OldAge = 1
        feedingscheme = 2
        orphanage = 3
    End Enum
    Private Sub btnINITIALIZE_Click(sender As Object, e As EventArgs) Handles btnINITIALIZE.Click
        'This is the Initialise Method
        nf = CInt(InputBox("How many Foundations ?", "Number of Foundations"))
        ReDim nfoundation(nf)
    End Sub
    Private Sub btnINPUT_Click(sender As Object, e As EventArgs) Handles btnINPUT.Click
        ' The user Inputs specific information for each foundation
        Dim F As Integer
        For F = 1 To nf
            Dim Name As String
            Dim Registration_Number As String
            Dim nYears As Integer
            Name = InputBox("What is the Name of Foundation " & CStr(F) & " ?", "Enter Name")
            Registration_Number = InputBox("What is the Registration Number of Foundation " & CStr(F) & " ?", "Enter Registration Number")
            nYears = CInt(InputBox("How many years has Foundation " & CStr(F) & " been running ?", "Enter number of Years"))
            'nfoundation(F) = New Foundation(Name, Registration_Number, nYears)
            Dim choice As Integer = CInt(InputBox("Which Foundation are you evaluating ?" & Environment.NewLine & "1 - Old Age Foundation" & Environment.NewLine & "2 - Feeding Scheme Foundation" & Environment.NewLine & "3 - Orphanage Foundation", "Pick Option"))
            If choice = 1 Or choice = 2 Or choice = 3 Then
                Select Case choice
                    Case foundationtype.OldAge
                        Dim objOldAge As OldAge
                        objOldAge = New OldAge(Name, Registration_Number, nYears)
                        nfoundation(F) = objOldAge 'Upcasting
                        YearsFunds(F, nYears)
                        objOldAge.nPensioners = CInt(InputBox("How many Pensioners are in the Old Age Home ?", "Enter Number Of Pensioners"))



                    Case foundationtype.feedingscheme
                        Dim objFeedingScheme As FeedingScheme
                        objFeedingScheme = New FeedingScheme(Name, Registration_Number, nYears)
                        nfoundation(F) = objFeedingScheme 'Upcasting
                        YearsFunds(F, nYears)
                        objFeedingScheme.CostOfFood = CDbl(InputBox("How much did the Food cost ?", "Enter Cost Of Food"))



                    Case foundationtype.orphanage
                        Dim objOrphanage As Orphanage
                        objOrphanage = New Orphanage(Name, Registration_Number, nYears)
                        nfoundation(F) = objOrphanage 'Upcasting
                        YearsFunds(F, nYears)
                        objOrphanage.nOrphans = CInt(InputBox("How Many orphans are in Foundation " & CStr(F) & " ?", "Enter Number Of Orphans"))


                End Select
            Else
                MsgBox("The Value You Inputed is not part of the Options")
                F -= 1 ' Gives the user a retry to Pick the Foundation again
            End If
        Next F
    End Sub
    Private Sub YearsFunds(F As Integer, nYears As Integer)
        'Utility Method, Goes through each year to check how much was raised each Year
        For Y As Integer = 1 To nYears
            nfoundation(F).YearsActive(Y) = CDbl(InputBox("How much was raised during Year " & CStr(Y) & " for Foundation " & CStr(F) & " ?", "How Much Was Raised ?"))
        Next Y
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim F As Integer
        For F = 1 To nf
            txtDisplay.Text &= nfoundation(F).Display
        Next F
    End Sub
End Class