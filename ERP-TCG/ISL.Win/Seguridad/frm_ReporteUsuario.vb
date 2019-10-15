'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteUsuario
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteUsuario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteUsuario()
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Declaracion de Variables"


#End Region

#Region "Botones"


#End Region

#Region "Eventos"

#End Region

#Region "Metodos"


#End Region

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Click
        ''Para obtener el Id de Centro poblado
        'MessageBox.Show(Ccpp1.Id)
        ''Para inicializar el control CCPP (valores por defecto = CHICLAYO)
        'Ccpp1.Inicializar()

        ''Para obtener el valor del mes
        'MessageBox.Show(Meses1.Id)

    End Sub

    Private Sub frm_ReporteUsuario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'Para asignar y seleccionar un centro poblado específico
            'Ccpp1.Seleccionar("2007050007")

            ''Para inicializar la lista de meses en el mes actual
            'Meses1.Inicializar()

            'Para asignar y selecciona un mes específico
            'Meses1.Seleccionar(5)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

End Class