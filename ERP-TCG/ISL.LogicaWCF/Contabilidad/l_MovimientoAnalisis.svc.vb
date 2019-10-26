Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MovimientoAnalisis
    Implements Il_MovimientoAnalisis

    Dim odMovimientoAnalisis As New d_MovimientoAnalisis
    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Public Function CrearDT() As System.Data.DataTable Implements Il_MovimientoAnalisis.CrearDT
        Dim Analisis As New Data.DataTable
        With Analisis
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCentroCosto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdItemGasto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdVehiculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRuta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdBanco", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAnalisis1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAnalisis2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdAsientoMovimiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Saldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdMovimientoAnalisis", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdGastoFuncion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdOrigenProrrateo", Type.GetType("System.String")))
        End With
        Return Analisis
    End Function

    Public Function Eliminar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean Implements Il_MovimientoAnalisis.Eliminar
        Try
            Return odMovimientoAnalisis.Eliminar(oeMovimientoAnalisis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean Implements Il_MovimientoAnalisis.Guardar
        Try
            If Validar(oeMovimientoAnalisis) Then
                Return odMovimientoAnalisis.Guardar(oeMovimientoAnalisis)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As System.Collections.Generic.List(Of e_MovimientoAnalisis) Implements Il_MovimientoAnalisis.Listar
        Try
            Return odMovimientoAnalisis.Listar(oeMovimientoAnalisis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As e_MovimientoAnalisis Implements Il_MovimientoAnalisis.Obtener
        Try
            Return odMovimientoAnalisis.Obtener(oeMovimientoAnalisis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean Implements Il_MovimientoAnalisis.Validar
        Try
            With oeMovimientoAnalisis
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Prorraretar(leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean Implements Il_MovimientoAnalisis.Prorraretar
        Try
            If olFuncionesGenerales.ValidarPeriodo(leMovAnalisis(0).IdPeriodo, gAreasSGI.Planilla, leMovAnalisis(0).Fecha, "") Then
                Dim Id As String = odMovimientoAnalisis.UltimoIdInsertaProrrateo()
                Dim lsPrefijo As String = Left(Id, 3)
                Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
                Dim dt_MA As Data.DataTable = CrearDT()
                For Each _oeMovAna In leMovAnalisis
                    Dim rowDetalle As Data.DataRow
                    rowDetalle = dt_MA.NewRow
                    rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                    rowDetalle("IdCentroCosto") = _oeMovAna.IdCentroCosto
                    rowDetalle("IdItemGasto") = _oeMovAna.IdItemGasto
                    rowDetalle("IdTrabajador") = _oeMovAna.IdTrabajador
                    rowDetalle("IdVehiculo") = _oeMovAna.IdVehiculo
                    rowDetalle("IdRuta") = _oeMovAna.IdRuta
                    rowDetalle("IdBanco") = _oeMovAna.IdBanco
                    rowDetalle("IdAnalisis1") = _oeMovAna.IdAnalisis1
                    rowDetalle("IdAnalisis2") = _oeMovAna.IdAnalisis2
                    rowDetalle("Activo") = 1
                    rowDetalle("IdAsientoMovimiento") = _oeMovAna.IdAsientoMovimiento
                    rowDetalle("Monto") = _oeMovAna.Monto
                    rowDetalle("Saldo") = _oeMovAna.Monto
                    rowDetalle("IdMovimientoAnalisis") = ""
                    rowDetalle("IdGastoFuncion") = _oeMovAna.IdGastoFuncion
                    rowDetalle("IdOrigenProrrateo") = _oeMovAna.Id
                    dt_MA.Rows.Add(rowDetalle)
                    lsNumero = lsNumero + 1
                Next
                Return odMovimientoAnalisis.GuardarProrrateo(New List(Of e_MovimientoAnalisis), dt_MA)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean Implements Il_MovimientoAnalisis.GuardarLista
        Try
            Dim Id As String = odMovimientoAnalisis.UltimoIdInsertaProrrateo()
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            Dim dt_MA As Data.DataTable = CrearDT()
            For Each _oeMovAna In leMovAnalisis.Where(Function(it) it.TipoOperacion = "I" And it.Activo).ToList
                Dim rowDetalle As Data.DataRow
                rowDetalle = dt_MA.NewRow
                rowDetalle("Id") = lsPrefijo & olFuncionesGenerales.CompletaConCeros(lsNumero.ToString, 13)
                rowDetalle("IdCentroCosto") = _oeMovAna.IdCentroCosto
                rowDetalle("IdItemGasto") = _oeMovAna.IdItemGasto
                rowDetalle("IdTrabajador") = _oeMovAna.IdTrabajador
                rowDetalle("IdVehiculo") = _oeMovAna.IdVehiculo
                rowDetalle("IdRuta") = _oeMovAna.IdRuta
                rowDetalle("IdBanco") = _oeMovAna.IdBanco
                rowDetalle("IdAnalisis1") = _oeMovAna.IdAnalisis1
                rowDetalle("IdAnalisis2") = _oeMovAna.IdAnalisis2
                rowDetalle("Activo") = 1
                rowDetalle("IdAsientoMovimiento") = _oeMovAna.IdAsientoMovimiento
                rowDetalle("Monto") = _oeMovAna.Monto
                rowDetalle("Saldo") = _oeMovAna.Saldo
                rowDetalle("IdMovimientoAnalisis") = ""
                rowDetalle("IdGastoFuncion") = _oeMovAna.IdGastoFuncion
                rowDetalle("IdOrigenProrrateo") = _oeMovAna.Id
                dt_MA.Rows.Add(rowDetalle)
                lsNumero = lsNumero + 1
            Next
            'Return odMovimientoAnalisis.GuardarLista(leMovAnalisis)
            Return odMovimientoAnalisis.GuardarProrrateo(New List(Of e_MovimientoAnalisis), dt_MA)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
