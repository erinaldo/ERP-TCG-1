Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_CierreTurno
    Implements Il_CierreTurno
    Private odCierreTurno As New d_CierreTurno

    Public Function Obtener(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno Implements Il_CierreTurno.Obtener

        Try
            Return odCierreTurno.Obtener(oeCierreTurno)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCierreTurno As e_CierreTurno) As List(Of e_CierreTurno) Implements Il_CierreTurno.Listar
        Try
            Return odCierreTurno.Listar(oeCierreTurno)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno Implements Il_CierreTurno.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeCierreTurno) Then
                oeCierreTurno = odCierreTurno.Guardar(oeCierreTurno)
            End If
            Return oeCierreTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreTurno As e_CierreTurno) As Boolean Implements Il_CierreTurno.Eliminar
        Try
            Return odCierreTurno.Eliminar(oeCierreTurno)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal oeCierreTurno As e_CierreTurno) As Boolean
        Try
            With oeCierreTurno
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
