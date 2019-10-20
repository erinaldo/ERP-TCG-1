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

<DataContract(), Serializable()> _
Public Class l_Historial
    Implements Il_Historial

    Dim odHistorial As New d_Historial
    Dim odHistorialInventario As New d_HistorialInventario
    Dim olFuncionesGenerales As New l_FuncionesGenerales


    Public Function Eliminar(ByVal oeHistorial As e_Historial) As Boolean Implements Il_Historial.Eliminar
        Try
            Return odHistorial.Eliminar(oeHistorial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorial As e_Historial) As System.Collections.Generic.List(Of e_Historial) Implements Il_Historial.Listar
        Try
            Return odHistorial.Listar(oeHistorial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorial As e_Historial) As e_Historial Implements Il_Historial.Obtener
        Try
            Return odHistorial.Obtener(oeHistorial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_Historial.CrearDT
        Dim Historial As New Data.DataTable
        With Historial
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdSubAlmacen", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
        End With
        Return Historial
    End Function

    Public Function GuardarMasivo(oeHistorial As e_Historial) As Boolean Implements Il_Historial.GuardarMasivo
        Try
            'datatables
            Dim olHistorial As New l_Historial
            Dim olHistorialInventario As New l_HistorialInventario

            Dim dt_H As Data.DataTable = olHistorial.CrearDT()
            Dim dt_HI As Data.DataTable = olHistorialInventario.CrearDT()

            'historial
            Dim IdHistorial As String = odHistorial.UltimoIdInserta(oeHistorial.PrefijoID)
            Dim lsPrefijoHistorial As String = Left(IdHistorial, 3)
            Dim lsNumeroIdHistorial As Integer = CInt(Right(IdHistorial, Len(IdHistorial) - 3))

            'historial detalle
            Dim IdHistorialInventario As String = odHistorialInventario.UltimoIdInserta(oeHistorial.PrefijoID)
            Dim lsPrefijoHistorialInventario As String = Left(IdHistorialInventario, 3)
            Dim lsNumeroIdHistorialInventario As Integer = CInt(Right(IdHistorialInventario, Len(IdHistorialInventario) - 3))

            With oeHistorial
                Dim rowH As Data.DataRow
                rowH = dt_H.NewRow
                rowH("Id") = lsPrefijoHistorial + olFuncionesGenerales.CompletaConCeros(lsNumeroIdHistorial.ToString, 9)
                rowH("IdSubAlmacen") = .IdSubAlmacen
                rowH("Fecha") = .Fecha
                rowH("Activo") = True
                rowH("Glosa") = .Glosa
                rowH("UsuarioCreacion") = .UsuarioCreacion
                rowH("FechaCreacion") = .FechaCreacion
                dt_H.Rows.Add(rowH)
                Dim rowHI As Data.DataRow
                For Each hisinv As e_HistorialInventario In .lstHistorialInventario
                    rowHI = dt_HI.NewRow
                    With hisinv
                        rowHI("Id") = lsPrefijoHistorialInventario + olFuncionesGenerales.CompletaConCeros(lsNumeroIdHistorialInventario.ToString, 9)
                        rowHI("IdHistorial") = rowH("Id")
                        rowHI("IdMaterial") = .IdMaterial
                        rowHI("IdUnidadMedida") = .IdUnidadMedida
                        rowHI("CantidadFinal") = .CantidadFinal
                        rowHI("ValorUnitario") = .ValorUnitario
                        rowHI("ValorTotal") = Math.Round(.ValorUnitario * .CantidadFinal, 4)
                        rowHI("Fecha") = .Fecha
                        rowHI("Activo") = True
                        dt_HI.Rows.Add(rowHI)
                        lsNumeroIdHistorialInventario += 1
                    End With
                Next
                If odHistorial.GuardaMasivo(dt_H, dt_HI) Then
                    Return True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
