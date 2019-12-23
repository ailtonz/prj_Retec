Public Class entContrato

    Private _DATA_INICIO As String

    Private _PERIODO_LOCACAO As UInteger
    Private _FORMA_PAGAMENTO As String
    Private _FATURAMENTO_DIAS As String
    Private _RETIRADA_AUTOMATICA As UInteger
    Private _VCTO_APOS_ENTREGA As UInteger

    Private _MULTA_MORA As Decimal
    Private _MULTA_DIA As Decimal
    Private _VALOR_UNITARIO As Decimal

    Private _MATERIAL As Integer

    Private _NFE As UInteger
    Private _ISS As UInteger
    Private _CTR As UInteger

    Private _COLOCA As UInteger
    Private _TROCA As UInteger
    Private _RETIRA As UInteger

    Private _PRECO_TIPO As UInteger

    Public Property DataInicio() As String

        Get
            Return _DATA_INICIO
        End Get

        Set(ByVal value As String)
            _DATA_INICIO = value
        End Set

    End Property

    Public Property PrecoTipo() As UInteger

        Get
            Return _PRECO_TIPO
        End Get

        Set(ByVal value As UInteger)
            _PRECO_TIPO = value
        End Set

    End Property

    Public Property Retira() As UInteger

        Get
            Return _RETIRA
        End Get

        Set(ByVal value As UInteger)
            _RETIRA = value
        End Set

    End Property

    Public Property Troca() As UInteger

        Get
            Return _TROCA
        End Get

        Set(ByVal value As UInteger)
            _TROCA = value
        End Set

    End Property

    Public Property Coloca() As UInteger

        Get
            Return _COLOCA
        End Get

        Set(ByVal value As UInteger)
            _COLOCA = value
        End Set

    End Property
    Public Property ctr() As UInteger

        Get
            Return _CTR
        End Get

        Set(ByVal value As UInteger)
            _CTR = value
        End Set

    End Property

    Public Property iss() As UInteger

        Get
            Return _ISS
        End Get

        Set(ByVal value As UInteger)
            _ISS = value
        End Set

    End Property

    Public Property nfe() As UInteger

        Get
            Return _NFE
        End Get

        Set(ByVal value As UInteger)
            _NFE = value
        End Set

    End Property

    Public Property Material() As Integer

        Get
            Return _MATERIAL
        End Get

        Set(ByVal value As Integer)
            _MATERIAL = value
        End Set

    End Property

    Public Property ValorUnitario() As String

        Get
            Return _VALOR_UNITARIO
        End Get

        Set(ByVal value As String)
            _VALOR_UNITARIO = value
        End Set

    End Property

    Public Property MultaDia() As String

        Get
            Return _MULTA_DIA
        End Get

        Set(ByVal value As String)
            _MULTA_DIA = value
        End Set

    End Property

    Public Property MultaMora() As String

        Get
            Return _MULTA_MORA
        End Get

        Set(ByVal value As String)
            _MULTA_MORA = value
        End Set

    End Property

    Public Property VencimentoAposEntrega() As UInteger

        Get
            Return _VCTO_APOS_ENTREGA
        End Get

        Set(ByVal value As UInteger)
            _VCTO_APOS_ENTREGA = value
        End Set

    End Property

    Public Property RetiradaAutomatica() As UInteger

        Get
            Return _RETIRADA_AUTOMATICA
        End Get

        Set(ByVal value As UInteger)
            _RETIRADA_AUTOMATICA = value
        End Set

    End Property

    Public Property FaturamentoDias() As String

        Get
            Return _FATURAMENTO_DIAS
        End Get

        Set(ByVal value As String)
            _FATURAMENTO_DIAS = value
        End Set

    End Property

    Public Property FormaDePagamento() As String

        Get
            Return _FORMA_PAGAMENTO
        End Get

        Set(ByVal value As String)
            _FORMA_PAGAMENTO = value
        End Set

    End Property


    Public Property PeriodoLocacao() As UInteger

        Get
            Return _PERIODO_LOCACAO
        End Get

        Set(ByVal value As UInteger)
            _PERIODO_LOCACAO = value
        End Set

    End Property

End Class
