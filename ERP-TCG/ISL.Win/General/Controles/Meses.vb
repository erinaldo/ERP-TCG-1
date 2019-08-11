''' <summary>
''' Control creado para obtener una lista de meses en un combo
''' </summary>
''' <remarks></remarks>
Public Class Meses

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idMes As String, ByVal NombreMes As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler
    Const textoDefecto As String = "Mes"

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del mes
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            cboMes.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del mes
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboMes.FindString(value)
            cboMes.SelectedIndex = index
        End Set
    End Property

    ''' <summary>
    ''' Personalizar el texto que se muestra en la etiqueta del control (Mes)
    ''' </summary>
    ''' <remarks></remarks>
    Private _texto As String = "Mes"
    Public Property Texto() As String
        Get
            Return _texto
        End Get
        Set(ByVal value As String)
            _texto = value
            Etiqueta.Text = value
        End Set
    End Property

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica un mes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.ReadOnly = False Then
            If Id <> cboMes.Value Or Id Is Nothing Then
                Id = cboMes.Value
                Nombre = cboMes.Text
                RaiseEvent DatosCambiados(Id, Nombre)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Inicializa el control en el mes actual
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Inicializar()
        cboMes.Value = Date.Now.Month
    End Sub

    ''' <summary>
    ''' Seleccionar un mes espefíco
    ''' </summary>
    ''' <param name="id">Número del mes</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As Integer)
        Try
            cboMes.Value = id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Restaurar texto por defecto del control (Mes)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Restaurar()
        Texto = textoDefecto
    End Sub

    Private Sub MostrarTexto()
        Etiqueta.Text = Texto
    End Sub

    Private Sub Meses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MostrarTexto()
    End Sub

#End Region

End Class
