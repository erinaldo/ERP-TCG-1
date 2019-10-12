'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

Public Class l_MontoRuta
    Implements Il_MontoRuta

    Dim odMontoRuta As New d_MontoRuta

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_MontoRuta.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function Obtener(ByVal oeMontoRuta As e_MontoRuta) As e_MontoRuta Implements Il_MontoRuta.Obtener
        Try
            Return odMontoRuta.Obtener(oeMontoRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMontoRuta As e_MontoRuta) As List(Of e_MontoRuta) Implements Il_MontoRuta.Listar
        Try
            Return odMontoRuta.Listar(oeMontoRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeMontoRuta As e_MontoRuta) As Boolean Implements Il_MontoRuta.Validar
        Try
            Dim oeMonRut As New e_MontoRuta
            With oeMontoRuta
                If .TipoOperacion = "I" Then
                    oeMonRut.TipoOperacion = "1"
                    oeMonRut.IdTipoVehiculo = .IdTipoVehiculo
                    oeMonRut.IdRuta = .IdRuta
                    oeMonRut.IndCargado = .IndCargado
                    oeMonRut = odMontoRuta.Obtener(oeMonRut)
                    If oeMonRut.Id <> "" Then
                        Throw New Exception("Monto de Ruta ya Registrado. Verificar")
                    End If
                ElseIf .TipoOperacion = "A" Then
                    Dim loMontRuta As New List(Of e_MontoRuta)
                    oeMonRut.TipoOperacion = "1"
                    oeMonRut.IdTipoVehiculo = .IdTipoVehiculo
                    oeMonRut.IdRuta = .IdRuta
                    oeMonRut.IndCargado = .IndCargado
                    loMontRuta = odMontoRuta.Listar(oeMonRut)
                    If loMontRuta.Where(Function(i) i.Id <> oeMontoRuta.Id).Count > 0 Then
                        Throw New Exception("Monto de Ruta ya Registrado. Verificar")
                    End If
                End If
                If .IdTipoVehiculo = "" Then Throw New Exception("Seleccione Tipo de Vehiculo")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoRuta As e_MontoRuta) As Boolean Implements Il_MontoRuta.Guardar
        Try
            If Validar(oeMontoRuta) Then
                Return odMontoRuta.Guardar(oeMontoRuta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_MontoRuta.CrearDT
        Dim MontoRuta As New Data.DataTable
        With MontoRuta
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoVehiculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRuta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndCargado", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndNacional", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndCategoria", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("Cuenta", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("MontoSolo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoAcompañado", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeCopiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeAyudante", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoSolo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoCruceroPiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoCruceroCopiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Kilometraje", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Vigencia", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModificacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModificacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return MontoRuta
    End Function

    Public Function GuardarMasivo(ByVal leMontoRuta As System.Collections.Generic.List(Of EntidadesWCF.e_MontoRuta), ByVal PrefijoID As String) As Boolean Implements Il_MontoRuta.GuardarMasivo
        Try
            Dim dtCCP As Data.DataTable = CrearDT()
            Dim id As String = odMontoRuta.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))
            For Each montoruta In leMontoRuta
                Dim rwCCP As Data.DataRow
                rwCCP = dtCCP.NewRow
                With montoruta
                    rwCCP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 12)
                    rwCCP("IdTipoVehiculo") = .IdTipoVehiculo
                    rwCCP("IdRuta") = .IdRuta
                    rwCCP("IndCargado") = .IndCargado
                    rwCCP("Cuenta") = .Cuenta
                    rwCCP("IndNacional") = .IndNacional
                    rwCCP("IndCategoria") = .IndCategoria
                    rwCCP("MontoSolo") = .MontoSolo
                    rwCCP("MontoAcompañado") = .MontoAcompañado
                    rwCCP("PorcentajeCopiloto") = .PorcentajeCopiloto
                    rwCCP("PorcentajeAyudante") = .PorcentajeAyudante
                    rwCCP("BonoSolo") = .BonoSolo
                    rwCCP("BonoCruceroPiloto") = .BonoCruceroPiloto
                    rwCCP("BonoCruceroCopiloto") = .BonoCruceroCopiloto
                    rwCCP("Kilometraje") = .Kilometraje
                    rwCCP("Vigencia") = .Vigencia
                    rwCCP("FechaCreacion") = Date.Now
                    rwCCP("UsuarioCreacion") = .UsuarioCreacion
                    rwCCP("Activo") = True
                End With
                dtCCP.Rows.Add(rwCCP)
                lsNumero = lsNumero + 1
            Next
            Return odMontoRuta.GuardarMasivo(dtCCP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMontoRuta As e_MontoRuta) As Boolean Implements Il_MontoRuta.Eliminar
        Try
            Return odMontoRuta.Eliminar(oeMontoRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
