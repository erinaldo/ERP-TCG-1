'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_EquivalenciaRuta
    Implements Il_EquivalenciaRuta

    Dim odEquivalenciaRuta As New d_EquivalenciaRuta

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_EquivalenciaRuta.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function Obtener(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As e_EquivalenciaRuta Implements Il_EquivalenciaRuta.Obtener
        Try
            Return odEquivalenciaRuta.Obtener(oeEquivalenciaRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As List(Of e_EquivalenciaRuta) Implements Il_EquivalenciaRuta.Listar
        Try
            Return odEquivalenciaRuta.Listar(oeEquivalenciaRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean Implements Il_EquivalenciaRuta.Validar
        Try
            With oeEquivalenciaRuta
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean Implements Il_EquivalenciaRuta.Guardar
        Try
            If Validar(oeEquivalenciaRuta) Then
                Return odEquivalenciaRuta.Guardar(oeEquivalenciaRuta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean Implements Il_EquivalenciaRuta.Eliminar
        Try
            Return odEquivalenciaRuta.Eliminar(oeEquivalenciaRuta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_EquivalenciaRuta.CrearDT
        Dim MontoRuta As New Data.DataTable
        With MontoRuta
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRuta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cuenta", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Equivalencia", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return MontoRuta
    End Function

    Public Function GuardarMasivo(ByVal loEquivalenciaRuta As System.Collections.Generic.List(Of EntidadesWCF.e_EquivalenciaRuta), ByVal PrefijoID As String) As Boolean Implements Il_EquivalenciaRuta.GuardarMasivo
        Try
            Dim dtCCP As Data.DataTable = CrearDT()
            Dim id As String = odEquivalenciaRuta.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))
            For Each montoruta In loEquivalenciaRuta
                Dim rwCCP As Data.DataRow
                rwCCP = dtCCP.NewRow
                With montoruta
                    rwCCP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 12)
                    rwCCP("IdRuta") = .IdRuta
                    rwCCP("Cuenta") = .Cuenta
                    rwCCP("Monto") = .Monto
                    rwCCP("Equivalencia") = .Equivalencia
                    rwCCP("FechaCreacion") = Date.Now
                    rwCCP("UsuarioCreacion") = .UsuarioCreacion
                    rwCCP("Activo") = True
                End With
                dtCCP.Rows.Add(rwCCP)
                lsNumero = lsNumero + 1
            Next
            Return odEquivalenciaRuta.GuardarMasivo(dtCCP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
