Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "l_CierreCajaDet", también debe actualizar la referencia a "l_CierreCajaDet" tanto en Web.config como en el archivo .svc asociado.
Public Class l_CierreCajaDet
    Implements Il_CierreCajaDet

    Dim odCierreCajaDet As New d_CierreCajaDet

    Public Function Obtener(ByVal oeCierreCajaDet As e_CierreCajaDet) As e_CierreCajaDet Implements Il_CierreCajaDet.Obtener
        Try
            Return odCierreCajaDet.Obtener(oeCierreCajaDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCierreCajaDet As e_CierreCajaDet) As List(Of e_CierreCajaDet) Implements Il_CierreCajaDet.Listar
        Try
            Return odCierreCajaDet.Listar(oeCierreCajaDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean Implements Il_CierreCajaDet.Validar
        Try
            With oeCierreCajaDet
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean Implements Il_CierreCajaDet.Guardar
        Try
            If Validar(oeCierreCajaDet) Then
                Return odCierreCajaDet.Guardar(oeCierreCajaDet)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreCajaDet As e_CierreCajaDet) As Boolean Implements Il_CierreCajaDet.Eliminar
        Try
            Return odCierreCajaDet.Eliminar(oeCierreCajaDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
