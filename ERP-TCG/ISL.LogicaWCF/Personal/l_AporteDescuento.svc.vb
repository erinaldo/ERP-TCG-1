Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AporteDescuento
    Implements Il_AporteDescuento

    Private odAporteDescuento As New d_AporteDescuento
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeAporteDescuento As EntidadesWCF.e_AporteDescuento) As Boolean Implements Il_AporteDescuento.Eliminar
        Try
            Return odAporteDescuento.Eliminar(oeAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeAporteDescuento As EntidadesWCF.e_AporteDescuento) As Boolean Implements Il_AporteDescuento.Guardar
        Try
            If Validar(oeAporteDescuento) Then
                Return odAporteDescuento.Guardar(oeAporteDescuento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeAporteDescuento As EntidadesWCF.e_AporteDescuento) As System.Collections.Generic.List(Of EntidadesWCF.e_AporteDescuento) Implements Il_AporteDescuento.Listar
        Try
            Return odAporteDescuento.Listar(oeAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeAporteDescuento As EntidadesWCF.e_AporteDescuento) As EntidadesWCF.e_AporteDescuento Implements Il_AporteDescuento.Obtener
        Try
            Return odAporteDescuento.Obtener(oeAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeAporteDescuento As EntidadesWCF.e_AporteDescuento) As Boolean Implements Il_AporteDescuento.Validar
        Try
            With oeAporteDescuento
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
