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
    Private _nOrphans As Integer

    'Constructor
    Public Sub New()
        MyBase.New
    End Sub

    'Property Methods
    Public Property nOrphans As Integer
        Get
            Return _nOrphans
        End Get
        Set(value As Integer)
            _nOrphans = value
        End Set
    End Property

End Class