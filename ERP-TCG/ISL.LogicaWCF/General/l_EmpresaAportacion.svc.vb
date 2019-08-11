Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_EmpresaAportacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_EmpresaAportacion.svc o l_EmpresaAportacion.svc.vb en el Explorador de soluciones e inicie la depuración.

Public Class l_EmpresaAportacion
    Implements Il_EmpresaAportacion

    Dim odEmpresaAportacion As New d_EmpresaAportacion

    Public Function Obtener(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As e_EmpresaAportacion Implements Il_EmpresaAportacion.Obtener
        Try
            Return odEmpresaAportacion.Obtener(oeEmpresaAportacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As Boolean Implements Il_EmpresaAportacion.Validar
        Try
            With oeEmpresaAportacion
                If .IndSistemaPension <> 2 Then
                    If .IdEmpresaPensiones = "" Then Throw New Exception("Seleccione Empresa de Aseguradora")
                    If .IndSistemaPension = 0 And .IdEmpresaPensiones <> "1CH000010168" Then Throw New Exception("SNP es solo para la ONP")
                    If .IndSistemaPension = 1 And .IdEmpresaPensiones = "1CH000010168" Then Throw New Exception("SPP no puede ser la ONP")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As Boolean Implements Il_EmpresaAportacion.Guardar
        Try
            If Validar(oeEmpresaAportacion) Then
                Return odEmpresaAportacion.Guardar(oeEmpresaAportacion)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
