Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_TipoActivoFijo_CtaCtble
    Implements Il_TipoActivoFijo_CtaCtble

    Private odTipoActivoFijo_CtaCtble As New d_TipoActivoFijo_CtaCtble

    Public Function Obtener(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As e_TipoActivoFijo_CtaCtble Implements Il_TipoActivoFijo_CtaCtble.Obtener
        Try
            Return odTipoActivoFijo_CtaCtble.Obtener(oeTipoActivoFijo_CtaCtble)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As List(Of e_TipoActivoFijo_CtaCtble) Implements Il_TipoActivoFijo_CtaCtble.Listar
        Try
            Return odTipoActivoFijo_CtaCtble.Listar(oeTipoActivoFijo_CtaCtble)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean Implements Il_TipoActivoFijo_CtaCtble.Guardar
        Try
            Return odTipoActivoFijo_CtaCtble.Guardar(oeTipoActivoFijo_CtaCtble)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean Implements Il_TipoActivoFijo_CtaCtble.Eliminar
        Try
            Return odTipoActivoFijo_CtaCtble.Eliminar(oeTipoActivoFijo_CtaCtble)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
