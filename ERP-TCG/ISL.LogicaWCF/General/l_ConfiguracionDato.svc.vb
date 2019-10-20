Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ConfiguracionDato
    Implements Il_ConfiguracionDato

    Dim odConfiguracionDato As New d_ConfiguracionDato
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeConfiguracionDato As e_ConfiguracionDato) As Boolean Implements Il_ConfiguracionDato.Eliminar
        Try
            Return odConfiguracionDato.Eliminar(oeConfiguracionDato)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeConfiguracionDato As e_ConfiguracionDato) As Boolean Implements Il_ConfiguracionDato.Guardar
        Try
            If Validar(oeConfiguracionDato) Then
                Return odConfiguracionDato.Guardar(oeConfiguracionDato)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeConfiguracionDato As e_ConfiguracionDato) As List(Of e_ConfiguracionDato) Implements Il_ConfiguracionDato.Listar
        Try
            Return odConfiguracionDato.Listar(oeConfiguracionDato)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeConfiguracionDato As e_ConfiguracionDato) As e_ConfiguracionDato Implements Il_ConfiguracionDato.Obtener
        Try
            Return odConfiguracionDato.Obtener(oeConfiguracionDato)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeConfiguracionDato As e_ConfiguracionDato) As Boolean Implements Il_ConfiguracionDato.Validar
        Try
            With oeConfiguracionDato
                ' l_FuncionesGenerales.ValidarCampoNoNulo(oeConfiguracionDato.Descripcion , "No se ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_ConfiguracionDato.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_ConfiguracionDato.CrearDT
        Dim CtaCtePer As New Data.DataTable
        With CtaCtePer
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdColumna", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroFila", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return CtaCtePer
    End Function

End Class
