' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_RecargaPeaje" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_RecargaPeaje.svc o l_RecargaPeaje.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Globalization

Public Class l_RecargaPeaje
    Implements Il_RecargaPeaje
    Private odRecargaPeaje As d_RecargaPeaje

    Public Function Guardar(oeRecargaPeaje As e_RecargaPeaje) As Boolean Implements Il_RecargaPeaje.Guardar
        Try
            'odRecargaPeaje = New d_RecargaPeaje

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ListaRecargaPeaje As List(Of e_RecargaPeaje), ByVal PrefijoID As String) As Boolean Implements Il_RecargaPeaje.GuardarMasivo
        Try
            odRecargaPeaje = New d_RecargaPeaje
            Dim XML As New StringBuilder
            XML.AppendLine("<DETALLES>")
            Dim Id As String = odRecargaPeaje.IdInsertar(PrefijoID)
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            For Each _Movimiento As e_RecargaPeaje In ListaRecargaPeaje
                With _Movimiento
                    XML.AppendLine("<DETALLE><Id>" & lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(Id) - 3) & "</Id>")
                    XML.AppendLine("<IdMoneda>" & .IdMoneda & "</IdMoneda>")
                    XML.AppendLine("<IdTipoDocumento>" & .IdTipoDocumento & "</IdTipoDocumento>")
                    XML.AppendLine("<Fecha>" & .Fecha.ToString("MM/dd/yyyy HH:mm:ss") & "</Fecha>")
                    XML.AppendLine("<Serie>" & .Serie & "</Serie>")
                    XML.AppendLine("<Numero>" & .Numero & "</Numero>")
                    XML.AppendLine("<IdEstado>" & .IdEstado & "</IdEstado>")
                    XML.AppendLine("<IdVehiculoTarjeta>" & .IdVehiculoTarjeta & "</IdVehiculoTarjeta>")
                    XML.AppendLine("<MontoTotal>" & Convert.ToDecimal(.MontoTotal, CultureInfo.CreateSpecificCulture("es-PE")) & "</MontoTotal>")
                    XML.AppendLine("<MontoTarjeta>" & Convert.ToDecimal(.MontoTarjeta, CultureInfo.CreateSpecificCulture("es-PE")) & "</MontoTarjeta>")
                    XML.AppendLine("<Glosa>" & .Glosa & "</Glosa>")
                    XML.AppendLine("<UsuarioCreacion>" & .UsuarioCreacion & "</UsuarioCreacion></DETALLE>")
                End With
                lsNumero += 1
            Next
            XML.AppendLine("</DETALLES>")
            Return odRecargaPeaje.GuardarMasivo(XML.ToString, PrefijoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeRecargaPeaje As e_RecargaPeaje) As List(Of e_RecargaPeaje) Implements Il_RecargaPeaje.Listar
        Try
            odRecargaPeaje = New d_RecargaPeaje
            Return odRecargaPeaje.Listar(oeRecargaPeaje)
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

    Public Function EditarMasivo(ListaRecargaPeaje As List(Of e_RecargaPeaje)) As Boolean Implements Il_RecargaPeaje.EditarMasivo
        Try
            odRecargaPeaje = New d_RecargaPeaje
            Return odRecargaPeaje.ActualizarMasivo(ListaRecargaPeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
