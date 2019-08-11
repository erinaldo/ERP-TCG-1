Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RubroEEFFDetalle_CuentaContable

    Private sqlhelper As New SqlHelper
    Private d_DatosConfiguracion As New d_DatosConfiguracion

    Private Function Cargar(ByVal o_fila As DataRow) As e_RubroEEFFDetalle_CuentaContable
        Try
            Dim oeRubroEEFFDetalle_CuentaContable = New e_RubroEEFFDetalle_CuentaContable( _
                             o_fila("Id").ToString _
                             , o_fila("IdRubroEEFFDetalle").ToString _
                             , o_fila("Identificador").ToString _
                             , o_fila("NroCuenta").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeRubroEEFFDetalle_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As DataSet
        Try
            Dim ds As DataSet
            With oeRubroEEFFDetalle_CuentaContable
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_RubroEEFFDetalle_CuentaContable_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdRubroEEFFDetalle _
                        , .NroCuenta _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As e_RubroEEFFDetalle_CuentaContable
        Try
            Dim ds As DataSet = ExecuteLST(oeRubroEEFFDetalle_CuentaContable)
            If ds.Tables(0).rows.Count > 0 Then
                oeRubroEEFFDetalle_CuentaContable = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRubroEEFFDetalle_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As List(Of e_RubroEEFFDetalle_CuentaContable)
        Try
            Dim ldRubroEEFFDetalle_CuentaContable As New List(Of e_RubroEEFFDetalle_CuentaContable)
            Dim ds As DataSet = ExecuteLST(oeRubroEEFFDetalle_CuentaContable)
            oeRubroEEFFDetalle_CuentaContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRubroEEFFDetalle_CuentaContable = Cargar(o_Fila)
                    ldRubroEEFFDetalle_CuentaContable.Add(oeRubroEEFFDetalle_CuentaContable)
                Next
            End If
            Return ldRubroEEFFDetalle_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeRubroEEFFDetalle_CuentaContable
                stResultado = sqlhelper.ExecuteScalar("[CON].[Isp_RubroEEFFDetalle_CuentaContable_IAE]" _
                        , .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdRubroEEFFDetalle _
                        , .NroCuenta _
                        , .FechaCrea _
                        , .UsuarioCrea _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean
        Try
            With oeRubroEEFFDetalle_CuentaContable
                sqlhelper.ExecuteNonQuery("[CON].[Isp_RubroEEFFDetalle_CuentaContable_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdRubroEEFFDetalle _
                       , .NroCuenta _
                       , .FechaCrea _
                       , .UsuarioCrea _
                       , .FechaModifica _
                       , .UsuarioModifica _
                       , .Activo _
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
