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

Public Class l_PagoAdicional
    Implements Il_PagoAdicional

    Private odPagoAdicional As New d_PagoAdicional
    Private olDetalle As New l_DetallePagoAdicional
    Private odDetalle As New d_DetallePagoAdicional
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePagoAdicional As e_PagoAdicional) As Boolean Implements Il_PagoAdicional.Eliminar
        Try
            Return odPagoAdicional.Eliminar(oePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePagoAdicional As e_PagoAdicional) As Boolean Implements Il_PagoAdicional.Guardar
        Try
            If Validar(oePagoAdicional) Then
                Return odPagoAdicional.Guardar(oePagoAdicional)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePagoAdicional As e_PagoAdicional) As List(Of e_PagoAdicional) Implements Il_PagoAdicional.Listar
        Try
            Return odPagoAdicional.Listar(oePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePagoAdicional As e_PagoAdicional) As e_PagoAdicional Implements Il_PagoAdicional.Obtener
        Try
            Return odPagoAdicional.Obtener(oePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePagoAdicional As e_PagoAdicional) As Boolean Implements Il_PagoAdicional.Validar
        Try
            With oePagoAdicional
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImportarDatos(oePagoAdicional As e_PagoAdicional) As Boolean Implements Il_PagoAdicional.ImportarDatos
        Try
            Dim dtPA As Data.DataTable = olDetalle.CrearDT()
            Dim id As String = odDetalle.UltimoIdInserta(oePagoAdicional.PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDet In oePagoAdicional.leDetalle
                Dim rwPA As Data.DataRow
                rwPA = dtPA.NewRow
                With oeDet
                    rwPA("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwPA("IdPagoAdicional") = String.Empty
                    rwPA("IdTrabajador") = .IdTrabajador
                    rwPA("Sueldo") = .Sueldo
                    rwPA("AsignacionFamiliar") = .AsignacionFamiliar
                    rwPA("IndTipo") = .IndTipo
                    rwPA("Cantidad") = .Cantidad
                    rwPA("Monto") = .Monto
                    rwPA("Redondeo") = .Redondeo
                    rwPA("DiasVacaciones") = .DiasVacaciones
                    rwPA("DiasFalta") = .DiasFalta
                    rwPA("DiasDescanso") = .DiasDescanso
                    rwPA("TotalPagar") = .TotalPagar
                    rwPA("FechaCreacion") = Date.Now
                    rwPA("UsuarioCreacion") = .UsuarioCreacion
                    rwPA("FechaModifica") = .FechaModifica
                    rwPA("UsuarioModifica") = .UsuarioModifica
                    rwPA("Activo") = True
                End With
                rwPA("HorasExtras") = oeDet.HorasExtras
                rwPA("MinutosExtras") = oeDet.MinutosExtras
                dtPA.Rows.Add(rwPA)
                lsNumero = lsNumero + 1
            Next
            oePagoAdicional.dtDetallePA = dtPA
            Return odPagoAdicional.ImportarDatos(oePagoAdicional)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
