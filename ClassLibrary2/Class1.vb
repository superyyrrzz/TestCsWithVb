Imports TestNamespace

Partial Public Class DemoSearchForm
    Implements IFormTest

    Public Function BeforeClick(ClickedControl As Integer) As Boolean Implements IFormTest.BeforeClick
        Return True
    End Function
End Class
