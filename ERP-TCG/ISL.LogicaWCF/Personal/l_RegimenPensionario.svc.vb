Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RegimenPensionario
    Implements Il_RegimenPensionario

    Private odRegimenPensionario As New d_RegimenPensionario
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeRegimenPensionario As EntidadesWCF.e_RegimenPensionario) As Boolean Implements Il_RegimenPensionario.Eliminar
        Try
            Return odRegimenPensionario.Eliminar(oeRegimenPensionario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegimenPensionario As EntidadesWCF.e_RegimenPensionario) As Boolean Implements Il_RegimenPensionario.Guardar
        Try
            If Validar(oeRegimenPensionario) Then
                Return odRegimenPensionario.Guardar(oeRegimenPensionario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegimenPensionario As EntidadesWCF.e_RegimenPensionario) As System.Collections.Generic.List(Of EntidadesWCF.e_RegimenPensionario) Implements Il_RegimenPensionario.Listar
        Try
            Return odRegimenPensionario.Listar(oeRegimenPensionario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRegimenPensionario As EntidadesWCF.e_RegimenPensionario) As EntidadesWCF.e_RegimenPensionario Implements Il_RegimenPensionario.Obtener
        Try
            Return odRegimenPensionario.Obtener(oeRegimenPensionario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRegimenPensionario As EntidadesWCF.e_RegimenPensionario) As Boolean Implements Il_RegimenPensionario.Validar
        Try
            With oeRegimenPensionario
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresa, "No ha Ingresado Empresa")
                If .PorcentajeObligatorio = 0 Then Throw New Exception("No ha Ingresado Porcentaje Obligatorio")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal leRegimenPensionario As System.Collections.Generic.List(Of EntidadesWCF.e_RegimenPensionario), ByVal PrefijoID As String) As Boolean Implements Il_RegimenPensionario.GuardarMasivo
        Try
            Dim dtRP As Data.DataTable = CrearDT()
            Dim id As String = odRegimenPensionario.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeRegPen In leRegimenPensionario
                Dim rwRP As Data.DataRow
                rwRP = dtRP.NewRow
                With oeRegPen
                    rwRP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 3)
                    rwRP("IdEmpresa") = .IdEmpresa
                    rwRP("PorcentajeObligatorio") = .PorcentajeObligatorio
                    rwRP("PorcentajeComision") = .PorcentajeComision
                    rwRP("PorcentajeSeguros") = .PorcentajeSeguros
                    rwRP("PorcentajeComisionMixta") = .PorcentajeComisionMixta
                    rwRP("PorcentajeSaldoMixta") = .PorcentajeSaldoMixta
                    rwRP("PorcentajeObligatorio2") = .PorcentajeObligatorio2
                    rwRP("RenumeracionMaxima") = .RenumeracionMaxima
                    rwRP("Vigente") = True
                    rwRP("FechaActividad") = .FechaActividad
                    rwRP("FechaInactividad") = #1/1/1901#
                    rwRP("FechaCreacion") = Date.Now
                    rwRP("UsuarioCreacion") = .UsuarioCreacion
                    rwRP("Activo") = True
                End With
                dtRP.Rows.Add(rwRP)
                lsNumero = lsNumero + 1
            Next
            Return odRegimenPensionario.GuardarMasivo(dtRP)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_RegimenPensionario.CrearDT
        Dim RegPen As New Data.DataTable
        With RegPen
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEmpresa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("PorcentajeObligatorio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeComision", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeSeguros", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeComisionMixta", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeSaldoMixta", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeObligatorio2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RenumeracionMaxima", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Vigente", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaActividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaInactividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return RegPen
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_RegimenPensionario.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

End Class
