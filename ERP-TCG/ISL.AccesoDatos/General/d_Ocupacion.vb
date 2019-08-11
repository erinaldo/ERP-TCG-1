Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Ocupacion

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Ocupacion
        Try
            Dim oeOcupacion = New e_Ocupacion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("OcupacionSunat").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdAreaOrigen").ToString _
                             , o_fila("Area").ToString _
            )
            Return oeOcupacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal o_fila As DataRow) As e_Ocupacion
        Try
            Dim oeOcupacion = New e_Ocupacion( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdAreaOrigen").ToString _
                             , o_fila("Area").ToString _
                              , o_fila("IdUnidad").ToString _
                             , o_fila("Unidad").ToString _
                              , o_fila("IdGerencia").ToString _
                             , o_fila("Gerencia").ToString _
                             , o_fila("OcupacionSunat").ToString _
                              , o_fila("Codigo").ToString _
            )
            Return oeOcupacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOcupacion As e_Ocupacion) As e_Ocupacion

        Try
            Dim ds As DataSet
            With oeOcupacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Ocupacion_Listar", "", .Id, .IdArea, .Codigo, .Nombre)
            End With
            oeOcupacion = New e_Ocupacion
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOcupacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOcupacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOcupacion As e_Ocupacion) As List(Of e_Ocupacion)
        Try
            Dim ldOcupacion As New List(Of e_Ocupacion)
            Dim ds As DataSet
            With oeOcupacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Ocupacion_Listar", "" _
                        , .Id _
                        , .IdArea _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeOcupacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeOcupacion = Cargar(o_Fila)
                ldOcupacion.Add(oeOcupacion)
            Next
            Return ldOcupacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar2(ByVal oeOcupacion As e_Ocupacion) As List(Of e_Ocupacion)
        Try
            Dim ldOcupacion As New List(Of e_Ocupacion)
            Dim ds As DataSet
            With oeOcupacion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Ocupacion_Listar", "" _
                        , .Id _
                        , .IdArea _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeOcupacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeOcupacion = Cargar2(o_Fila)
                ldOcupacion.Add(oeOcupacion)
            Next
            Return ldOcupacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOcupacion As e_Ocupacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOcupacion
                sqlhelper.ExecuteNonQuery("STD.Isp_Ocupacion_IAE", .TipoOperacion, _
                        .Id _
                        , .IdUnidad _
                        , .Codigo _
                        , .Nombre _
                        , .OcupacionSunat _
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

    Public Function Eliminar(ByVal oeOcupacion As e_Ocupacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Ocupacion_IAE", "E", oeOcupacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
