'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: si cambia aquí el nombre de clase "l_ValesRendir", también debe actualizar la referencia a "l_ValesRendir" tanto en Web.config como en el archivo .svc asociado.
Public Class l_ValesRendir
    Implements Il_ValesRendir
    Dim odValesRendir As New d_ValesRendir

    Public Function Obtener(ByVal oeValesRendir As e_ValesRendir) As e_ValesRendir
        Try
            Return odValesRendir.Obtener(oeValesRendir)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeValesRendir As e_ValesRendir) As List(Of e_ValesRendir)
        Try
            Return odValesRendir.Listar(oeValesRendir)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeValesRendir As e_ValesRendir) As Boolean
        Try
            With oeValesRendir
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeValesRendir As e_ValesRendir) As Boolean
        Try
            If Validar(oeValesRendir) Then
                Return odValesRendir.Guardar(oeValesRendir)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function RendirVale(ByVal oeValesRendir As e_ValesRendir, ByVal oeValesRendido As e_ValesRendir) As Boolean
        Try
            Return odValesRendir.Rendir(oeValesRendir, oeValesRendido)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeValesRendir As e_ValesRendir) As Boolean
        Try
            Return odValesRendir.Eliminar(oeValesRendir)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_ValesRendir.DoWork
    End Sub

End Class
