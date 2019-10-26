Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OrdenVentaMaterial" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OrdenVentaMaterial.svc o l_OrdenVentaMaterial.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_OrdenVentaMaterial
    Implements Il_OrdenVentaMaterial

    Private od_OrdenVentaMaterial As New d_OrdenVentaMaterial

    Public Function Obtener(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As e_OrdenVentaMaterial Implements Il_OrdenVentaMaterial.Obtener
        Try
            oeOrdenComercial_Material = od_OrdenVentaMaterial.Obtener(oeOrdenComercial_Material)
            Return oeOrdenComercial_Material
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As List(Of e_OrdenVentaMaterial) Implements Il_OrdenVentaMaterial.Listar
        Try
            Dim lstOrdenComercial_Material As New List(Of e_OrdenVentaMaterial)
            lstOrdenComercial_Material = od_OrdenVentaMaterial.Listar(oeOrdenComercial_Material)
            Return lstOrdenComercial_Material
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean Implements Il_OrdenVentaMaterial.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeOrdenComercial_Material) Then
                bol_guardado = od_OrdenVentaMaterial.Guardar(oeOrdenComercial_Material)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean Implements Il_OrdenVentaMaterial.Eliminar
        Try
            Return od_OrdenVentaMaterial.Eliminar(oeOrdenComercial_Material)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeOrdenComercial_Material As e_OrdenVentaMaterial) As Boolean
        Try
            With oeOrdenComercial_Material
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
