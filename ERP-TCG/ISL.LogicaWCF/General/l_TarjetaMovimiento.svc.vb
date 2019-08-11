' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TarjetaMovimiento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TarjetaMovimiento.svc o l_TarjetaMovimiento.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Globalization

Public Class l_TarjetaMovimiento
    Implements Il_TarjetaMovimiento
    Private odTarjetaMovimiento As d_TarjetaMovimiento


    Public Function Eliminar(oeTarjetaMovimiento As e_TarjetaMovimiento) As Boolean Implements Il_TarjetaMovimiento.Eliminar
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Return odTarjetaMovimiento.Eliminar(oeTarjetaMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeTarjetaMovimiento As e_TarjetaMovimiento) As Boolean Implements Il_TarjetaMovimiento.Guardar
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Return odTarjetaMovimiento.Guardar(oeTarjetaMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeTarjetaMovimiento As e_TarjetaMovimiento) As List(Of EntidadesWCF.e_TarjetaMovimiento) Implements Il_TarjetaMovimiento.Listar
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Return odTarjetaMovimiento.Listar(oeTarjetaMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeTarjetaMovimiento As e_TarjetaMovimiento) As EntidadesWCF.e_TarjetaMovimiento Implements Il_TarjetaMovimiento.Obtener
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Return odTarjetaMovimiento.Obtener(oeTarjetaMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ListaMovTarjeta As List(Of e_TarjetaMovimiento)) As Boolean Implements Il_TarjetaMovimiento.GuardarMasivo
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Dim XML As New StringBuilder
            XML.AppendLine("<DETALLES>")
            Dim Id As String = odTarjetaMovimiento.IdInsertar()
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            For Each _Movimiento As e_TarjetaMovimiento In ListaMovTarjeta
                With _Movimiento
                    XML.AppendLine("<DETALLE><Id>" & lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(Id) - 3) & "</Id>")
                    XML.AppendLine("<NroTarjeta>" & .NroTarjeta & "</NroTarjeta>")
                    XML.AppendLine("<Ticket>" & .Ticket & "</Ticket>")
                    XML.AppendLine("<Fecha>" & .Fecha.ToString("MM/dd/yyyy HH:mm:ss") & "</Fecha>")
                    XML.AppendLine("<Monto>" & Convert.ToDecimal(.Monto, CultureInfo.CreateSpecificCulture("es-PE")) & "</Monto>")
                    XML.AppendLine("<Tipo>" & .Tipo & "</Tipo>")
                    XML.AppendLine("<Lugar>" & .Lugar & "</Lugar>")
                    XML.AppendLine("<Placa>" & .Placa & "</Placa>")
                    XML.AppendLine("<IndIngresado>" & .IndIngresado & "</IndIngresado>")
                    XML.AppendLine("<UsuarioCreacion>" & .UsuarioCreacion & "</UsuarioCreacion></DETALLE>")
                End With
                lsNumero += 1
            Next
            XML.AppendLine("</DETALLES>")
            Return odTarjetaMovimiento.GuardarMasivo(XML.ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String
        Try
            Dim Retorna As String = ""
            For i As Integer = 1 To lnCantidad - Len(ls_Tex)
                Retorna = Retorna & "0"
            Next
            Return Retorna + ls_Tex
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarMasivo(XML As String) As Boolean Implements Il_TarjetaMovimiento.ActualizarMasivo
        Try
            odTarjetaMovimiento = New d_TarjetaMovimiento
            Return odTarjetaMovimiento.ActualizarMasivo(XML)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
