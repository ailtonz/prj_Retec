Imports HigiaBCO
Imports HigiaENT

Public Class negCargo

    Public Function Incluir(ByVal obj As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCargo
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCargo
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCargo
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class
