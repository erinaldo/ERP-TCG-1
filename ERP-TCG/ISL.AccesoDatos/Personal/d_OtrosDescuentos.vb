Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OtrosDescuentos

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OtrosDescuentos
        Try
            Dim oeOtrasDescuentos = New e_OtrosDescuentos( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("Monto") _
                             , o_fila("IdEmpresaConvenio").ToString _
                             , o_fila("EmpresaConvenio").ToString _
                             , o_fila("IdCuentaBeneficiario").ToString _
                             , o_fila("NroCuenta").ToString _
                             , o_fila("PersonaCuenta").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IndReferencia") _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModfica").ToString _
                             , o_fila("Activo") _
            )
            Return oeOtrasDescuentos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOtrasDescuentos As e_OtrosDescuentos) As e_OtrosDescuentos

        Try
            Dim ds As DataSet
            With oeOtrasDescuentos
                ds = sqlhelper.ExecuteDataset("PER.Isp_OtrosDescuentos_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeOtrasDescuentos = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOtrasDescuentos
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOtrasDescuentos As e_OtrosDescuentos) As List(Of e_OtrosDescuentos)
        Try
            Dim ldOtrasDescuentos As New List(Of e_OtrosDescuentos)
            Dim ds As DataSet
            With oeOtrasDescuentos
                ds = sqlhelper.ExecuteDataset("PER.Isp_OtrosDescuentos_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Monto _
                        , .IdEmpresaConvenio _
                        , .IdCuentaBeneficiario _
                        , .IdEstado _
                        , .IndReferencia _
                        , .IdReferencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeOtrasDescuentos = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeOtrasDescuentos = Cargar(o_Fila)
                ldOtrasDescuentos.Add(oeOtrasDescuentos)
            Next
            Return ldOtrasDescuentos
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOtrasDescuentos As e_OtrosDescuentos) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOtrasDescuentos
                sqlhelper.ExecuteNonQuery("PER.Isp_OtrosDescuentos_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Monto _
                        , .IdEmpresaConvenio _
                        , .IdCuentaBeneficiario _
                        , .IdEstado _
                        , .IndReferencia _
                        , .IdReferencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtOtrosDscto As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.OtrosDescuentos", dtOtrosDscto)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(ByVal leOtrosDescuentos As List(Of e_OtrosDescuentos)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeOD In leOtrosDescuentos
                    Guardar(oeOD)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOtrasDescuentos As e_OtrosDescuentos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_OtrosDescuentos_IAE", "E", _
             "", oeOtrasDescuentos.Id, "", oeOtrasDescuentos.IdTrabajador)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.OtrosDescuentos", d_DatosConfiguracion.PrefijoID _
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
