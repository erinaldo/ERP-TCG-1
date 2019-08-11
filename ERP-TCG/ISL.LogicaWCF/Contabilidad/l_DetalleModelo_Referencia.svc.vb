Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleModelo_Referencia
    Implements Il_DetalleModelo_Referencia

    Private odDetModRef As New d_DetalleModelo_Referencia
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleModelo_Referencia As EntidadesWCF.e_DetalleModelo_Referencia) As Boolean Implements Il_DetalleModelo_Referencia.Eliminar
        Try
            Return odDetModRef.Eliminar(oeDetalleModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleModelo_Referencia As EntidadesWCF.e_DetalleModelo_Referencia) As Boolean Implements Il_DetalleModelo_Referencia.Guardar
        Try
            If Validar(oeDetalleModelo_Referencia) Then
                Return odDetModRef.Guardar(oeDetalleModelo_Referencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleModelo_Referencia As EntidadesWCF.e_DetalleModelo_Referencia) As List(Of EntidadesWCF.e_DetalleModelo_Referencia) Implements Il_DetalleModelo_Referencia.Listar
        Try
            Return odDetModRef.Listar(oeDetalleModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleModelo_Referencia As EntidadesWCF.e_DetalleModelo_Referencia) As EntidadesWCF.e_DetalleModelo_Referencia Implements Il_DetalleModelo_Referencia.Obtener
        Try
            Return odDetModRef.Obtener(oeDetalleModelo_Referencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleModelo_Referencia As EntidadesWCF.e_DetalleModelo_Referencia) As Boolean Implements Il_DetalleModelo_Referencia.Validar
        Try
            With oeDetalleModelo_Referencia
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "No ha Seleccionado Tipo Moneda")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
