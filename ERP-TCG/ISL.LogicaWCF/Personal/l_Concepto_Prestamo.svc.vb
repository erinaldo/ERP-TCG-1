Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Concepto_Prestamo
    Implements Il_Concepto_Prestamo

    Dim odConcepto_Prestamo As New d_Concepto_Prestamo

    Public Function Eliminar(ByVal oeConcepto_Prestamo As EntidadesWCF.e_Concepto_Prestamo) As Boolean Implements Il_Concepto_Prestamo.Eliminar
        Try
            Return odConcepto_Prestamo.Eliminar(oeConcepto_Prestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConcepto_Prestamo As EntidadesWCF.e_Concepto_Prestamo) As Boolean Implements Il_Concepto_Prestamo.Guardar
        Try
            If Validar(oeConcepto_Prestamo) Then
                Return odConcepto_Prestamo.GuardarPrestamo(oeConcepto_Prestamo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConcepto_Prestamo As EntidadesWCF.e_Concepto_Prestamo) As System.Collections.Generic.List(Of EntidadesWCF.e_Concepto_Prestamo) Implements Il_Concepto_Prestamo.Listar
        Try
            Return odConcepto_Prestamo.Listar(oeConcepto_Prestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConcepto_Prestamo As EntidadesWCF.e_Concepto_Prestamo) As EntidadesWCF.e_Concepto_Prestamo Implements Il_Concepto_Prestamo.Obtener
        Try
            Return odConcepto_Prestamo.Obtener(oeConcepto_Prestamo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConcepto_Prestamo As EntidadesWCF.e_Concepto_Prestamo) As Boolean Implements Il_Concepto_Prestamo.Validar
        Try
            With oeConcepto_Prestamo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
