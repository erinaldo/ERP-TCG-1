Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CajaTurno
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CajaTurno
        Try
            Dim oeCajaTurno = New e_CajaTurno( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdCajaUsuario").ToString _
                             , o_Fila("FechaHoraIngreso").ToString _
                             , o_Fila("MontoIngreso").ToString _
                             , o_Fila("FechaHoraSalida").ToString _
                             , o_Fila("MontoSalida").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeCajaTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaTurno As e_CajaTurno) As e_CajaTurno

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeCajaTurno.Id)
            If ds.Tables.Count > 0 Then
                oeCajaTurno = Cargar(ds.Tables(0).Rows(0))
                Return oeCajaTurno
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCajaTurno As e_CajaTurno) As List(Of e_CajaTurno)
        Try
            Dim ldCajaTurno As New List(Of e_CajaTurno)
            Dim ds As DataSet
            With oeCajaTurno
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdCajaUsuario _
                        , .FechaHoraIngreso _
                        , .MontoIngreso _
                        , .FechaHoraSalida _
                        , .MontoSalida _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeCajaTurno = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCajaTurno = Cargar(o_Fila)
                    ldCajaTurno.Add(oeCajaTurno)
                Next
                Return ldCajaTurno
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaTurno As e_CajaTurno) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCajaTurno
                SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCajaUsuario _
                        , .FechaHoraIngreso _
                        , .MontoIngreso _
                        , .FechaHoraSalida _
                        , .MontoSalida _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCajaTurno As e_CajaTurno) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeCajaTurno.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class