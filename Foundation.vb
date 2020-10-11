' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Foundation
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Foundation
    Private _Name As String
    Private _RegistrationNum As String
    Private _TotalFunds As Double
    Private _YearsActive() As Double
    Private _Expenses As Double
    Private _NumYears As Integer
    'Constructor
    Public Sub New(Name As String, RegNum As String, YearsActive As Integer)
        _Name = Name
        _RegistrationNum = RegNum
        _NumYears = YearsActive
        ReDim _YearsActive(YearsActive)
    End Sub
    'Utility Method
    Public Sub Validate(value As Double)
        'Ensures that every negative number is equal to Zero
        If value < 0 Then
            value = 0
        End If
    End Sub
    'Property Methods
    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property
    Public ReadOnly Property Registration As String
        Get
            Return _RegistrationNum
        End Get
    End Property
    Public Property YearsActive(index As Integer) As Double
        Get
            Return YearsActive(index)
        End Get
        Set(value As Double)
            _YearsActive(index) = value
        End Set
    End Property
    Public Property Expense As Double
        Get
            Return _Expenses
        End Get
        Set(value As Double)
            _Expenses = value
        End Set
    End Property

    Public ReadOnly Property NumYears As Integer
        Get
            Return _NumYears
        End Get

    End Property

    'Methods
    Public Overridable Function CalculateFunds() As Double
        _TotalFunds = 0
        For index As Integer = 1 To _NumYears
            _TotalFunds += YearsActive(index)
        Next index
        Return _TotalFunds
    End Function

    Public Function Display() As String

        Return "Name: " & _Name & "/Registration Number: " & _RegistrationNum &
            "/Total Funds: " & _TotalFunds
    End Function
End Class