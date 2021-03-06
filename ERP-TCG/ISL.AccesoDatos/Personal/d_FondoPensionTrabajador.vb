﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_FondoPensionTrabajador
    Private sqlhelper As New SqlHelper
    Private oeFonPenTra As New e_FondoPensionTrabajador

    Private Function Cargar(ByVal o_fila As DataRow) As e_FondoPensionTrabajador
        Try
            Dim oeFondoPensionTrabajador = New e_FondoPensionTrabajador( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("CUSPP").ToString _
                             , o_fila("Mixta") _
                             , o_fila("FechaActividad") _
                             , o_fila("FechaInactividad") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeFondoPensionTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As e_FondoPensionTrabajador
        Try
            Dim ds As DataSet
            With oeFondoPensionTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_FondoPensionTrabajador_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeFondoPensionTrabajador = Cargar(ds.Tables(0).Rows(0))
                oeFonPenTra = New e_FondoPensionTrabajador
                oeFonPenTra.TipoOperacion = ""
                oeFonPenTra.IdTrabajador = oeFondoPensionTrabajador.IdTrabajador
                oeFonPenTra.Vigente = -1
                oeFonPenTra.Activo = True
                oeFondoPensionTrabajador.leHistorial = Listar(oeFonPenTra)
            End If
            Return oeFondoPensionTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As List(Of e_FondoPensionTrabajador)
        Try
            Dim ldFondoPensionTrabajador As New List(Of e_FondoPensionTrabajador)
            Dim ds As DataSet
            With oeFondoPensionTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_FondoPensionTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdEmpresa _
                        , .IdTrabajador _
                        , .CUSPP _
                        , .Mixta _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeFondoPensionTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeFondoPensionTrabajador = Cargar(o_Fila)
                ldFondoPensionTrabajador.Add(oeFondoPensionTrabajador)
            Next
            Return ldFondoPensionTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As Boolean
        Try
            With oeFondoPensionTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_FondoPensionTrabajador_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdEmpresa _
                        , .IdTrabajador _
                        , .CUSPP _
                        , .Mixta _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtFonPenTra As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.FondoPensionTrabajador", dtFonPenTra)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFondoPensionTrabajador As e_FondoPensionTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_FondoPensionTrabajador_IAE", "E", _
             "", oeFondoPensionTrabajador.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.FondoPensionTrabajador", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
