'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Public Class d_Caja
    Private sqlhelper As New SqlHelper
    Dim oeCajaUsuario As New e_CajaUsuario
    Dim odCajaUsuario As New d_CajaUsuario

    Private Function Cargar(ByVal o_fila As DataRow) As e_Caja
        Try
            Dim oeCaja = New e_Caja(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCentro") _
                             , o_fila("Centro") _
                             , o_fila("IndPrincipal"))
            Return oeCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCaja As e_Caja) As e_Caja
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Caja_Listar", "", oeCaja.Id, oeCaja.Nombre)
            oeCaja = New e_Caja

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCaja = Cargar(ds.Tables(0).Rows(0))
                oeCajaUsuario = New e_CajaUsuario
                oeCajaUsuario.IdCaja = oeCaja.Id
                oeCaja.leCajaUsuario = odCajaUsuario.Listar(oeCajaUsuario)
            End If

            Return oeCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCaja As e_Caja) As List(Of e_Caja)
        Try
            Dim ldCaja As New List(Of e_Caja)
            Dim ds As DataSet
            With oeCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_Caja_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Codigo _
                        , .Abreviatura _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IdCentro _
                        )
            End With
            oeCaja = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCaja = Cargar(o_Fila)
                    ldCaja.Add(oeCaja)
                Next
                Return ldCaja
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCaja As e_Caja) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope
                With oeCaja
                    id = sqlhelper.ExecuteScalar("TES.ISP_Caja_IAE", .Tipooperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Abreviatura _
                            , .UsuarioCreacion _
                            , .Activo _
                            , .IdCentro
                        )
                End With
                If oeCaja.leCajaUsuario IsNot Nothing Then
                    For Each oeCajaUsuario As e_CajaUsuario In oeCaja.leCajaUsuario
                        oeCajaUsuario.IdCaja = id
                        oeCajaUsuario.UsuarioCreacion = oeCaja.UsuarioCreacion
                        oeCajaUsuario.PrefijoID = oeCaja.PrefijoID '@0001
                        odCajaUsuario.Guardar(oeCajaUsuario)
                    Next
                End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCaja As e_Caja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.ISP_Caja_IAE", "E", _
             "", oeCaja.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal loCaja As List(Of e_Caja))
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Caja In loCaja
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            If ds.Rows.Count = 0 Then Throw New Exception("Información no registrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class