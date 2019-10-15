'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Denominacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Denominacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Denominacion
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"
    Dim WithEvents oeMontoCaja As New e_MontoCaja
    Dim olMontoCaja As New l_MontoCaja
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        MyBase.Consultar(Activo)
    End Sub

    Public Overrides Sub Nuevo()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub

    Public Overrides Sub Cancelar()
        MyBase.Cancelar()
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griDenominacion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDenominacion)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Denominacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficDenominacion)

    End Sub

#End Region

#Region "Metodos"

#End Region

End Class