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

Public Class d_CuentaCtePersonal
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaCtePersonal
        Try
            Dim oeCuentaCtePersonal = New e_CuentaCtePersonal( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("IdEntidadBancaria").ToString _
                             , o_fila("EntidadBancaria").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("NroCuenta").ToString _
                             , o_fila("TipoConcepto").ToString _
                             , o_fila("IdPersona").ToString _
                             , o_fila("Persona").ToString _
                             , o_fila("Vinculo").ToString _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeCuentaCtePersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As e_CuentaCtePersonal

        Try
            Dim ds As DataSet
            With oeCuentaCtePersonal
                ds = sqlhelper.ExecuteDataset("PER.Isp_CuentaCtePersonal_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaCtePersonal = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaCtePersonal
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As List(Of e_CuentaCtePersonal)
        Try
            Dim ldCuentaCtePersonal As New List(Of e_CuentaCtePersonal)
            Dim ds As DataSet
            With oeCuentaCtePersonal
                ds = sqlhelper.ExecuteDataset("PER.Isp_CuentaCtePersonal_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdEntidadBancaria _
                        , .IdMoneda _
                        , .NroCuenta _
                        , .TipoConcepto _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeCuentaCtePersonal = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuentaCtePersonal = Cargar(o_Fila)
                ldCuentaCtePersonal.Add(oeCuentaCtePersonal)
            Next
            Return ldCuentaCtePersonal
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As Boolean
        Try
            With oeCuentaCtePersonal
                sqlhelper.ExecuteNonQuery("PER.Isp_CuentaCtePersonal_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTrabajador _
                        , .IdEntidadBancaria _
                        , .IdMoneda _
                        , .NroCuenta _
                        , .TipoConcepto _
                        , .IdBeneficiario _
                        , .Vinculo _
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

    Public Function GuardarMasivo(ByVal dtCtaCtePer As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.CuentaCtePersonal", dtCtaCtePer)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_CuentaCtePersonal_IAE", "E", _
             "", oeCuentaCtePersonal.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.CuentaCtePersonal", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
