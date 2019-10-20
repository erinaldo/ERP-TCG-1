Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DerechoHabiente
    Implements Il_DerechoHabiente

    Private odDerechoHabiente As New d_DerechoHabiente
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDerechoHabiente As e_DerechoHabiente) As Boolean Implements Il_DerechoHabiente.Eliminar
        Try
            Return odDerechoHabiente.Eliminar(oeDerechoHabiente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDerechoHabiente As e_DerechoHabiente) As Boolean Implements Il_DerechoHabiente.Guardar
        Try
            If Validar(oeDerechoHabiente) Then
                Return odDerechoHabiente.Guardar(oeDerechoHabiente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDerechoHabiente As e_DerechoHabiente) As List(Of e_DerechoHabiente) Implements Il_DerechoHabiente.Listar
        Try
            Return odDerechoHabiente.Listar(oeDerechoHabiente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDerechoHabiente As e_DerechoHabiente) As e_DerechoHabiente Implements Il_DerechoHabiente.Obtener
        Try
            Return odDerechoHabiente.Obtener(oeDerechoHabiente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDerechoHabiente As e_DerechoHabiente) As Boolean Implements Il_DerechoHabiente.Validar
        Try
            'With oeAporteDescuento
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
            '    If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            'End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
