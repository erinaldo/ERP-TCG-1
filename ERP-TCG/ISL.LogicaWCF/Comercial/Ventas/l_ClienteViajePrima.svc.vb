Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClienteViajePrima" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClienteViajePrima.svc o l_ClienteViajePrima.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClienteViajePrima
    Implements Il_ClienteViajePrima

    Dim odClienteViajePrima As New d_ClienteViajePrima

    Dim olCliViaPriDet As New l_ClienteViajePrimaDet
    Dim odCliViaPriDet As New d_ClienteViajePrimaDet
    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Public Function Obtener(ByVal oeClienteViajePrima As e_ClienteViajePrima) As e_ClienteViajePrima Implements Il_ClienteViajePrima.Obtener
        Try
            Return odClienteViajePrima.Obtener(oeClienteViajePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As List(Of e_ClienteViajePrima) Implements Il_ClienteViajePrima.Listar
        Try
            Return odClienteViajePrima.Listar(oeClienteViajePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean Implements Il_ClienteViajePrima.Validar
        Try
            With oeClienteViajePrima
                If .TipoOperacion = "I" Then
                    If .IdPeriodo = "" Then Throw New Exception("Seleccione Periodo")
                    Dim oe As New e_ClienteViajePrima
                    oe.IdPeriodo = .IdPeriodo
                    oe = odClienteViajePrima.Obtener(oe)
                    If oe.Id <> "" Then Throw New Exception("Periodo ya Consolidad. Verificar")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean Implements Il_ClienteViajePrima.Guardar
        Try
            Dim dt_CVPD As Data.DataTable = olCliViaPriDet.CrearDT()
            If Validar(oeClienteViajePrima) Then
                Using TransScope As New TransactionScope()
                    If odClienteViajePrima.Guardar(oeClienteViajePrima) Then
                        Dim idCliviaPriDet As String = odCliViaPriDet.UltimoIdInserta(oeClienteViajePrima.PrefijoID)
                        Dim lsPrefijoCliviaPriDet As String = Left(idCliviaPriDet, 3)
                        Dim lsNumeroIdCliviaPriDet As Integer = CInt(Right(idCliviaPriDet, Len(idCliviaPriDet) - 3))
                        Dim row As Data.DataRow
                        For Each oe As e_ClienteViajePrimaDet In oeClienteViajePrima.loViaPriDet
                            row = dt_CVPD.NewRow
                            row("Id") = lsPrefijoCliviaPriDet.ToString + olFuncionesGenerales.CompletaConCeros(lsNumeroIdCliviaPriDet.ToString, 12)
                            row("IdClienteViajePrima") = oeClienteViajePrima.Id
                            row("IdViaje") = oe.IdViaje
                            row("IdOperacionDetalle") = oe.IdOperacionDetalle
                            row("IdCliente") = oe.IdCliente
                            row("IdOrigen") = oe.IdOrigen
                            row("IdDestino") = oe.IdDestino
                            row("IdMaterial") = oe.IdMaterial
                            row("IndAsegurado") = oe.IndAsegurado
                            row("FechaCreacion") = oeClienteViajePrima.FechaCreacion
                            row("UsuarioCreacion") = oe.UsuarioCreacion
                            row("Activo") = 1

                            dt_CVPD.Rows.Add(row)
                            lsNumeroIdCliviaPriDet += 1

                        Next
                    End If
                    odCliViaPriDet.GuardaMasivo(dt_CVPD)
                    TransScope.Complete()
                End Using
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean Implements Il_ClienteViajePrima.Eliminar
        Try
            Return odClienteViajePrima.Eliminar(oeClienteViajePrima)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
