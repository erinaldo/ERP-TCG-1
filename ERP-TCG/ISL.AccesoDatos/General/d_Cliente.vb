'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Cliente

    Private sqlhelper As New SqlHelper

    Private oeCliente As e_Cliente
    Private oePersona As New e_Persona
    Private odPersona As New d_Persona
    Private oeEmpresa As New e_Empresa
    Private odEmpresa As New d_Empresa


    Private Function Cargar(ByVal o_fila As DataRow) As e_Cliente
        Try
            Dim oeCliente = New e_Cliente( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("Nombre").ToString.Trim _
                             , o_fila("FechaActividad").ToString _
                             , o_fila("Comisionista").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("IndRelacionada").ToString _
            )
            Return oeCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeCliente As e_Cliente) As e_Cliente
        Try
            Dim ds As DataSet
            Dim TipoOperacion As String
            TipoOperacion = oeCliente.TipoOperacion
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Cliente_Listar]", _
                                            oeCliente.TipoOperacion, _
                                            oeCliente.Id, _
                                            oeCliente.Codigo, _
                                            oeCliente.TipoPersonaEmpresa, _
                                            oeCliente.Activo, _
                                            oeCliente.Comisionista, _
                                            oeCliente.Dni, _
                                            oeCliente.TipoClienteProveedor, _
                                            oeCliente.IdPersona)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCliente = Cargar(ds.Tables(0).Rows(0))
                If TipoOperacion <> "1" Then
                    If oeCliente.TipoPersonaEmpresa = 1 Then
                        oePersona = New e_Persona
                        oePersona.Id = oeCliente.IdPersona
                        oePersona = odPersona.Obtener(oePersona)
                        oeCliente.oePersona = oePersona
                    Else
                        oeEmpresa = New e_Empresa
                        oeEmpresa.Id = oeCliente.IdEmpresa
                        oeEmpresa = odEmpresa.Obtener(oeEmpresa)
                        oeCliente.oeEmpresa = oeEmpresa
                    End If
                End If
            Else
                oeCliente = New e_Cliente
            End If
            Return oeCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeCliente As e_Cliente) As List(Of e_Cliente)
        Try
            Dim ldCliente As New List(Of e_Cliente)
            Dim ds As DataSet
            With oeCliente
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Cliente_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .Activo _
                        , .Comisionista _
                        , .Dni _
                        , .TipoClienteProveedor _
                        , .IdPersona _
                        , .Nombre)
            End With

            oeCliente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCliente = Cargar(o_Fila)
                    ldCliente.Add(oeCliente)
                Next
            End If
            Return ldCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal Listacliente As List(Of e_Cliente))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Cliente In Listacliente
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function Guardar(ByVal oeCliente As e_Cliente) As Boolean
        Try
            Dim idPersonaEmpresa As String = ""
            With oeCliente
                If .TipoPersonaEmpresa = 1 Then
                    oeCliente.oePersona.Activo = oeCliente.Activo
                    oeCliente.oePersona.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odPersona.Guardar(oeCliente.oePersona)
                    oeCliente.IdPersona = idPersonaEmpresa
                Else
                    oeCliente.oeEmpresa.Activo = oeCliente.Activo
                    oeCliente.oeEmpresa.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odEmpresa.Guardar(oeCliente.oeEmpresa)
                    oeCliente.IdPersona = idPersonaEmpresa
                End If
                sqlhelper.ExecuteNonQuery("STD.Isp_Cliente_IAE", .TipoOperacion, _
                        .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .IdPersona _
                        , .FechaActividad _
                        , .Comisionista _
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

    Public Function GuardarClienteCom(ByVal oeCliente As e_Cliente) As Integer
        Try
            Dim codigo = 0
            Dim idPersonaEmpresa As String = ""
            With oeCliente
                If .TipoPersonaEmpresa = 1 Then
                    oeCliente.oePersona.Activo = oeCliente.Activo
                    oeCliente.oePersona.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odPersona.Guardar(oeCliente.oePersona)
                    oeCliente.IdPersona = idPersonaEmpresa
                Else
                    oeCliente.oeEmpresa.Activo = oeCliente.Activo
                    oeCliente.oeEmpresa.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odEmpresa.Guardar(oeCliente.oeEmpresa)
                    oeCliente.IdPersona = idPersonaEmpresa
                End If
                codigo = sqlhelper.ExecuteScalar("STD.Isp_Cliente_IAE", .TipoOperacion,
                        .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .IdPersona _
                        , .FechaActividad _
                        , .Comisionista _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return codigo
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeCliente As e_Cliente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Cliente_IAE", "E", oeCliente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

   
End Class
