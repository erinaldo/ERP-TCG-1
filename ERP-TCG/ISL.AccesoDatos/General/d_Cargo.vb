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

''' <summary>
''' Clase que permite el acceso a datos de los Cargos de trabajadores
''' </summary>
''' <remarks></remarks>
Public Class d_Cargo

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Cargo
        Try
            Dim oeCargo = New e_Cargo( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeCargo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCargo As e_Cargo) As e_Cargo
        Try
            Dim ds As DataSet
            With oeCargo
                ds = SqlHelper.ExecuteDataset("STD.Isp_Cargo_Listar", "", .Id, .Codigo, .Nombre)
            End With
            oeCargo = New e_Cargo
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCargo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCargo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCargo As e_Cargo) As List(Of e_Cargo)
        Try
            Dim ld As New List(Of e_Cargo)
            Dim ds As DataSet
            With oeCargo
                ds = SqlHelper.ExecuteDataset("STD.Isp_Cargo_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeCargo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCargo = Cargar(o_Fila)
                    ld.Add(oeCargo)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCargo As e_Cargo) As Boolean
        Try
            With oeCargo
                SqlHelper.ExecuteNonQuery("STD.ISP_Cargo_IAE", .TipOoperacion,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCargo As e_Cargo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("STD.ISP_Cargo_IAE", "E", oeCargo.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


End Class
