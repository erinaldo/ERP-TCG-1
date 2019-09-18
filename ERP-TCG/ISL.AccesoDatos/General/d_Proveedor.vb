Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Proveedor

    Private sqlhelper As New SqlHelper
    Private oeProveedor As e_Proveedor
    Private oePersona As New e_Persona
    Private odPersona As New d_Persona
    Private oeEmpresa As New e_Empresa
    Private odEmpresa As New d_Empresa
    Private oeEmail As New e_Email
    Private odEmail As New d_Email

    Private Function Cargar(ByVal o_fila As DataRow) As e_Proveedor
        Try
            Dim oeProveedor = New e_Proveedor( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Dni") _
                             , o_fila("FechaActividad").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Email").ToString _
                             , o_fila("IdTipoEmpresa").ToString _
                             , o_fila("IndRelacionada").ToString _
            )
            Return oeProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProveedor As e_Proveedor) As e_Proveedor
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Proveedor_Listar]", oeProveedor.TipoOperacion, oeProveedor.Id, "", oeProveedor.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeProveedor = Cargar(ds.Tables(0).Rows(0))
                If oeProveedor.TipoPersonaEmpresa = 1 Then
                    oePersona = New e_Persona
                    oePersona.Id = oeProveedor.IdPersona
                    oePersona = odPersona.Obtener(oePersona)
                    oeProveedor.oePersona = oePersona
                    ' Cargar Emails
                    oeEmail = New e_Email
                    oeEmail.TipoOperacion = "1"
                    oeEmail.Principal = -1
                    oeEmail.TipoPersonaEmpresa = 1
                    oeEmail.IdPersonaEmpresa = oePersona.Id
                    oeProveedor.leEmail = odEmail.Listar(oeEmail)
                Else
                    oeEmpresa = New e_Empresa
                    oeEmpresa.Id = oeProveedor.IdEmpresa
                    oeEmpresa = odEmpresa.Obtener(oeEmpresa)
                    oeProveedor.oeEmpresa = oeEmpresa
                    ' Cargar Emails
                    oeEmail = New e_Email
                    oeEmail.TipoOperacion = "2"
                    oeEmail.TipoPersonaEmpresa = 2
                    oeEmail.Principal = -1
                    oeEmail.IdPersonaEmpresa = oeEmpresa.Id
                    oeProveedor.leEmail = odEmail.Listar(oeEmail)
                End If
            Else
                oeProveedor = New e_Proveedor
            End If
            Return oeProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerNomProv(ByVal oeProveedor As e_Proveedor) As e_Proveedor
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Proveedor_Listar]", oeProveedor.TipoOperacion, "", "", oeProveedor.Nombre.Trim, 0, True)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeProveedor = Cargar(ds.Tables(0).Rows(0))
                If oeProveedor.TipoPersonaEmpresa = 1 Then
                    oePersona = New e_Persona
                    oePersona.Id = oeProveedor.IdPersona
                    oePersona = odPersona.Obtener(oePersona)
                    oeProveedor.oePersona = oePersona
                Else
                    oeEmpresa = New e_Empresa
                    oeEmpresa.Id = oeProveedor.IdEmpresa
                    oeEmpresa = odEmpresa.Obtener(oeEmpresa)
                    oeProveedor.oeEmpresa = oeEmpresa
                End If
            End If
            Return oeProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeProveedor As e_Proveedor) As List(Of e_Proveedor)
        Try
            Dim leProveedor As New List(Of e_Proveedor)
            Dim ds As DataSet
            With oeProveedor
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Proveedor_Listar]", .TipoOperacion _
                        , .Id, .Codigo, .Nombre, .TipoPersonaEmpresa, .Activo, ._chkRuc )
            End With

            oeProveedor = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProveedor = Cargar(o_Fila)
                    leProveedor.Add(oeProveedor)
                Next
            End If
            Return leProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeProveedor As e_Proveedor)
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Proveedor In Listar(oeProveedor)
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function Guardar(ByVal oeProveedor As e_Proveedor) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            Dim idPersonaEmpresa As String = ""
            If oeProveedor.TipoPersonaEmpresa = 1 Then
                idPersonaEmpresa = odPersona.Guardar(oeProveedor.oePersona)
            Else
                idPersonaEmpresa = odEmpresa.Guardar(oeProveedor.oeEmpresa)
            End If
            oeProveedor.IdPersona = idPersonaEmpresa
            With oeProveedor
                sqlhelper.ExecuteNonQuery("STD.Isp_Proveedor_IAE", .TipoOperacion, _
                        .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .IdPersona _
                        , .FechaActividad _
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

    Public Function Eliminar(ByVal oeProveedor As e_Proveedor) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Proveedor_IAE", "E", oeProveedor.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
