' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_PagoCajaTrabajador" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_PagoCajaTrabajador.svc o l_PagoCajaTrabajador.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_PagoCajaTrabajador
    Implements Il_PagoCajaTrabajador

    Private odPagoCajaTrabajador As New d_PagoCajaTrabajador
    Private olDetalle As New l_DetallePagoCajaTrabajador
    Private odDetalle As New d_DetallePagoCajaTrabajador
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePagoCajaTrabajador As EntidadesWCF.e_PagoCajaTrabajador) As Boolean Implements Il_PagoCajaTrabajador.Eliminar
        Try
            Return odPagoCajaTrabajador.Eliminar(oePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePagoCajaTrabajador As EntidadesWCF.e_PagoCajaTrabajador) As Boolean Implements Il_PagoCajaTrabajador.Guardar
        Try
            If Validar(oePagoCajaTrabajador) Then
                Return odPagoCajaTrabajador.Guardar(oePagoCajaTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePagoCajaTrabajador As EntidadesWCF.e_PagoCajaTrabajador) As List(Of EntidadesWCF.e_PagoCajaTrabajador) Implements Il_PagoCajaTrabajador.Listar
        Try
            Return odPagoCajaTrabajador.Listar(oePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePagoCajaTrabajador As EntidadesWCF.e_PagoCajaTrabajador) As EntidadesWCF.e_PagoCajaTrabajador Implements Il_PagoCajaTrabajador.Obtener
        Try
            Return odPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePagoCajaTrabajador As EntidadesWCF.e_PagoCajaTrabajador) As Boolean Implements Il_PagoCajaTrabajador.Validar
        Try
            With oePagoCajaTrabajador
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImportarDatos(oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean Implements Il_PagoCajaTrabajador.ImportarDatos
        Try
            Dim dtPA As Data.DataTable = olDetalle.CrearDT()
            Dim id As String = odDetalle.UltimoIdInserta(oePagoCajaTrabajador.PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDet In oePagoCajaTrabajador.leDetalle
                Dim rwPA As Data.DataRow
                rwPA = dtPA.NewRow
                With oeDet
                    rwPA("Id") = lsPrefijo & olDetalle.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwPA("IdPagoCajaTrabajador") = String.Empty
                    rwPA("IdTrabajador") = .IdTrabajador
                    rwPA("IndTipo") = .IndTipo
                    rwPA("Monto") = .Monto
                    rwPA("Redondeo") = .Redondeo
                    rwPA("TotalPagar") = .TotalPagar
                    rwPA("FechaCreacion") = Date.Now
                    rwPA("UsuarioCreacion") = .UsuarioCreacion
                    rwPA("FechaModifica") = .FechaModifica
                    rwPA("UsuarioModifica") = .UsuarioModifica
                    rwPA("Activo") = True
                End With
                dtPA.Rows.Add(rwPA)
                lsNumero = lsNumero + 1
            Next
            oePagoCajaTrabajador.dtDetallePA = dtPA
            Return odPagoCajaTrabajador.ImportarDatos(oePagoCajaTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub DoWork() Implements Il_PagoCajaTrabajador.DoWork
    End Sub

End Class
