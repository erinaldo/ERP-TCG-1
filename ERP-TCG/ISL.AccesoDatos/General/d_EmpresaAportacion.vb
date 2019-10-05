'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_EmpresaAportacion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_EmpresaAportacion
        Try
            Dim oeEmpresaAportacion = New e_EmpresaAportacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("IdEmpresaPensiones").ToString _
                             , o_fila("IndSistemaPension").ToString _
                             , o_fila("IndComisionAFP").ToString _
                             , o_fila("FechaNacimiento").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeEmpresaAportacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As e_EmpresaAportacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_EmpresaAportacion_Listar]", "", oeEmpresaAportacion.Id, oeEmpresaAportacion.IdEmpresa)
            oeEmpresaAportacion = New e_EmpresaAportacion
            If ds.Tables(0).Rows.Count > 0 Then
                oeEmpresaAportacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmpresaAportacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As Boolean
        Try
            With oeEmpresaAportacion
                sqlhelper.ExecuteNonQuery("[STD].[Isp_EmpresaAportacion_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdEmpresa _
                        , .IdEmpresaPensiones _
                        , .IndSistemaPension _
                        , .IndComisionAFP _
                        , .FechaNacimiento _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
