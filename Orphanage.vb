﻿' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Orphanage
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Orphanage
    Inherits Foundation
    Private _NumOrphans As Integer
    Private _CostPerchild As Double
    'Constructor
    Public Sub New(Name As String, RegNum As String, Years As Integer)
        MyBase.New(Name, RegNum, Years)

    End Sub

    'Property Methods
    Public Property NumOrphans As Integer
        Get
            Return _NumOrphans
        End Get
        Set(value As Integer)
            _NumOrphans = value
        End Set
    End Property
    'Methods
    Public Overrides Function CalculateFunds() As Double
        Return MyBase.CalculateFunds() - (_CostPerchild * _NumOrphans) - Expense
    End Function

    Public Overrides Function Display() As String
        Return "Orphanage/" & MyBase.Display()
    End Function

End Class