Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_CierreTurno_Detalle
    Implements Il_CierreTurno_Detalle
    Private odCierreTurno_Detalle As New d_CierreTurno_Detalle

    Public Function Obtener(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle Implements Il_CierreTurno_Detalle.Obtener

        Try
            Return odCierreTurno_Detalle.Obtener(oeCierreTurno_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As List(Of e_CierreTurno_Detalle) Implements Il_CierreTurno_Detalle.Listar
        Try
            Return odCierreTurno_Detalle.Listar(oeCierreTurno_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle Implements Il_CierreTurno_Detalle.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeCierreTurno_Detalle) Then
                oeCierreTurno_Detalle = odCierreTurno_Detalle.Guardar(oeCierreTurno_Detalle)
            End If
            Return oeCierreTurno_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As Boolean Implements Il_CierreTurno_Detalle.Eliminar
        Try
            Return odCierreTurno_Detalle.Eliminar(oeCierreTurno_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As Boolean
        Try
            With oeCierreTurno_Detalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
