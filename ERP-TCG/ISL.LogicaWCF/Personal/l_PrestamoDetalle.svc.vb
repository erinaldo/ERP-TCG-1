'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_PrestamoDetalle
    Implements Il_PrestamoDetalle

    Dim odPrestamoDetalle As New d_PrestamoDetalle
    Dim oePrestamoDet As New e_PrestamoDetalle

    Public Function Obtener(ByVal oePrestamoDetalle As e_PrestamoDetalle) As e_PrestamoDetalle Implements Il_PrestamoDetalle.Obtener
        Try
            Return odPrestamoDetalle.Obtener(oePrestamoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As List(Of e_PrestamoDetalle) Implements Il_PrestamoDetalle.Listar
        Try
            Return odPrestamoDetalle.Listar(oePrestamoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean Implements Il_PrestamoDetalle.Validar
        Try
            With oePrestamoDetalle
                If String.IsNullOrEmpty(.Anio) Or String.IsNullOrEmpty(.Mes) Then Throw New Exception("Ingrese Año/Mes de la Cuota.")
                If .Importe = 0 Then Throw New Exception("El Importe de la Cuota debe ser mayor a cero.")
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean Implements Il_PrestamoDetalle.Guardar
        Try
            If Validar(oePrestamoDetalle) Then
                Return odPrestamoDetalle.Guardar(oePrestamoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean Implements Il_PrestamoDetalle.Eliminar
        Try
            Return odPrestamoDetalle.Eliminar(oePrestamoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal lePrestamoDet As System.Collections.Generic.List(Of EntidadesWCF.e_PrestamoDetalle)) As Boolean Implements Il_PrestamoDetalle.GuardarLista
        Try
            Return odPrestamoDetalle.GuardarLista(lePrestamoDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Ejecutar(ByVal oePrestamoDetalle As EntidadesWCF.e_PrestamoDetalle, _
                             ByVal lePrestamo As List(Of e_Prestamo), ByVal FechaEjecucion As Date, _
                             ByVal IndAdelantoPrestamo As Boolean, ByVal ls_PeriodoEjec As String) As Boolean Implements Il_PrestamoDetalle.Ejecutar
        Try
            Using TransScope As New TransactionScope()
                odPrestamoDetalle.Ejecutar(oePrestamoDetalle, lePrestamo)
                'If Not IndAdelantoPrestamo Then
                '    Dim lePres As New List(Of e_Prestamo)
                '    Dim olPres As New l_Prestamo
                '    Dim oePres As New e_Prestamo
                '    oePres.fecInicio = FechaEjecucion
                '    oePres.lsGruposDescuentos = ls_PeriodoEjec
                '    oePres.TipoOperacion = IIf(IndAdelantoPrestamo = True, "S", "A")
                '    lePres.AddRange(olPres.Listar(oePres))

                '    Dim olTipoCambio As New l_TipoCambio
                '    Dim oeTipoCambio As New e_TipoCambio
                '    oeTipoCambio.TipoOperacion = "U"
                '    oeTipoCambio.FechaCambio = Date.Now.Date
                '    oeTipoCambio = olTipoCambio.Listar(oeTipoCambio)(0)

                '    Dim olASiento As New l_Asiento
                '    olASiento.IntegracionPrestamosDescuentoPlanilla(lePres, _
                '    oePrestamoDetalle.oePreiodo, oePrestamoDetalle.UsuarioCreacion, oeTipoCambio.CambioVenta, FechaEjecucion)

                'End If
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function Liquidar(ByVal oePrestamoDetalle As EntidadesWCF.e_PrestamoDetalle) As Boolean Implements Il_PrestamoDetalle.Liquidar
    '    Try
    '        Dim cadid() As String
    '        cadid = oePrestamoDetalle.CadIdPrestDet.Split(",")
    '        For i = 0 To cadid.Length - 1
    '            oePrestamoDet = New e_PrestamoDetalle
    '            oePrestamoDet.IdPrestamo = cadid(i)
    '            oePrestamoDet.Activo = 1
    '            oePrestamoDet.Cancelado = 0
    '            oePrestamoDet.Fecha = Date.Now.Date
    '            oePrestamoDet.DobleMes = 0
    '            oePrestamoDet.Anulado = 0
    '            oePrestamoDet.Anio = ""
    '            oePrestamoDet.Mes = ""
    '            oePrestamoDet.UsuarioCreacion = ""
    '            'oePrestamoDet.Importe = 
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
End Class
