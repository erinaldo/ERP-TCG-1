'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_MaterialAlmacenRequerimiento
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion del Formulario"
    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_MaterialAlmacenRequerimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeMaterialAlmacen As New e_MaterialAlmacen
    Private olMaterialAlmacen As New l_MaterialAlmacen
    Private Shared instancia As frm_MaterialAlmacenRequerimiento = Nothing

#End Region

    Public Sub Inicializar()
        oeMaterialAlmacen = New e_MaterialAlmacen
        Me.txtMaterial.Text = String.Empty
        Me.numStockMaximo.Value = 0
        Me.numStockMinimo.Value = 0
    End Sub

    Public Sub MaterialAlmacenRequerimiento(IdMaterial As String, IdAlmacen As String, Material As String, Almacen As String)
        Try
            Inicializar()
            Me.txtMaterial.Text = Material
            oeMaterialAlmacen.IdMaterial = IdMaterial
            oeMaterialAlmacen.IdAlmacen = IdAlmacen
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnGuardarMatAlm_Click(sender As Object, e As EventArgs) Handles btnGuardarMatAlm.Click
        Try
            oeMaterialAlmacen.TipoOperacion = "I"
            oeMaterialAlmacen.StockMaximo = numStockMaximo.Value
            oeMaterialAlmacen.StockMinimo = numStockMinimo.Value
            oeMaterialAlmacen.UsuarioCreacion = gUsuarioSGI.Id
            oeMaterialAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMaterialAlmacen.Guardar1(oeMaterialAlmacen) Then
                ActualizarListaPublica("MATERIAL ALMACEN")
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

End Class