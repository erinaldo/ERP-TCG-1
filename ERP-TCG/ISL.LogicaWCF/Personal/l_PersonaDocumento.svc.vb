Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_PersonaDocumento
    Implements Il_PersonaDocumento

    Private odPersonaDocumento As New d_PersonaDocumento
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_PersonaDocumento.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_PersonaDocumento.CrearDT
        Dim CtaCtePer As New Data.DataTable
        With CtaCtePer
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPersona", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaActividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaVencimiento", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Vigente", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return CtaCtePer
    End Function

    Public Function Eliminar(oePersonaDocumento As EntidadesWCF.e_PersonaDocumento) As Boolean Implements Il_PersonaDocumento.Eliminar
        Try
            Return odPersonaDocumento.Eliminar(oePersonaDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePersonaDocumento As EntidadesWCF.e_PersonaDocumento) As Boolean Implements Il_PersonaDocumento.Guardar
        Try
            If Validar(oePersonaDocumento) Then
                Return odPersonaDocumento.Guardar(oePersonaDocumento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(lePersonaDocumento As System.Collections.Generic.List(Of EntidadesWCF.e_PersonaDocumento), ByVal PrefijoID As String) As Boolean Implements Il_PersonaDocumento.GuardarMasivo
        Try
            Dim dtPD As Data.DataTable = CrearDT()
            Dim id As String = odPersonaDocumento.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 12)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 12))

            For Each oeRegPen In lePersonaDocumento
                Dim rwPD As Data.DataRow
                rwPD = dtPD.NewRow
                With oeRegPen
                    rwPD("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 3)
                    rwPD("IdPersona") = .IdPersona
                    rwPD("IdTipoDocumento") = .IdTipoDocumento
                    rwPD("NumeroDocumento") = .NumeroDocumento
                    rwPD("Descripcion") = .Descripcion
                    rwPD("FechaActividad") = .FechaActividad
                    rwPD("FechaVencimiento") = .FechaVencimiento
                    rwPD("Vigente") = .Vigente
                    rwPD("FechaCreacion") = Date.Now
                    rwPD("UsuarioCreacion") = .UsuarioCreacion
                    rwPD("Activo") = True
                End With
                dtPD.Rows.Add(rwPD)
                lsNumero = lsNumero + 1
            Next
            Return odPersonaDocumento.GuardarMasivo(dtPD)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oePersonaDocumento As EntidadesWCF.e_PersonaDocumento) As System.Collections.Generic.List(Of EntidadesWCF.e_PersonaDocumento) Implements Il_PersonaDocumento.Listar
        Try
            Return odPersonaDocumento.Listar(oePersonaDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePersonaDocumento As EntidadesWCF.e_PersonaDocumento) As EntidadesWCF.e_PersonaDocumento Implements Il_PersonaDocumento.Obtener
        Try
            Return odPersonaDocumento.Obtener(oePersonaDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePersonaDocumento As EntidadesWCF.e_PersonaDocumento) As Boolean Implements Il_PersonaDocumento.Validar
        Try
            With oePersonaDocumento
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdPersona, "No ha Ingresado Persona")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "No ha Ingresado Tipo Documento")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
