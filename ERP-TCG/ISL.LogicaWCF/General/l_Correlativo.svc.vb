Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Correlativo
    Implements Il_Correlativo

    Dim odCorrelativo As New d_Correlativo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeCorrelativo As EntidadesWCF.e_Correlativo) As Boolean Implements Il_Correlativo.Guardar
        Try
            If Validar(oeCorrelativo) Then
                Return odCorrelativo.Guardar(oeCorrelativo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCorrelativo As EntidadesWCF.e_Correlativo) As System.Collections.Generic.List(Of EntidadesWCF.e_Correlativo) Implements Il_Correlativo.Listar
        Try
            Return odCorrelativo.Listar(oeCorrelativo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCorrelativo As EntidadesWCF.e_Correlativo) As EntidadesWCF.e_Correlativo Implements Il_Correlativo.Obtener
        Try
            oeCorrelativo.Prefijo = oeCorrelativo.PrefijoID
            Return odCorrelativo.Obtener(oeCorrelativo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCorrelativo As EntidadesWCF.e_Correlativo) As Boolean Implements Il_Correlativo.Validar
        Try
            With oeCorrelativo
                l_FuncionesGenerales.ValidarCampoNoNulo(.TipoOperacion, "Tipo Operacion")
                ' l_FuncionesGenerales.ValidarCampoNoNulo(.Prefijo, "Prefijo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Tipo Documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Serie, "Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Numero")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
