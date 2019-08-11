Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_SeguroContraRiesgo
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_SeguroContraRiesgo
        Try
            Dim oeSeguroContraRiesgo = New e_SeguroContraRiesgo( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeSeguroContraRiesgo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As e_SeguroContraRiesgo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_SeguroContraRiesgo_Listar", "", oeSeguroContraRiesgo.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeSeguroContraRiesgo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSeguroContraRiesgo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As List(Of e_SeguroContraRiesgo)
        Try
            Dim ldSeguroContraRiesgo As New List(Of e_SeguroContraRiesgo)
            Dim ds As DataSet
            With oeSeguroContraRiesgo
                ds = sqlhelper.ExecuteDataset("PER.Isp_SeguroContraRiesgo_Listar", "" _
                        , .Id _
                        , .IdEmpresa _
                        , .Fecha _
                        , .FechaCreacion)
            End With
            oeSeguroContraRiesgo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSeguroContraRiesgo = Cargar(o_Fila)
                ldSeguroContraRiesgo.Add(oeSeguroContraRiesgo)
            Next
            Return ldSeguroContraRiesgo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeSeguroContraRiesgo
                sqlhelper.ExecuteNonQuery("PER.Isp_SeguroContraRiesgo_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdEmpresa _
                        , .Descripcion _
                        , .Fecha _
                        , .Importe _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_SeguroContraRiesgo_IAE", "E", _
             "", oeSeguroContraRiesgo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
