Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaxCyP
    Implements Il_CuentaxCyP
    Dim odCuentaxCyP As New d_CuentaxCyP

    Public Function CrearDT() As System.Data.DataTable Implements Il_CuentaxCyP.CrearDT
        Dim CuentaxCyP As New Data.DataTable
        With CuentaxCyP
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoCajaBanco", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("MontoMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("MacPCLocalCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaCorriente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndCargoAbono", Type.GetType("System.Int16")))
        End With
        Return CuentaxCyP
    End Function

    Public Function Eliminar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean Implements Il_CuentaxCyP.Eliminar
        Try
            Return odCuentaxCyP.Eliminar(oeCuentaxCyP)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean Implements Il_CuentaxCyP.Guardar
        Try
            If Validar(oeCuentaxCyP) Then
                Return odCuentaxCyP.Guardar(oeCuentaxCyP)
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaxCyP As e_CuentaxCyP) As System.Collections.Generic.List(Of e_CuentaxCyP) Implements Il_CuentaxCyP.Listar
        Try
            Return odCuentaxCyP.Listar(oeCuentaxCyP)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaxCyP As e_CuentaxCyP) As e_CuentaxCyP Implements Il_CuentaxCyP.Obtener
        Try
            Return odCuentaxCyP.Obtener(oeCuentaxCyP)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReporteCuentasXC(ByVal IdClienteProveedor As String) As System.Data.DataSet Implements Il_CuentaxCyP.ReporteCuentasXC
        Try
            Dim dt As DataTable = odCuentaxCyP.ReporteCuentasXCobrar("TOD", IdClienteProveedor)
            If dt.Rows.Count = 0 Then Throw New Exception("Información no registrada")

            Dim Proveedor As String = ""
            Dim dt2 As New DataTable
            dt2 = dt.Clone
            dt.Select(Nothing, "Dni")
            For Each obj As DataRow In dt.Rows
                If obj("Dni").ToString <> Proveedor Then
                    Proveedor = obj("Dni")
                    dt2.ImportRow(obj)
                    dt2.Rows(dt2.Rows.Count - 1).Item("Id") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("FechaEmision") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("FechaVencimiento") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("Vencido") = 0
                    dt2.Rows(dt2.Rows.Count - 1).Item("tipoDoc") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("Serie") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("Numero") = ""
                    dt2.Rows(dt2.Rows.Count - 1).Item("GlosaCtaxCyP") = ""
                Else
                    dt2.Rows(dt2.Rows.Count - 1).Item("FACT_S") = dt2.Rows(dt2.Rows.Count - 1).Item("FACT_S") + obj("FACT_S")
                    dt2.Rows(dt2.Rows.Count - 1).Item("FACT_D") = dt2.Rows(dt2.Rows.Count - 1).Item("FACT_D") + obj("FACT_D")
                    dt2.Rows(dt2.Rows.Count - 1).Item("Detraccion") = dt2.Rows(dt2.Rows.Count - 1).Item("Detraccion") + obj("Detraccion")
                    dt2.Rows(dt2.Rows.Count - 1).Item("Neto") = dt2.Rows(dt2.Rows.Count - 1).Item("Neto") + obj("Neto")
                    dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_S") = dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_S") + obj("SALDO_S")
                    dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_D") = dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_D") + obj("SALDO_D")
                    dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_AL_TCV") = dt2.Rows(dt2.Rows.Count - 1).Item("SALDO_AL_TCV") + obj("SALDO_AL_TCV")
                End If
            Next
            dt2.TableName = "TablaAgrupada"
            Dim ds As New DataSet
            ds.Tables.Add(dt2.Copy)
            ds.Tables.Add(dt.Copy)

            Dim PadreCol As DataColumn = ds.Tables(0).Columns("Dni")
            Dim HijoCol As DataColumn = ds.Tables(1).Columns("Dni")
            Dim Relacion As DataRelation = New DataRelation("Dni2", PadreCol, HijoCol, True)
            ds.Relations.Add(Relacion)
            ds.AcceptChanges()

            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean Implements Il_CuentaxCyP.Validar
        Try
            With oeCuentaxCyP
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
