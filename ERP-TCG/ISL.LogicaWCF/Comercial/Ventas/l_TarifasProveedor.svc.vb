' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TarifasProveedor" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TarifasProveedor.svc o l_TarifasProveedor.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_TarifasProveedor
    Implements Il_TarifasProveedor

    Dim odTarifasProveedor As New d_TarifasProveedor

    Public Function Obtener(ByVal oeTarifasProveedor As e_TarifasProveedor) As e_TarifasProveedor Implements Il_TarifasProveedor.Obtener
        Try
            Return odTarifasProveedor.Obtener(oeTarifasProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTarifasProveedor As e_TarifasProveedor) As List(Of e_TarifasProveedor) Implements Il_TarifasProveedor.Listar
        Try
            Return odTarifasProveedor.Listar(oeTarifasProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTarifasProveedor(ByVal oeTarifasProveedor As e_TarifasProveedor) As List(Of e_TarifasProveedor)
        Try
            Return odTarifasProveedor.ListarTarifasProveedor(oeTarifasProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Validar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean Implements Il_TarifasProveedor.Validar
        Try
            With oeTarifasProveedor
                If oeTarifasProveedor.Importe = 0 Then Throw New Exception("Importe Tiene que ser Mayor a 0")
                If oeTarifasProveedor.TipoOperacion = "I" Then
                    If oeTarifasProveedor.IdLugar = "" Then Throw New Exception("Seleccione Lugar")
                    Dim oeTarPro As New e_TarifasProveedor
                    oeTarPro.TipoOperacion = ""
                    oeTarPro.IdLugar = .IdLugar
                    oeTarPro.IdProveedor = .IdProveedor
                    oeTarPro.IdFlujoCaja = .IdFlujoCaja
                    oeTarPro.IdMaterial = .IdMaterial
                    oeTarPro.IdCliente = .IdCliente
                    oeTarPro = odTarifasProveedor.Obtener(oeTarPro)
                    If oeTarPro.Id <> "" Then
                        Throw New Exception("Tarifa para Proveedor/Cliente/Material/Lugar ya Ingresada")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean Implements Il_TarifasProveedor.Guardar
        Try
            If Validar(oeTarifasProveedor) Then
                Return odTarifasProveedor.Guardar(oeTarifasProveedor)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean Implements Il_TarifasProveedor.Eliminar
        Try
            Return odTarifasProveedor.Eliminar(oeTarifasProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class