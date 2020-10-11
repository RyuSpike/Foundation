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
Public Class Educational
    Inherits Foundation
    Private _NumOfLearners As Integer
    Private _Fees As Double

    'Constructor
    Public Sub New(Name As String, RegNum As String, Years As Integer)
        MyBase.New(Name, RegNum, Years)
    End Sub
    'Property Methods
    Public Property NumOfLearners As Integer
        Set(value As Integer)
            _NumOfLearners = value
        End Set
        Get
            Return _NumOfLearners
        End Get
    End Property
    Public WriteOnly Property Fees As Double
        Set(value As Double)
            _Fees = value
        End Set
    End Property
    'Methods
    Public Overrides Function CalculateFunds() As Double
        Return MyBase.CalculateFunds() - (_Fees * NumOfLearners) - Expense
    End Function

    Public Overrides Function Display() As String
        Return "Educational Foundation/" & MyBase.Display()
    End Function
End Class
