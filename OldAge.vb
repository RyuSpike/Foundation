' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: OldAge
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class OldAge
    Inherits Foundation
    Private _nPensioners As Integer
    Private _Allowance As Double

    'Constructor
    Public Sub New(Name As String, RegNum As String, Years As Integer)
        MyBase.New(Name, RegNum, Years)
    End Sub

    'Property Methods
    Public Property nPensiners As Integer
        Get
            Return _nPensioners
        End Get
        Set(value As Integer)
            _nPensioners = value
        End Set
    End Property
    Public WriteOnly Property Allowance As Double
        Set(value As Double)
            _Allowance = value
        End Set
    End Property

    'Methods 
    Public Overrides Function CalculateFunds() As Double
        Return MyBase.CalculateFunds() - (_nPensioners * _Allowance) - Expense
    End Function

    Public Overrides Function Display() As String
        Return "Old Age Home/" & MyBase.Display()
    End Function

End Class
