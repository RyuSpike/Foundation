' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maseko, N.A (217005670)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Orphanage
' *****************************************************************
Public Class Orphanage
    Inherits Foundation
    Private _nOrphans As Integer

    'Constructor
    Public Sub New(Name As String, RegNum As String, YearsActive As Integer)
        MyBase.New(Name, RegNum, YearsActive)
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
    'Method
    Public Overrides Function Display() As String
        Return Environment.NewLine & "Name: " & Name & Environment.NewLine & "Registration Number: " & Registration &
            Environment.NewLine & "Total Funds: " & CalculateFunds() & Environment.NewLine & "Funds Without Expenses: " & SubtractExpenses() & Environment.NewLine & "Number Of Orphans: " & _nOrphans
    End Function
End Class