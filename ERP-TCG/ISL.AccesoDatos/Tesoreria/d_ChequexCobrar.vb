Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ChequexCobrar
    Private sqlhelper As New SqlHelper
    Public strIdCheque As String = ""

    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequexCobrar
        Try
            Dim oeChequexCobrar = New e_ChequexCobrar( _
                             o_fila("Id").ToString _
                             , o_fila("IdBanco").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("NroCheque").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Monto") _
                             , o_fila("Saldo") _
                             , o_fila("Cobrado").ToString _
                             , o_fila("FechaCobro").ToString _
                             , o_fila("IdTrabajadorCobro").ToString _
                             , o_fila("NombreCompleto").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Asociado") _
                             , o_fila("TipoTransa") _
            )
            Return oeChequexCobrar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeChequexCobrar As e_ChequexCobrar) As e_ChequexCobrar

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ChequexCobrar_Listar", "", oeChequexCobrar.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeChequexCobrar = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeChequexCobrar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeChequexCobrar As e_ChequexCobrar) As List(Of e_ChequexCobrar)
        Try
            Dim ldChequexCobrar As New List(Of e_ChequexCobrar)
            Dim ds As DataSet
            With oeChequexCobrar
                ds = sqlhelper.ExecuteDataset("TES.Isp_ChequexCobrar_Listar", .TipoOperacion _
                        , .Id _
                        , .IdBanco _
                        , .NroCheque _
                        , .Fecha _
                        , .IdMoneda _
                        , .Monto _
                        , .Cobrado _
                        , .FechaCobro _
                        , .IdTrabajadorCobro _
                        , .IdCuentaCorriente _
                        , .Asociado _
                        , .TipoTransa _
                        , .Activo _
                        )
            End With
            oeChequexCobrar = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeChequexCobrar = Cargar(o_Fila)
                ldChequexCobrar.Add(oeChequexCobrar)
            Next
            Return ldChequexCobrar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeChequexCobrar
                strIdCheque = sqlhelper.ExecuteScalar("TES.Isp_ChequexCobrar_IAE" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdBanco _
                        , .NroCheque _
                        , .Fecha _
                        , .IdMoneda _
                        , .Monto _
                        , .Saldo _
                        , .Cobrado _
                        , .FechaCobro _
                        , .IdTrabajadorCobro _
                        , .IdCuentaCorriente _
                        , .Asociado _
                        , .UsuarioCreacion _
                        , .TipoTransa _
                        , .Activo _
                        , .PrefijoID _
                        , .IdCuentaBancaria)
                .Id = strIdCheque
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ChequexCobrar_IAE", "E", oeChequexCobrar.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
