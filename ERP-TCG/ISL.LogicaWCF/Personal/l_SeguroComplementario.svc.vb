Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_SeguroComplementario
    Implements Il_SeguroComplementario

    Private odSeguroComplementario As New d_SeguroComplementrio
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeSeguroComplementario As e_SeguroComplementario) As Boolean Implements Il_SeguroComplementario.Eliminar
        Try
            Return odSeguroComplementario.Eliminar(oeSeguroComplementario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeSeguroComplementario As e_SeguroComplementario) As Boolean Implements Il_SeguroComplementario.Guardar
        Try
            If Validar(oeSeguroComplementario) Then
                Return odSeguroComplementario.Guardar(oeSeguroComplementario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeSeguroComplementario As e_SeguroComplementario) As List(Of e_SeguroComplementario) Implements Il_SeguroComplementario.Listar
        Try
            Return odSeguroComplementario.Listar(oeSeguroComplementario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeSeguroComplementario As e_SeguroComplementario) As e_SeguroComplementario Implements Il_SeguroComplementario.Obtener
        Try
            Return odSeguroComplementario.Obtener(oeSeguroComplementario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeSeguroComplementario As e_SeguroComplementario) As Boolean Implements Il_SeguroComplementario.Validar
        Try
            With oeSeguroComplementario
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
