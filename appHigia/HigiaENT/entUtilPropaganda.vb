﻿Public Class entUtilPropaganda

    Private _ENT_USUARIO As entUsuario

    Private _ID_PROPAGANDA As Integer

    Private _PROPAGANDA As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdPropaganda() As String
        Get
            Return _ID_PROPAGANDA
        End Get

        Set(ByVal value As String)
            _ID_PROPAGANDA = value
        End Set

    End Property

    Public Property Propaganda() As String
        Get
            Return _PROPAGANDA
        End Get

        Set(ByVal value As String)
            _PROPAGANDA = value
        End Set

    End Property

End Class
