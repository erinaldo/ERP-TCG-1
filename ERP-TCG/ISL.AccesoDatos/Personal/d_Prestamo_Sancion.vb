Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Prestamo_Sancion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Prestamo_Sancion
        Try
            Dim oePrestamo_Sancion = New e_Prestamo_Sancion( _
                             o_fila("Id").ToString _
                             , o_fila("IdSancion").ToString _
                             , o_fila("IdPrestamo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Tipo") _
            )
            Return oePrestamo_Sancion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamo_Sancion As e_Prestamo_Sancion) As e_Prestamo_Sancion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Prestamo_Sancion_Listar", "", oePrestamo_Sancion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oePrestamo_Sancion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePrestamo_Sancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamo_Sancion As e_Prestamo_Sancion) As List(Of e_Prestamo_Sancion)
        Try
            Dim ldPrestamo_Sancion As New List(Of e_Prestamo_Sancion)
            Dim ds As DataSet
            With oePrestamo_Sancion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Prestamo_Sancion_Listar", "" _
                        , .Id _
                        , .IdSancion _
                        , .IdPrestamo _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        )
            End With
            oePrestamo_Sancion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePrestamo_Sancion = Cargar(o_Fila)
                ldPrestamo_Sancion.Add(oePrestamo_Sancion)
            Next
            Return ldPrestamo_Sancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamo_Sancion As e_Prestamo_Sancion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oePrestamo_Sancion
                sqlhelper.ExecuteNonQuery("TES.Isp_Prestamo_Sancion_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdSancion _
                        , .IdPrestamo _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Tipo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePrestamo_Sancion As e_Prestamo_Sancion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Prestamo_Sancion_IAE", "E", _
             "", oePrestamo_Sancion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
