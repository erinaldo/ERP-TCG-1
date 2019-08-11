Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CaracteristicaEspecial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CaracteristicaEspecial
        Try
            Dim oeCaracteristicaEspecial = New e_CaracteristicaEspecial( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeCaracteristicaEspecial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As e_CaracteristicaEspecial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_CaracteristicaEspecial_Listar", "", oeCaracteristicaEspecial.Id)
            If ds.Tables.Count > 0 Then
                oeCaracteristicaEspecial = Cargar(ds.Tables(0).Rows(0))
                Return oeCaracteristicaEspecial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As List(Of e_CaracteristicaEspecial)
        Try
            Dim ldCaracteristicaEspecial As New List(Of e_CaracteristicaEspecial)
            Dim ds As DataSet
            With oeCaracteristicaEspecial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_CaracteristicaEspecial_Listar", "", .Id)
            End With
            oeCaracteristicaEspecial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCaracteristicaEspecial = Cargar(o_Fila)
                    ldCaracteristicaEspecial.Add(oeCaracteristicaEspecial)
                Next
                Return ldCaracteristicaEspecial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCaracteristicaEspecial
                sqlhelper.ExecuteNonQuery("ALM.Isp_CaracteristicaEspecial_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Abreviatura _
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

    Public Function Eliminar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_CaracteristicaEspecial_IAE", "E", _
             "", oeCaracteristicaEspecial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
