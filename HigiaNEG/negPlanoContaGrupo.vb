﻿Imports HigiaBCO
Imports HigiaENT

Public Class negPlanoConta

    Public Function Incluir(ByVal obj As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoConta
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoConta
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoConta
        Return db.Excluir(obj, myConnection)
    End Function


End Class
