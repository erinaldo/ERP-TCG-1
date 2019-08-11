Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PersonaEmpresa_TipoPago

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PersonaEmpresa_TipoPago
        Try
            Dim oePersonaEmpresa_TipoPago = New e_PersonaEmpresa_TipoPago( _
                             o_fila("Id").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("IndClienteProveedor").ToString _
                             , o_fila("IdTipoPago").ToString _
                             , o_fila("TipoPago").ToString _
                             , o_fila("Dias") _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oePersonaEmpresa_TipoPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As e_PersonaEmpresa_TipoPago
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_PersonaEmpresa_TipoPago_Listar", "", oePersonaEmpresa_TipoPago.Id)
            If ds.Tables.Count > 0 Then
                oePersonaEmpresa_TipoPago = Cargar(ds.Tables(0).Rows(0))
                Return oePersonaEmpresa_TipoPago
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As List(Of e_PersonaEmpresa_TipoPago)
        Try
            Dim ldPersonaEmpresa_TipoPago As New List(Of e_PersonaEmpresa_TipoPago)
            Dim ds As DataSet
            With oePersonaEmpresa_TipoPago
                ds = sqlhelper.ExecuteDataset("STD.Isp_PersonaEmpresa_TipoPago_Listar", "" _
                        , .Id _
                        , .IdClienteProveedor _
                        , .IndClienteProveedor _
                        , .IdTipoPago _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        )
            End With
            oePersonaEmpresa_TipoPago = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePersonaEmpresa_TipoPago = Cargar(o_Fila)
                    ldPersonaEmpresa_TipoPago.Add(oePersonaEmpresa_TipoPago)
                Next
                Return ldPersonaEmpresa_TipoPago
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oePersonaEmpresa_TipoPago
                sqlhelper.ExecuteNonQuery("STD.Isp_PersonaEmpresa_TipoPago_IAE", .TipoOperacion, _
                        .Id _
                        , .IdClienteProveedor _
                        , .IndClienteProveedor _
                        , .IdTipoPago _
                        , .Activo _
                        , .UsuarioCreacion _
                        , d_DatosConfiguracion.PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePersonaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_PersonaEmpresa_TipoPago_IAE", "E", oePersonaEmpresa_TipoPago.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
