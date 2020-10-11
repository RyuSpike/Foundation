' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: FeedingScheme
' *****************************************************************
Public Class FeedingScheme
    Inherits Foundation
    Private _CostOfFood As Double
    'Constructor
    Public Sub New(Name As String, RegNum As String, YearsActive As Integer)
        MyBase.New(Name, RegNum, YearsActive)
    End Sub

    'Property Method
    Public Property CostOfFood As Double
        Get
            Return _CostOfFood
        End Get
        Set(value As Double)
            _CostOfFood = value
        End Set
    End Property

    'Methods
    Public Overrides Function CalculateFunds() As Double
        Dim answer As Double
        Return answer
    End Function
    Public Overrides Function Display() As String
        Return Environment.NewLine & "Name: " & Name & Environment.NewLine & "Registration Number: " & Registration &
            Environment.NewLine & "Total Funds: " & CalculateFunds() & Environment.NewLine & "Total Funds With Expenses: " & SubtractExpenses() & Environment.NewLine & "Cost Of Food: " & _CostOfFood
    End Function
End Class
