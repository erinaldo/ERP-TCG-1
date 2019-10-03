Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que permite el acceso a datos de la tabla DireccionEmpresaPersona
''' </summary>
''' <remarks></remarks>
Public Class d_Direccion_EmpresaPersona

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Direccion_EmpresaPersona
        Try
            Dim oeDireccion_EmpresaPersona = New e_Direccion_EmpresaPersona( _
                             o_fila("Id").ToString _
                             , o_fila("IdDireccion").ToString _
                             , o_fila("IdTipoVia").ToString _
                             , o_fila("TipoVia").ToString _
                             , o_fila("Via").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Departamento").ToString _
                             , o_fila("NumeroInterior").ToString _
                             , o_fila("Manzana").ToString _
                             , o_fila("Lote").ToString _
                             , o_fila("Kilometro").ToString _
                             , o_fila("Block").ToString _
                             , o_fila("Etapa").ToString _
                             , o_fila("IdTipoZona").ToString _
                             , o_fila("TipoZona").ToString _
                             , o_fila("Zona").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("CCPP").ToString _
                             , o_fila("NOMBREDD") & " - " & o_fila("NOMBREPP") & " - " & o_fila("NOMBREDI") & " - " & o_fila("NOMBCCPP") _
                             , o_fila("NOMBREDD").ToString _
                             , o_fila("NOMBREPP").ToString _
                             , o_fila("NOMBREDI").ToString _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("Principal") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
                             , o_fila("IdLugar").ToString _
                             , o_fila("Lugar").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("CentroAsistenciaEsSalud"))
            Return oeDireccion_EmpresaPersona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As e_Direccion_EmpresaPersona

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Direccion_EmpresaPersona_Listar", "", _
                                          oeDireccion_EmpresaPersona.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDireccion_EmpresaPersona = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDireccion_EmpresaPersona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As List(Of e_Direccion_EmpresaPersona)
        Try
            Dim ldDireccion_EmpresaPersona As New List(Of e_Direccion_EmpresaPersona)
            Dim ds As DataSet
            With oeDireccion_EmpresaPersona
                ds = sqlhelper.ExecuteDataset("STD.Isp_Direccion_EmpresaPersona_Listar", .TipoOperacion _
                                                , .Id _
                                                , .oeDireccion.Id _
                                                , .TipoPersonaEmpresa _
                                                , .IdPersonaEmpresa _
                                                , .Principal _
                                                , .UsuarioCreacion _
                                                , .Activo _
                                                , .oeDireccion.NombreCCPP)
            End With
            oeDireccion_EmpresaPersona = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDireccion_EmpresaPersona = Cargar(o_Fila)
                    ldDireccion_EmpresaPersona.Add(oeDireccion_EmpresaPersona)
                Next
            Else
                ldDireccion_EmpresaPersona = New List(Of e_Direccion_EmpresaPersona)
            End If

            Return ldDireccion_EmpresaPersona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As List(Of e_Direccion_EmpresaPersona)
        Try
            Dim ldDireccion_EmpresaPersona As New List(Of e_Direccion_EmpresaPersona)
            Dim ds As DataSet
            With oeDireccion_EmpresaPersona
                ds = sqlhelper.ExecuteDataset("STD.Isp_Direccion_EmpresaPersona_Listar", "" _
                                                , .Id _
                                                , .oeDireccion.Id _
                                                , .TipoPersonaEmpresa _
                                                , .IdPersonaEmpresa _
                                                , .Principal _
                                                , .UsuarioCreacion)
            End With
            oeDireccion_EmpresaPersona = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDireccion_EmpresaPersona = Cargar(o_Fila)
                ldDireccion_EmpresaPersona.Add(oeDireccion_EmpresaPersona)
            Next
            Return ldDireccion_EmpresaPersona
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDireccion_EmpresaPersona
                sqlhelper.ExecuteNonQuery("STD.Isp_Direccion_EmpresaPersona_IAE", .TipoOperacion, _
                        .Id _
                        , .oeDireccion.Id _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .Principal _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Direccion_EmpresaPersona_IAE", "E", oeDireccion_EmpresaPersona.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
