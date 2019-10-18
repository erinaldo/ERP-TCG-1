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

Public Class d_DetalleRentaQuinta

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleRentaQuinta
        Try
            Dim oeDetalleRentaQuinta = New e_DetalleRentaQuinta( _
                             o_fila("Id").ToString _
                             , o_fila("IdRetencionQuinta").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Sueldo") _
                             , o_fila("AsignacionFamiliar") _
                             , o_fila("Renumeracion") _
                             , o_fila("Basico1") _
                             , o_fila("Basico2") _
                             , o_fila("Basico3") _
                             , o_fila("Basico4") _
                             , o_fila("Basico5") _
                             , o_fila("Basico6") _
                             , o_fila("Basico7") _
                             , o_fila("Basico8") _
                             , o_fila("Basico9") _
                             , o_fila("Basico10") _
                             , o_fila("Basico11") _
                             , o_fila("Basico12") _
                             , o_fila("BasicoPercibido") _
                             , o_fila("Utilidad") _
                             , o_fila("BasicoG1") _
                             , o_fila("BonoExtG1") _
                             , o_fila("Bono1") _
                             , o_fila("Bono2") _
                             , o_fila("Bono3") _
                             , o_fila("Bono4") _
                             , o_fila("Bono5") _
                             , o_fila("Bono6") _
                             , o_fila("Bono7") _
                             , o_fila("Bono8") _
                             , o_fila("Bono9") _
                             , o_fila("Bono10") _
                             , o_fila("Bono11") _
                             , o_fila("Bono12") _
                             , o_fila("Bono13") _
                             , o_fila("Bono14") _
                             , o_fila("Bono15") _
                             , o_fila("Bono16") _
                             , o_fila("Bono17") _
                             , o_fila("Bono18") _
                             , o_fila("Bono19") _
                             , o_fila("Bono20") _
                             , o_fila("Bono21") _
                             , o_fila("BonoPercibido") _
                             , o_fila("BasicoPendiente") _
                             , o_fila("BonoPendiente") _
                             , o_fila("BasicoG2") _
                             , o_fila("BonoExtG2") _
                             , o_fila("RentaBrutaAnual") _
                             , o_fila("DeduccionIUT") _
                             , o_fila("RentaNetaAnual") _
                             , o_fila("TipoRetencion") _
                             , o_fila("Rango1") _
                             , o_fila("Rango2") _
                             , o_fila("Rango3") _
                             , o_fila("Rango4") _
                             , o_fila("Rango5") _
                             , o_fila("ImpuestoAnual") _
                             , o_fila("Retencion1") _
                             , o_fila("Retencion2") _
                             , o_fila("Retencion3") _
                             , o_fila("Retencion4") _
                             , o_fila("Retencion5") _
                             , o_fila("Retencion6") _
                             , o_fila("Retencion7") _
                             , o_fila("Retencion8") _
                             , o_fila("Retencion9") _
                             , o_fila("Retencion10") _
                             , o_fila("Retencion11") _
                             , o_fila("Retencion12") _
                             , o_fila("TotalRetencion") _
                             , o_fila("RentaSaldo") _
                             , o_fila("Monto") _
                             , o_fila("Operacion") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetalleRentaQuinta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As e_DetalleRentaQuinta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleRentaQuinta_Listar", oeDetalleRentaQuinta.TipoOperacion, oeDetalleRentaQuinta.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleRentaQuinta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleRentaQuinta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As List(Of e_DetalleRentaQuinta)
        Try
            Dim ldDetalleRentaQuinta As New List(Of e_DetalleRentaQuinta)
            Dim ds As DataSet
            With oeDetalleRentaQuinta
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleRentaQuinta_Listar", .TipoOperacion _
                        , .Id _
                        , .IdRetencionQuinta _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .Utilidad _
                        , .RentaBrutaAnual _
                        , .DeduccionIUT _
                        , .RentaNetaAnual _
                        , .Administrativo _
                        , .ImpuestoAnual _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleRentaQuinta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleRentaQuinta = Cargar(o_Fila)
                ldDetalleRentaQuinta.Add(oeDetalleRentaQuinta)
            Next
            Return ldDetalleRentaQuinta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As Boolean
        Try
            With oeDetalleRentaQuinta
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleRentaQuinta_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdRetencionQuinta _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .Renumeracion _
                        , .Basico1 _
                        , .Basico2 _
                        , .Basico3 _
                        , .Basico4 _
                        , .Basico5 _
                        , .Basico6 _
                        , .Basico7 _
                        , .Basico8 _
                        , .Basico9 _
                        , .Basico10 _
                        , .Basico11 _
                        , .Basico12 _
                        , .TotalBasico _
                        , .Utilidad _
                        , .BasicoG1 _
                        , .BonoExtG1 _
                        , .HoraExtra25 _
                        , .HoraExtra35 _
                        , .Movilidad _
                        , .BonoProduccion _
                        , .RenumeracionVacacional _
                        , .CompensacionVacacional _
                        , .BonoResponsabilidad _
                        , .DescansoMedico _
                        , .VueltaAdicionalPiura _
                        , .BonoCombustiblePiura _
                        , .BonoJefeConvoy _
                        , .VueltaAdicionalLima _
                        , .Otros _
                        , .VueltaCaliza _
                        , .HorasNocturnas _
                        , .Semaforo _
                        , .RentaNeta27IUT2 _
                        , .Diferencia _
                        , .RentaQuinta15 _
                        , .RentaQuinta21 _
                        , .OtroInafecto _
                        , .SueldoContratado _
                        , .BasicoPendiente _
                        , .Adicional _
                        , .BasicoG2 _
                        , .BonoExtG2 _
                        , .RentaBrutaAnual _
                        , .DeduccionIUT _
                        , .RentaNetaAnual _
                        , .Administrativo _
                        , .Rango1 _
                        , .Rango2 _
                        , .Rango3 _
                        , .Rango4 _
                        , .Rango5 _
                        , .ImpuestoAnual _
                        , .Retencion1 _
                        , .Retencion2 _
                        , .Retencion3 _
                        , .Retencion4 _
                        , .Retencion5 _
                        , .Retencion6 _
                        , .Retencion7 _
                        , .Retencion8 _
                        , .Retencion9 _
                        , .Retencion10 _
                        , .Retencion11 _
                        , .Retencion12 _
                        , .TotalRetencion _
                        , .RentaSaldo _
                        , .Monto _
                        , .Operacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetR5 As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.DetalleRentaQuinta", dtDetR5)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleRentaQuinta As e_DetalleRentaQuinta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleRentaQuinta_IAE", "E", _
             "", oeDetalleRentaQuinta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetalleRentaQuinta", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
