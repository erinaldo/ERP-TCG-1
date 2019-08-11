Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsientoModelo_Referencia
    Implements Il_AsientoModelo_Referencia

    Private odAsiModRef As New d_AsientoModelo_Referencia
    Private l_FuncionesGenerales As New l_FuncionesGenerales
    Public Function Eliminar(oeAsientoModelo_Referencia As EntidadesWCF.e_AsientoModelo_Referencia) As Boolean Implements Il_AsientoModelo_Referencia.Eliminar
        Try
            Return odAsiModRef.Eliminar(oeAsientoModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeAsientoModelo_Referencia As EntidadesWCF.e_AsientoModelo_Referencia) As Boolean Implements Il_AsientoModelo_Referencia.Guardar
        Try
            If Validar(oeAsientoModelo_Referencia) Then
                Return odAsiModRef.Guardar(oeAsientoModelo_Referencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeAsientoModelo_Referencia As EntidadesWCF.e_AsientoModelo_Referencia) As List(Of EntidadesWCF.e_AsientoModelo_Referencia) Implements Il_AsientoModelo_Referencia.Listar
        Try
            Return odAsiModRef.Listar(oeAsientoModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeAsientoModelo_Referencia As EntidadesWCF.e_AsientoModelo_Referencia) As EntidadesWCF.e_AsientoModelo_Referencia Implements Il_AsientoModelo_Referencia.Obtener
        Try
            Return odAsiModRef.Obtener(oeAsientoModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeAsientoModelo_Referencia As EntidadesWCF.e_AsientoModelo_Referencia) As Boolean Implements Il_AsientoModelo_Referencia.Validar
        Try
            With oeAsientoModelo_Referencia
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "No ha Seleccionado Tipo Moneda")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar2(oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As List(Of e_AsientoModelo_Referencia) Implements Il_AsientoModelo_Referencia.Listar2
        Try
            Return odAsiModRef.Listar2(oeAsientoModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
