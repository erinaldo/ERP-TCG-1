' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_EmpresaSistemas" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_EmpresaSistemas.svc o l_EmpresaSistemas.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_EmpresaSistemas
    Implements Il_EmpresaSistemas

    Public Sub DoWork() Implements Il_EmpresaSistemas.DoWork
    End Sub

    Private odEmpresaSistemas As New d_EmpresaSistemas

    Public Function Obtener(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As e_EmpresaSistemas Implements Il_EmpresaSistemas.Obtener

        Try
            Return odEmpresaSistemas.Obtener(oeEmpresaSistemas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As List(Of e_EmpresaSistemas) Implements Il_EmpresaSistemas.Listar
        Try
            Return odEmpresaSistemas.Listar(oeEmpresaSistemas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean Implements Il_EmpresaSistemas.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeEmpresaSistemas) Then
                bol_guardado = odEmpresaSistemas.Guardar(oeEmpresaSistemas)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean Implements Il_EmpresaSistemas.Eliminar
        Try
            Return odEmpresaSistemas.Eliminar(oeEmpresaSistemas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean
        Try
            With oeEmpresaSistemas
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
