Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ConfiguracionColumna

    Implements Il_ConfiguracionColumna

    Dim odConfiguracionColumna As New d_ConfiguracionColumna
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean Implements Il_ConfiguracionColumna.Eliminar
        Try
            Return odConfiguracionColumna.Eliminar(oeConfiguracionColumna)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean Implements Il_ConfiguracionColumna.Guardar
        Try
            If Validar(oeConfiguracionColumna) Then
                Return odConfiguracionColumna.Guardar(oeConfiguracionColumna)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeConfiguracionColumna As e_ConfiguracionColumna) As List(Of e_ConfiguracionColumna) Implements Il_ConfiguracionColumna.Listar
        Try
            Return odConfiguracionColumna.Listar(oeConfiguracionColumna)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeConfiguracionColumna As e_ConfiguracionColumna) As e_ConfiguracionColumna Implements Il_ConfiguracionColumna.Obtener
        Try
            Return odConfiguracionColumna.Obtener(oeConfiguracionColumna)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean Implements Il_ConfiguracionColumna.Validar
        Try
            With oeConfiguracionColumna
                l_FuncionesGenerales.ValidarCampoNoNulo(oeConfiguracionColumna.Nombre, "No se ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
