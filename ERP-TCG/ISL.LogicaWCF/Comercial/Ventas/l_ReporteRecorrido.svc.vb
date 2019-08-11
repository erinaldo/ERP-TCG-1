Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ReporteRecorrido
    Implements Il_ReporteRecorrido

    Dim odReporteRecorrido As New d_ReporteRecorrido
    Dim l_FuncionesGenerales As New l_FuncionesGenerales


    Public Function Listar(ByVal oeReporteRecorrido As EntidadesWCF.e_ReporteRecorrido) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteRecorrido) Implements Il_ReporteRecorrido.Listar
        Try
            Return odReporteRecorrido.Listar(oeReporteRecorrido)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDts(ByVal oeReporteRecorrido As EntidadesWCF.e_ReporteRecorrido) As System.Data.DataSet Implements Il_ReporteRecorrido.ListarDts
        Try
            Dim dts As New DataSet
            dts = odReporteRecorrido.ListarDts(oeReporteRecorrido)
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteRecorrido As EntidadesWCF.e_ReporteRecorrido) As EntidadesWCF.e_ReporteRecorrido Implements Il_ReporteRecorrido.Obtener
        Try
            Return odReporteRecorrido.Obtener(oeReporteRecorrido)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
