Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ReporteFlujoBanco
    Private sqlhelper As New SqlHelper
    Dim d_DatosConfiguracion As New d_DatosConfiguracion

    Private Function Cargar(ByVal o_fila As DataRow) As e_ReporteFlujoBanco
        Try
            Dim oeReporteFlujoBanco = New e_ReporteFlujoBanco(o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdMovCajaBanco").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("IdFlujoNuevo").ToString _
                             , o_fila("IngresoEgreso").ToString _
                             , o_fila("IndFinanciamiento").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeReporteFlujoBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReporteFlujoBanco As e_ReporteFlujoBanco) As List(Of e_ReporteFlujoBanco)
        Try
            Dim ldReporteFlujoBanco As New List(Of e_ReporteFlujoBanco)
            Dim ds As DataSet
            With oeReporteFlujoBanco
                ds = sqlhelper.ExecuteDataset("TES.Isp_ReporteFlujoBanco_Listar", .TipoOperacion, .IdPeriodo)
            End With
            oeReporteFlujoBanco = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeReporteFlujoBanco = Cargar(o_Fila)
                ldReporteFlujoBanco.Add(oeReporteFlujoBanco)
            Next
            Return ldReporteFlujoBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "TES.ReporteFlujoBanco", d_DatosConfiguracion.PrefijoID)
            Return IIf(stResultado Is Nothing, d_DatosConfiguracion.PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardaMasivo(DT As Data.DataTable) As Boolean
        Try
            If DT.Rows.Count > 0 Then sqlhelper.InsertarMasivo("TES.ReporteFlujoBanco", DT, False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeReporteFlujoBanco As e_ReporteFlujoBanco) As Boolean
        Try
            With oeReporteFlujoBanco
                sqlhelper.ExecuteNonQuery("[TES].[Isp_ReporteFlujoBanco_IAE]", .Id, .IdFlujoNuevo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarLista(ByVal leReporteFlujoBanco As List(Of e_ReporteFlujoBanco)) As Boolean
        Try
            For Each _oeRFB In leReporteFlujoBanco
                Guardar(_oeRFB)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
