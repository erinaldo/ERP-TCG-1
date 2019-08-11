Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClientePrima" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClientePrima.svc o l_ClientePrima.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClientePrima
    Implements Il_ClientePrima

    Dim odClientePrima As New d_ClientePrima

    Public Function Obtener(ByVal oeClientePrima As e_ClientePrima) As e_ClientePrima Implements Il_ClientePrima.Obtener
        Try
            Return odClientePrima.Obtener(oeClientePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeClientePrima As e_ClientePrima) As List(Of e_ClientePrima) Implements Il_ClientePrima.Listar
        Try
            Return odClientePrima.Listar(oeClientePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeClientePrima As e_ClientePrima) As Boolean Implements Il_ClientePrima.Validar
        Try
            With oeClientePrima
                If .IdCliente = "" Then Throw New Exception("Seleccione Cliente")
                If .IdMoneda = "" Then Throw New Exception("Seleccione Moneda")
                If .MontoAsegurado = 0 Then Throw New Exception("El Importe Tiene que ser Mayor a 0")
                Dim oe As New e_ClientePrima
                oe.TipoOperacion = ""
                oe.IdCliente = .IdCliente
                oe.IdMoneda = .IdMoneda
                oe.Vigente = .Vigente
                oe = odClientePrima.Obtener(oe)
                If oe.Id <> "" Then Throw New Exception("Cliente Ya Registrado. Verificar")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeClientePrima As e_ClientePrima) As Boolean Implements Il_ClientePrima.Guardar
        Try
            If Validar(oeClientePrima) Then
                Return odClientePrima.Guardar(oeClientePrima)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeClientePrima As e_ClientePrima) As Boolean Implements Il_ClientePrima.Eliminar
        Try
            Return odClientePrima.Eliminar(oeClientePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
