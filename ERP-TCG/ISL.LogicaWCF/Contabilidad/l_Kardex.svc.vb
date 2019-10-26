Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_Kardex
    Implements Il_Kardex
    Dim odKardex As New d_Kardex
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function CrearDT_Kardex() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdPeriodoSgt", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            'System.DateTime()
        End With
        Return Kardex
    End Function

    Public Function CrearDT_KardexDetalle() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdKardex", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdVehiculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdArea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdGastoFuncion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoOperacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Valor", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Operacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRegistroInventario", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ValorPromedio", Type.GetType("System.Decimal")))
        End With
        Return Kardex
    End Function

    Public Function CrearDT_KardexSaldo() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdKardex", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ValorUnitario", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("CantidadFinal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
        End With
        Return Kardex
    End Function
   
    Public Function Corte(ByVal oeKardex As e_Kardex) As Boolean Implements Il_Kardex.Corte
        Dim Cont As Integer = 0
        Try
            Dim dt2 As DataTable = odKardex.ListarKardex(oeKardex)
            If dt2.Rows.Count > 0 Then
                Throw New Exception("Ya existe este periodo")
            End If
            Dim TablaCorte As DataTable
            Dim dt As DataTable = odKardex.Listar_KardexCorte(oeKardex)
            'Dim leCtaCtble As New List(Of e_CuentaContable)
            'Dim oeCtaCtble As New e_CuentaContable
            'Dim olCtaCtble As New l_CuentaContable
            'If oeKardex.Mes = 12 Then
            '    oeCtaCtble.Activo = True
            '    oeCtaCtble.Ejercicio = oeKardex.Año + 1
            '    leCtaCtble.AddRange(olCtaCtble.Listar(oeCtaCtble))
            '    If leCtaCtble.Count = 0 Then
            '        Throw New Exception("No existen ctas en el año:" & oeKardex.Año.ToString)
            '    End If
            'End If
            Dim IdKardex As String = ""
            Dim IdKardexDetalle As String = ""
            Dim IdKardexSaldo As String = ""
            Dim lsPrefijo As String = ""
            Dim lnNumeroKardex As Integer
            Dim lnNumeroKardexDetalle As Integer
            Dim lnNumeroKardexSaldo As Integer
            IdKardex = odKardex.UltimoIdInserta_Kardex(oeKardex.PrefijoID)
            IdKardexDetalle = odKardex.UltimoIdInserta_KardexDetalle(oeKardex.PrefijoID)
            IdKardexSaldo = odKardex.UltimoIdInserta_KardexSaldo(oeKardex.PrefijoID)
            lsPrefijo = Left(IdKardex, 3)
            lnNumeroKardex = CInt(Right(IdKardex, Len(IdKardex) - 3))
            lnNumeroKardexDetalle = CInt(Right(IdKardexDetalle, Len(IdKardexDetalle) - 3))
            lnNumeroKardexSaldo = CInt(Right(IdKardexSaldo, Len(IdKardexSaldo) - 3))

            Dim DtN As DataRow() = dt.Select(Nothing, "IdCuentaContable, IdMaterial, Fecha,Operacion, TipoOperacion desc ")
            TablaCorte = DtN.CopyToDataTable
            Dim dt_Kardex As Data.DataTable = CrearDT_Kardex()
            Dim dt_KardexDetalle As Data.DataTable = CrearDT_KardexDetalle()
            Dim dt_KardexSaldo As Data.DataTable = CrearDT_KardexSaldo()
            Dim lsCuentaBandera As String = ""
            Dim lsMaterialBandera As String = ""

            Dim rowKardex As Data.DataRow
            rowKardex = dt_Kardex.NewRow

            Dim rowKardexDetalle As Data.DataRow
            rowKardexDetalle = dt_KardexDetalle.NewRow

            Dim rowKardexSaldo As Data.DataRow
            rowKardexSaldo = dt_KardexSaldo.NewRow

            Dim Negativo As Boolean = False
            Dim EmpSalida As Boolean = False
            Dim PrecioAnterior As Double = 0
            Dim CantidadAnterior As Double = 0
            Dim lbAgregaKardex As Boolean = True
            Dim lbAgregaKardexSaldo As Boolean = True
            Dim lbAgregaKardexDetalle As Boolean = True

            For Each obj As DataRow In TablaCorte.Rows
                Cont = Cont + 1
                If Cont = 1 Then
                    '------------kardex-------------------------------------
                    lsCuentaBandera = obj.Item("IdCuentaContable")
                    rowKardex("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                    rowKardex("IdPeriodo") = oeKardex.IdPeriodo

                    rowKardex("IdCuentaContable") = obj.Item("IdCuentaContable")
                    rowKardex("IdUsuarioCreacion") = oeKardex.IdUsuarioCreacion
                    rowKardex("FechaCreacion") = Date.Now
                    rowKardex("IdPeriodoSgt") = oeKardex.IdPeriodoSgt
                    rowKardex("Activo") = 1
                    If obj.Item("Operacion") = "I" Then
                        'lbAgregaKardex = True
                        rowKardex("Total") = obj.Item("CantidadFinal") * PrecioAnterior
                    Else
                        'lbAgregaKardex = False
                        rowKardex("Total") = obj.Item("CantidadFinal") * PrecioAnterior * -1
                    End If
                    '-------------------------------------------------------
                Else
                    If lsCuentaBandera <> obj.Item("IdCuentaContable") Then
                        '----------------Kardex-----------------------------
                        If lbAgregaKardex = True Then
                            dt_Kardex.Rows.Add(rowKardex)
                            lnNumeroKardex = lnNumeroKardex + 1
                        End If

                        rowKardex = dt_Kardex.NewRow
                        lsCuentaBandera = obj.Item("IdCuentaContable")
                        rowKardex("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                        rowKardex("IdPeriodo") = oeKardex.IdPeriodo
                        rowKardex("IdCuentaContable") = obj.Item("IdCuentaContable")
                        rowKardex("IdUsuarioCreacion") = oeKardex.IdUsuarioCreacion
                        rowKardex("FechaCreacion") = Date.Now
                        rowKardex("IdPeriodoSgt") = oeKardex.IdPeriodoSgt
                        rowKardex("Activo") = 1
                        If obj.Item("Operacion") = "I" Then
                            'lbAgregaKardex = True
                            rowKardex("Total") = obj.Item("CantidadFinal") * PrecioAnterior
                        Else
                            'lbAgregaKardex = False
                            rowKardex("Total") = obj.Item("CantidadFinal") * PrecioAnterior * -1
                        End If
                        '----------------------------------------------------
                    Else
                        '---------------Kardex-------------------------------
                        If obj.Item("Operacion") = "I" Then
                            rowKardex("Total") = rowKardex("Total") + obj.Item("CantidadFinal") * PrecioAnterior
                        Else
                            If Negativo = False Then
                                rowKardex("Total") = rowKardex("Total") + obj.Item("CantidadFinal") * PrecioAnterior * -1
                            End If
                        End If
                        '----------------------------------------------------
                    End If
                End If
                If Cont = 1 Then
                    '---------------------Kardex saldo --------------------------
                    lsMaterialBandera = obj.Item("IdMaterial")
                    rowKardexSaldo("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexSaldo.ToString, 7)
                    rowKardexSaldo("IdKardex") = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                    rowKardexSaldo("IdMaterial") = obj.Item("IdMaterial")
                    rowKardexSaldo("ValorUnitario") = obj.Item("ValorUnitario")
                    If obj.Item("Operacion") = "I" Then
                        lbAgregaKardexSaldo = True
                        rowKardexSaldo("CantidadFinal") = obj.Item("CantidadFinal")
                    Else
                        lbAgregaKardexSaldo = False
                        rowKardexSaldo("CantidadFinal") = obj.Item("CantidadFinal") * -1
                    End If
                    rowKardexSaldo("IdUsuarioCreacion") = oeKardex.IdUsuarioCreacion
                    rowKardexSaldo("FechaCreacion") = Date.Now
                    '------------------------------------------------------------
                    '--------para calcular precio promedio-----------------------
                    PrecioAnterior = rowKardexSaldo("ValorUnitario")
                    CantidadAnterior = rowKardexSaldo("CantidadFinal")
                    '------------------------------------------------------------
                Else
                    If lsMaterialBandera <> obj.Item("IdMaterial") Then
                        '----------------Kardex Saldo-----------------------------
                        Negativo = False
                        EmpSalida = False
                        If Not EmpSalida And lbAgregaKardexSaldo Then
                            dt_KardexSaldo.Rows.Add(rowKardexSaldo)
                            lnNumeroKardexSaldo = lnNumeroKardexSaldo + 1
                        End If
                        lsMaterialBandera = obj.Item("IdMaterial")
                        rowKardexSaldo = dt_KardexSaldo.NewRow
                        If obj.Item("TipoOperacion") = "10" Then 'empieza con salida
                            EmpSalida = True
                            Negativo = True
                        End If
                        rowKardexSaldo("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexSaldo.ToString, 7)
                        rowKardexSaldo("IdKardex") = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                        rowKardexSaldo("IdMaterial") = obj.Item("IdMaterial")
                        rowKardexSaldo("ValorUnitario") = obj.Item("ValorUnitario")
                        If obj.Item("Operacion") = "I" Then
                            rowKardexSaldo("CantidadFinal") = obj.Item("CantidadFinal")
                            lbAgregaKardexSaldo = True
                        Else
                            rowKardexSaldo("CantidadFinal") = obj.Item("CantidadFinal") * -1
                            lbAgregaKardexSaldo = False
                        End If
                        rowKardexSaldo("IdUsuarioCreacion") = oeKardex.IdUsuarioCreacion
                        rowKardexSaldo("FechaCreacion") = Date.Now
                        '--------para calcular precio promedio---------------------
                        PrecioAnterior = rowKardexSaldo("ValorUnitario")
                        CantidadAnterior = rowKardexSaldo("CantidadFinal")
                        '----------------------------------------------------------
                        '----------------------------------------------------------
                    Else
                        '---------------Kardex Saldo-------------------------------
                        If obj.Item("Operacion") = "I" Then
                            If EmpSalida And obj.Item("TipoOperacion") = "02" Then
                                rowKardexSaldo("ValorUnitario") = obj.Item("ValorUnitario")
                                rowKardexSaldo("CantidadFinal") = obj.Item("CantidadFinal")
                                PrecioAnterior = rowKardexSaldo("ValorUnitario")
                                CantidadAnterior = rowKardexSaldo("CantidadFinal")
                                EmpSalida = False
                            Else
                                rowKardexSaldo("CantidadFinal") = rowKardexSaldo("CantidadFinal") + obj.Item("CantidadFinal")
                            End If
                            Negativo = False
                            If obj.Item("TipoOperacion") = "02" Then 'compra
                                PrecioAnterior = Math.Round((PrecioAnterior * CantidadAnterior + _
                                                             obj.Item("CantidadFinal") * obj.Item("ValorUnitario") _
                                                             ) / _
                                                             (CantidadAnterior + obj.Item("CantidadFinal")), 2) 'precio promedio
                            End If
                            CantidadAnterior = rowKardexSaldo("CantidadFinal")
                        Else
                            If Negativo = False Then
                                Dim ln As Double = 0
                                ln = rowKardexSaldo("CantidadFinal")
                                ln = obj.Item("CantidadFinal")
                                ln = Math.Round(rowKardexSaldo("CantidadFinal") - obj.Item("CantidadFinal"), 2)
                                If Math.Round(rowKardexSaldo("CantidadFinal") - obj.Item("CantidadFinal"), 2) < 0 Then
                                    Negativo = True
                                Else
                                    rowKardexSaldo("CantidadFinal") = rowKardexSaldo("CantidadFinal") - obj.Item("CantidadFinal")
                                    CantidadAnterior = CantidadAnterior - obj.Item("CantidadFinal")
                                End If
                                ln = rowKardexSaldo("CantidadFinal")
                                ln = obj.Item("CantidadFinal")
                            End If
                        End If
                        rowKardexSaldo("ValorUnitario") = PrecioAnterior
                        '----------------------------------------------------
                    End If
                End If

                '-----------------Kardex Detalle-----------------------------
                If obj.Item("TipoOperacion") <> "16" And Negativo = False _
                And lbAgregaKardexSaldo Then 'todos excepto saldos y no es negativo
                    rowKardexDetalle = dt_KardexDetalle.NewRow
                    rowKardexDetalle("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexDetalle.ToString, 9)
                    rowKardexDetalle("IdKardex") = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                    rowKardexDetalle("IdVehiculo") = obj.Item("IdVehiculo")
                    rowKardexDetalle("IdTrabajador") = obj.Item("IdTrabajador")
                    rowKardexDetalle("IdArea") = obj.Item("IdArea")
                    rowKardexDetalle("IdGastoFuncion") = obj.Item("IdGastoFuncion")
                    rowKardexDetalle("IdMaterial") = obj.Item("IdMaterial")
                    rowKardexDetalle("IdmovimientoDocumento") = obj.Item("IdMovimientoDocumento")
                    rowKardexDetalle("TipoOperacion") = obj.Item("TipoOperacion")
                    rowKardexDetalle("Cantidad") = obj.Item("CantidadFinal")
                    rowKardexDetalle("Valor") = IIf(obj.Item("TipoOperacion") = "02", obj.Item("ValorUnitario"), PrecioAnterior)
                    rowKardexDetalle("Operacion") = obj.Item("Operacion")
                    rowKardexDetalle("Fecha") = obj.Item("Fecha")
                    rowKardexDetalle("FechaCreacion") = Date.Now
                    rowKardexDetalle("IdUsuarioCreacion") = oeKardex.IdUsuarioCreacion
                    rowKardexDetalle("IdRegistroInventario") = obj.Item("IdRegInv")
                    rowKardexDetalle("ValorPromedio") = PrecioAnterior
                    dt_KardexDetalle.Rows.Add(rowKardexDetalle)
                    lnNumeroKardexDetalle = lnNumeroKardexDetalle + 1
                End If
                '---------------------------------------------------------------
                If TablaCorte.Rows.Count = Cont Then
                    If lbAgregaKardex Then
                        dt_Kardex.Rows.Add(rowKardex)
                    End If
                    If Not EmpSalida And lbAgregaKardexSaldo Then
                        dt_KardexSaldo.Rows.Add(rowKardexSaldo)
                    End If
                End If
            Next

            odKardex.GuardarMasivo(dt_Kardex, dt_KardexDetalle, dt_KardexSaldo)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function Listar2(ByVal oeKardex As e_Kardex) As DataTable
        Try
            If Validar(oeKardex) Then
                Return odKardex.Listar2(oeKardex)
            End If
            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeKardex As e_Kardex) As Boolean 'Implements Il_OrdenTrabajo.Validar
        Try
            With oeKardex
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdPeriodo, "Seleccione un periodo.")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarCortePeriodos(ByVal oeKardex As e_Kardex) As DataSet
        Try
            Return odKardex.ListarCortePeriodo(oeKardex)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtKardex As DataTable, ByVal dtKardexDetalle As DataTable, ByVal dtKardexSaldo As DataTable) As Boolean
        Try
            Return odKardex.GuardarMasivo(dtKardex, dtKardexDetalle, dtKardexSaldo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta_Kardex(ByVal PrefijoID As String) As String
        Try
            Return odKardex.UltimoIdInserta_Kardex(PrefijoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta_KardexDetalle(ByVal PrefijoID As String) As String
        Try
            Return odKardex.UltimoIdInserta_KardexDetalle(PrefijoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta_KardexSaldo(ByVal PrefijoID As String) As String
        Try
            Return odKardex.UltimoIdInserta_KardexSaldo(PrefijoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarKardex(ByVal oeKardex As e_Kardex) As DataTable
        Try
            Return odKardex.ListarKardex(oeKardex)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
