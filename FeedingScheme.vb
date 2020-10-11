' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: FeedingScheme
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off
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
        Return MyBase.CalculateFunds - CostOfFood - Expense
    End Function
    Public Overrides Function Display() As String
        Return " Feeding scheme/" & MyBase.Display()
    End Function

End Class
