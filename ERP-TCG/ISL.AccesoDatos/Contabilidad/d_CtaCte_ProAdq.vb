Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CtaCte_ProAdq
    Dim d_DatosConfiguracion As New d_DatosConfiguracion
    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CtaCte_ProAdq
        Try
            Dim oeCtaCte_ProAdq = New e_CtaCte_ProAdq( _
                             o_fila("Id").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("IndClienteProveedor").ToString _
                             , o_fila("TipoEmpresa").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeCtaCte_ProAdq
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As DataSet
        Try
            Dim ds As DataSet
            With oeCtaCte_ProAdq
                ds = bd.ExecuteDataset("[CON].[Isp_CtaCte_ProAdq_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdClienteProveedor _
                        , .Cuenta)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As e_CtaCte_ProAdq
        Try
            Dim ds As DataSet = ExecuteLST(oeCtaCte_ProAdq)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCtaCte_ProAdq = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCtaCte_ProAdq = New e_CtaCte_ProAdq
            End If
            Return oeCtaCte_ProAdq
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As List(Of e_CtaCte_ProAdq)
        Try
            Dim ldCtaCte_ProAdq As New List(Of e_CtaCte_ProAdq)
            Dim ds As DataSet = ExecuteLST(oeCtaCte_ProAdq)
            oeCtaCte_ProAdq = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCtaCte_ProAdq = Cargar(o_Fila)
                    ldCtaCte_ProAdq.Add(oeCtaCte_ProAdq)
                Next
            End If
            Return ldCtaCte_ProAdq
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeCtaCte_ProAdq
                stResultado = bd.ExecuteScalar("[CON].[Isp_CtaCte_ProAdq_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID _
                        , .Id, .IdClienteProveedor, .Cuenta, .IndCliPro, .UsuarioCreacion).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean
        Try
            With oeCtaCte_ProAdq
                bd.ExecuteNonQuery("[CON].[Sp_CtaCte_ProAdq_IAE]" _
                       , "E" _
                       , "" _
                       , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
