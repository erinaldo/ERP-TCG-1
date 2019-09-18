Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PlanillaViaje

    Private sqlhelper As New SqlHelper
    Private odOperacion As New d_Operacion

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanillaViaje
        Try
            Dim oePlanillaViaje = New e_PlanillaViaje(o_fila("Id").ToString _
                             , o_fila("IdPlanillaPiloto").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("FechaViaje").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("MontoPiloto").ToString _
                             , o_fila("IdCopiloto").ToString _
                             , o_fila("Copiloto").ToString _
                             , o_fila("MontoCopiloto").ToString _
                             , o_fila("IdAyudante").ToString _
                             , o_fila("Ayudante").ToString _
                             , o_fila("MontoAyudante").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IndPago").ToString _
                             , o_fila("ViajeVacio").ToString _
                             , o_fila("BonoSolo").ToString _
                             , o_fila("BonoCruceroPiloto").ToString _
                             , o_fila("BonoCruceroCopiloto").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("MontoSolo").ToString _
                             , o_fila("MontoAcompañado").ToString _
                             , o_fila("PorcentajeCopiloto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("CuentaPiloto").ToString _
                             , o_fila("CuentaCoPiloto").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("ViajeRetorno").ToString)
            Return oePlanillaViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaViaje As e_PlanillaViaje) As List(Of e_PlanillaViaje)
        Try
            Dim ldPlanillaViaje As New List(Of e_PlanillaViaje)
            Dim ds As DataSet
            With oePlanillaViaje
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaViaje_Listar", .TipoOperacion, .FechaInicio, _
                                              .FechaFin, .IdPlanillaPiloto, .IdPiloto, .IdRuta)
            End With
            oePlanillaViaje = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanillaViaje = Cargar(o_Fila)
                ldPlanillaViaje.Add(oePlanillaViaje)
            Next
            Return ldPlanillaViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtPlanillaViaje As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim oeViaje As New e_Viaje
            oeViaje.Id = dtPlanillaViaje.Rows(0).Item("IdPlanillaPiloto").ToString
            sqlhelper.InsertarMasivo("PER.PlanillaViaje", dtPlanillaViaje)
            'odOperacion.ActualizaLista(oeViaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.PlanillaViaje", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
