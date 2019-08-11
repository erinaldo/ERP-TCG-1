Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegimenPensionario

    Private sqlhelper As New SqlHelper
    Private oeRegPen As New e_RegimenPensionario

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegimenPensionario
        Try
            Dim oeRegimenPensionario = New e_RegimenPensionario( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("PorcentajeObligatorio") _
                             , o_fila("PorcentajeComision") _
                             , o_fila("PorcentajeSeguros") _
                             , o_fila("PorcentajeComisionMixta") _
                             , o_fila("PorcentajeSaldoMixta") _
                             , o_fila("PorcentajeObligatorio2") _
                             , o_fila("RenumeracionMaxima") _
                             , o_fila("Vigente") _
                             , o_fila("FechaActividad") _
                             , o_fila("FechaInactividad") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeRegimenPensionario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegimenPensionario As e_RegimenPensionario) As e_RegimenPensionario
        Try
            Dim ds As DataSet
            With oeRegimenPensionario
                ds = sqlhelper.ExecuteDataset("PER.Isp_RegimenPensionario_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeRegimenPensionario = Cargar(ds.Tables(0).Rows(0))
                oeRegPen = New e_RegimenPensionario
                oeRegPen.TipoOperacion = ""
                oeRegPen.Activo = True
                oeRegPen.Vigente = -1
                oeRegPen.IdEmpresa = oeRegimenPensionario.IdEmpresa
                oeRegimenPensionario.leHistorialPorcentaje = Listar(oeRegPen)
            End If
            Return oeRegimenPensionario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegimenPensionario As e_RegimenPensionario) As List(Of e_RegimenPensionario)
        Try
            Dim ldRegimenPensionario As New List(Of e_RegimenPensionario)
            Dim ds As DataSet
            With oeRegimenPensionario
                ds = sqlhelper.ExecuteDataset("PER.Isp_RegimenPensionario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdEmpresa _
                        , .PorcentajeObligatorio _
                        , .PorcentajeComision _
                        , .PorcentajeSeguros _
                        , .Vigente _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeRegimenPensionario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRegimenPensionario = Cargar(o_Fila)
                ldRegimenPensionario.Add(oeRegimenPensionario)
            Next
            Return ldRegimenPensionario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _id As String = ""
            With oeRegimenPensionario
                _id = sqlhelper.ExecuteScalar("PER.Isp_RegimenPensionario_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdEmpresa _
                        , .PorcentajeObligatorio _
                        , .PorcentajeComision _
                        , .PorcentajeSeguros _
                        , .PorcentajeComisionMixta _
                        , .PorcentajeSaldoMixta _
                        , .PorcentajeObligatorio2 _
                        , .RenumeracionMaxima _
                        , .Vigente _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )

                .Id = _id

                If .TipoOperacion = "I" AndAlso .leHistorialPorcentaje.Count > 0 Then
                    ActualizarHistorial(oeRegimenPensionario)
                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtRegPen As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.RegimenPensionario", dtRegPen)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ActualizarHistorial(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean
        Try
            With oeRegimenPensionario
                sqlhelper.ExecuteNonQuery("PER.Isp_RegimenPensionario_IAE", "U", _
             "", .Id, .IdEmpresa)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegimenPensionario As e_RegimenPensionario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_RegimenPensionario_IAE", "E", _
             "", oeRegimenPensionario.Id)
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
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.RegimenPensionario", d_DatosConfiguracion.PrefijoID _
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
