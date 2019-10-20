'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_RetencionQuinta
    Implements Il_RetencionQuinta

    Private odRetencionQuinta As New d_RetencionQuinta
    Private olDetalle As New l_DetalleRentaQuinta
    Private odDetalle As New d_DetalleRentaQuinta
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeRetencionQuinta As e_RetencionQuinta) As Boolean Implements Il_RetencionQuinta.Eliminar
        Try
            Return odRetencionQuinta.Eliminar(oeRetencionQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeRetencionQuinta As e_RetencionQuinta) As Boolean Implements Il_RetencionQuinta.Guardar
        Try
            If Validar(oeRetencionQuinta) Then
                Return odRetencionQuinta.Guardar(oeRetencionQuinta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeRetencionQuinta As e_RetencionQuinta) As List(Of e_RetencionQuinta) Implements Il_RetencionQuinta.Listar
        Try
            Return odRetencionQuinta.Listar(oeRetencionQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeRetencionQuinta As e_RetencionQuinta) As e_RetencionQuinta Implements Il_RetencionQuinta.Obtener
        Try
            Return odRetencionQuinta.Obtener(oeRetencionQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeRetencionQuinta As e_RetencionQuinta) As Boolean Implements Il_RetencionQuinta.Validar
        Try
            With oeRetencionQuinta
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                If oeRetencionQuinta.Importe = 0 Then Throw New Exception("Ingrese Monto")
                If oeRetencionQuinta.leDetalle.Count = 0 Then Throw New Exception("No tiene Detalle")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImportarDatos(oeRetencionQuinta As e_RetencionQuinta) As Boolean Implements Il_RetencionQuinta.ImportarDatos
        Try
            Dim dtDR5 As Data.DataTable = olDetalle.CrearDT()
            Dim id As String = odDetalle.UltimoIdInserta(oeRetencionQuinta.PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDet In oeRetencionQuinta.leDetalle
                Dim rwDR5 As Data.DataRow
                rwDR5 = dtDR5.NewRow
                With oeDet
                    rwDR5("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwDR5("IdRetencionQuinta") = String.Empty
                    rwDR5("IdTrabajador") = .IdTrabajador
                    rwDR5("Sueldo") = .Sueldo
                    rwDR5("AsignacionFamiliar") = .AsignacionFamiliar
                    rwDR5("Renumeracion") = .Renumeracion
                    rwDR5("Basico1") = .Basico1
                    rwDR5("Basico2") = .Basico2
                    rwDR5("Basico3") = .Basico3
                    rwDR5("Basico4") = .Basico4
                    rwDR5("Basico5") = .Basico5
                    rwDR5("Basico6") = .Basico6
                    rwDR5("Basico7") = .Basico7
                    rwDR5("Basico8") = .Basico8
                    rwDR5("Basico9") = .Basico9
                    rwDR5("Basico10") = .Basico10
                    rwDR5("Basico11") = .Basico11
                    rwDR5("Basico12") = .Basico12
                    rwDR5("BasicoPercibido") = .TotalBasico
                    rwDR5("Utilidad") = .Utilidad
                    rwDR5("BasicoG1") = .BasicoG1
                    rwDR5("BonoExtG1") = .BonoExtG1
                    rwDR5("Bono1") = .HoraExtra25
                    rwDR5("Bono2") = .HoraExtra35
                    rwDR5("Bono3") = .Movilidad
                    rwDR5("Bono4") = .BonoProduccion
                    rwDR5("Bono5") = .RenumeracionVacacional
                    rwDR5("Bono6") = .CompensacionVacacional
                    rwDR5("Bono7") = .BonoResponsabilidad
                    rwDR5("Bono8") = .DescansoMedico
                    rwDR5("Bono9") = .RentaNeta27IUT2
                    rwDR5("Bono10") = .Diferencia
                    rwDR5("Bono11") = .RentaQuinta15
                    rwDR5("Bono12") = .RentaQuinta21
                    rwDR5("BonoPercibido") = .SueldoContratado
                    rwDR5("BasicoPendiente") = .BasicoPendiente
                    rwDR5("BonoPendiente") = .Adicional
                    rwDR5("BasicoG2") = .BasicoG2
                    rwDR5("BonoExtG2") = .BonoExtG2
                    rwDR5("RentaBrutaAnual") = .RentaBrutaAnual
                    rwDR5("DeduccionIUT") = .DeduccionIUT
                    rwDR5("RentaNetaAnual") = .RentaNetaAnual
                    rwDR5("TipoRetencion") = .Administrativo
                    rwDR5("ImpuestoAnual") = .ImpuestoAnual
                    rwDR5("Retencion1") = .Retencion1
                    rwDR5("Retencion2") = .Retencion2
                    rwDR5("Retencion3") = .Retencion3
                    rwDR5("Retencion4") = .Retencion4
                    rwDR5("Retencion5") = .Retencion5
                    rwDR5("Retencion6") = .Retencion6
                    rwDR5("Retencion7") = .Retencion7
                    rwDR5("Retencion8") = .Retencion8
                    rwDR5("Retencion9") = .Retencion9
                    rwDR5("Retencion10") = .Retencion10
                    rwDR5("Retencion11") = .Retencion11
                    rwDR5("Retencion12") = .Retencion12
                    rwDR5("TotalRetencion") = .TotalRetencion
                    rwDR5("RentaSaldo") = .RentaSaldo
                    rwDR5("Monto") = .Monto
                    rwDR5("Operacion") = .Operacion
                    rwDR5("FechaCreacion") = Date.Now
                    rwDR5("UsuarioCreacion") = .UsuarioCreacion
                    rwDR5("FechaModifica") = .FechaModifica
                    rwDR5("UsuarioModifica") = .UsuarioModifica
                    rwDR5("Activo") = True
                End With
                dtDR5.Rows.Add(rwDR5)
                lsNumero = lsNumero + 1
            Next
            oeRetencionQuinta.dtDetalleR5 = dtDR5
            Return odRetencionQuinta.ImportarDatos(oeRetencionQuinta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
