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

<DataContract(), Serializable()> _
Public Class l_CuentaCtePersonal
    Implements Il_CuentaCtePersonal

    Private odCuentaCtePersonal As New d_CuentaCtePersonal
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_CuentaCtePersonal.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_CuentaCtePersonal.CrearDT
        Dim CtaCtePer As New Data.DataTable
        With CtaCtePer
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEntidadBancaria", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMoneda", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroCuenta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoConcepto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPersona", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Vinculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Vigente", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return CtaCtePer
    End Function

    Public Function Eliminar(ByVal oeCuentaCtePersonal As EntidadesWCF.e_CuentaCtePersonal) As Boolean Implements Il_CuentaCtePersonal.Eliminar
        Try
            Return odCuentaCtePersonal.Eliminar(oeCuentaCtePersonal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaCtePersonal As EntidadesWCF.e_CuentaCtePersonal) As Boolean Implements Il_CuentaCtePersonal.Guardar
        Try
            If Validar(oeCuentaCtePersonal) Then
                Return odCuentaCtePersonal.Guardar(oeCuentaCtePersonal)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal leCuentaCtePersonal As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaCtePersonal), ByVal PrefijoID As String) As Boolean Implements Il_CuentaCtePersonal.GuardarMasivo
        Try
            Dim dtCCP As Data.DataTable = CrearDT()
            Dim id As String = odCuentaCtePersonal.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeRegPen In leCuentaCtePersonal
                Dim rwCCP As Data.DataRow
                rwCCP = dtCCP.NewRow
                With oeRegPen
                    rwCCP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwCCP("IdTrabajador") = .IdTrabajador
                    rwCCP("IdEntidadBancaria") = .IdEntidadBancaria
                    rwCCP("IdMoneda") = .IdMoneda
                    rwCCP("NroCuenta") = .NroCuenta
                    rwCCP("TipoConcepto") = .TipoConcepto
                    rwCCP("IdPersona") = ""
                    rwCCP("Vinculo") = ""
                    rwCCP("Vigente") = .Vigente
                    rwCCP("FechaCreacion") = Date.Now
                    rwCCP("UsuarioCreacion") = .UsuarioCreacion
                    rwCCP("Activo") = True
                End With
                dtCCP.Rows.Add(rwCCP)
                lsNumero = lsNumero + 1
            Next
            Return odCuentaCtePersonal.GuardarMasivo(dtCCP)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaCtePersonal As EntidadesWCF.e_CuentaCtePersonal) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaCtePersonal) Implements Il_CuentaCtePersonal.Listar
        Try
            Return odCuentaCtePersonal.Listar(oeCuentaCtePersonal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaCtePersonal As EntidadesWCF.e_CuentaCtePersonal) As EntidadesWCF.e_CuentaCtePersonal Implements Il_CuentaCtePersonal.Obtener
        Try
            Return odCuentaCtePersonal.Obtener(oeCuentaCtePersonal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaCtePersonal As EntidadesWCF.e_CuentaCtePersonal) As Boolean Implements Il_CuentaCtePersonal.Validar
        Try
            With oeCuentaCtePersonal
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "No ha Ingresado Trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdEntidadBancaria, "No ha Ingresado Entidad Bancaria")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "No ha Ingresado Moneda")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NroCuenta, "No ha Ingresado Numero de Cuenta")
                l_FuncionesGenerales.ValidarCampoNoNulo(.TipoConcepto, "No ha Seleccionado Tipo de Concepto")
                If .TipoConcepto = "JUDICIAL" Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdBeneficiario, "No ha Seleccionado Beneficiario")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Vinculo, "No ha Seleccionado Vinculo")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
