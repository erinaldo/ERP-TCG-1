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

Public Class d_DetalleGratificacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleGratificacion
        Try
            Dim oeDetalleGratificacion = New e_DetalleGratificacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdBonoCompensatorio").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdCentro").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("CuentaCorriente").ToString _
                             , o_fila("DatoApoyo") _
                             , o_fila("IndTipoAux") _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("TempIngreso") _
                             , o_fila("Sueldo").ToString _
                             , o_fila("AsignacionFamiliar").ToString _
                             , o_fila("Renumeracion") _
                             , o_fila("HoraExtra1").ToString _
                             , o_fila("HoraExtra2").ToString _
                             , o_fila("HoraExtra3").ToString _
                             , o_fila("HoraExtra4").ToString _
                             , o_fila("HoraExtra5").ToString _
                             , o_fila("HoraExtra6").ToString _
                             , o_fila("IndPromExtra") _
                             , o_fila("PromedioHoraExtra") _
                             , o_fila("Bono1").ToString _
                             , o_fila("Bono2").ToString _
                             , o_fila("Bono3").ToString _
                             , o_fila("Bono4").ToString _
                             , o_fila("Bono5").ToString _
                             , o_fila("Bono6").ToString _
                             , o_fila("IndPromedio").ToString _
                             , o_fila("PromedioBono") _
                             , o_fila("Gratificacion") _
                             , o_fila("FraccionGrati") _
                             , o_fila("RenumeracionComputable").ToString _
                             , o_fila("TiempoLaborado").ToString _
                             , o_fila("DiasFaltas").ToString _
                             , o_fila("MesesFalta") _
                             , o_fila("PeriodoComputable") _
                             , o_fila("Importe").ToString _
                             , o_fila("BonoExtra").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("DescuentosJudiciales").ToString _
                             , o_fila("AdelantoSueldo").ToString _
                             , o_fila("TotalDescuento") _
                             , o_fila("NetoTotal").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndPendiente") _
            )
            Return oeDetalleGratificacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As e_DetalleGratificacion
        Try
            Dim ds As DataSet
            With oeDetalleGratificacion
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleBonoCompensatorio_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleGratificacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleGratificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As List(Of e_DetalleGratificacion)
        Try
            Dim ldDetalleGratificacion As New List(Of e_DetalleGratificacion)
            Dim ds As DataSet
            With oeDetalleGratificacion
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleBonoCompensatorio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGratificacion _
                        , .IdTrabajador _
                        , .FechaIngreso _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleGratificacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleGratificacion = Cargar(o_Fila)
                ldDetalleGratificacion.Add(oeDetalleGratificacion)
            Next
            Return ldDetalleGratificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As Boolean
        Try
            With oeDetalleGratificacion
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleBonoCompensatorio_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGratificacion _
                        , .IdTrabajador _
                        , .IdCentro _
                        , .IdArea _
                        , .IdOcupacion _
                        , .IdCuentaCorriente _
                        , .DatoApoyo _
                        , .IndTipoAux _
                        , .FechaIngreso _
                        , .TempIngreso _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .Renumeracion _
                        , .HoraExtra1 _
                        , .HoraExtra2 _
                        , .HoraExtra3 _
                        , .HoraExtra4 _
                        , .HoraExtra5 _
                        , .HoraExtra6 _
                        , .IndPromExtra _
                        , .PromedioHoraExtra _
                        , .Bono1 _
                        , .Bono2 _
                        , .Bono3 _
                        , .Bono4 _
                        , .Bono5 _
                        , .Bono6 _
                        , .IndPromedio _
                        , .PromedioBono _
                        , .Gratificacion _
                        , .FraccionGrati _
                        , .RenumeracionComputable _
                        , .TiempoLaborado _
                        , .DiasFaltas _
                        , .MesesFalta _
                        , .PeriodoComputable _
                        , .Importe _
                        , .BonoExtra _
                        , .Total _
                        , .DescuentosJudiciales _
                        , .AdelantoSueldo _
                        , .TotalDescuento _
                        , .NetoTotal _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .IndPendiente
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetGrat As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.DetalleBonoCompensatorio", dtDetGrat)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleGratificacion As e_DetalleGratificacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleBonoCompensatorio_IAE", "E", _
             "", oeDetalleGratificacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetalleBonoCompensatorio", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
