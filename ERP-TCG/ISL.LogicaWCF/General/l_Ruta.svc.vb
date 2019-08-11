Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Ruta
    Implements Il_Ruta

    Dim odRuta As New d_Ruta

    Public Function Eliminar(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.Eliminar
        Try
            Return odRuta.Eliminar(oeRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.Guardar
        Try
            If Validar(oeRuta) Then
                Return odRuta.Guardar(oeRuta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRuta As EntidadesWCF.e_Ruta) As System.Collections.Generic.List(Of EntidadesWCF.e_Ruta) Implements Il_Ruta.Listar
        Try
            Return odRuta.Listar(oeRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarGrupos(ByVal oeRuta As EntidadesWCF.e_Ruta) As System.Data.DataSet Implements Il_Ruta.ListarGrupos
        Try
            Return odRuta.ListarGrupos(oeRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRuta As EntidadesWCF.e_Ruta) As EntidadesWCF.e_Ruta Implements Il_Ruta.Obtener
        Try
            Return odRuta.Obtener(oeRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.Validar
        Try
            With oeRuta
                ValidarOrigen(oeRuta.IdOrigen)
                ValidarDestino(oeRuta.IdDestino)
                ValidarCentro(oeRuta.IdCentro)
                ValidarFlota(oeRuta.IdFlota)
                ValidarZonaD2(oeRuta)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarCentro(ByVal Id As String) As Boolean Implements Il_Ruta.ValidarCentro
        Try
            Dim oeCentro As New e_Centro
            Dim odCentro As New d_Centro
            oeCentro.Id = Id
            oeCentro = odCentro.Obtener(oeCentro)
            If oeCentro.Id = "" Then
                Throw New Exception("Base seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDestino(ByVal Id As String) As Boolean Implements Il_Ruta.ValidarDestino
        Try
            Dim oeDestino As New e_Lugar
            Dim odDestino As New d_Lugar
            oeDestino.Id = Id
            oeDestino = odDestino.Obtener(oeDestino)
            If oeDestino.Id = "" Then
                Throw New Exception("Destino seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFlota(ByVal Id As String) As Boolean Implements Il_Ruta.ValidarFlota
        Try
            Dim oeFlota As New e_Flota
            Dim odFlota As New d_Flota
            oeFlota.Id = Id
            oeFlota = odFlota.Obtener(oeFlota)
            If oeFlota.Id = "" Then
                Throw New Exception("Flota seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarOrigen(ByVal Id As String) As Boolean Implements Il_Ruta.ValidarOrigen
        Try
            Dim oeOrigen As New e_Lugar
            Dim odOrigen As New d_Lugar
            oeOrigen.Id = Id
            oeOrigen = odOrigen.Obtener(oeOrigen)
            If oeOrigen.Id = "" Then
                Throw New Exception("Origen seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarRuta(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.ValidarRuta
        Try
            Dim odRuta As New d_Ruta
            oeRuta = odRuta.Obtener(oeRuta)
            If oeRuta.Id = "" Then
            Else
                Throw New Exception("Origen y Destino Seleccionado ya existe como Ruta")
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarRutaNueva(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.ValidarRutaNueva
        Try
            Dim odRuta As New d_Ruta
            oeRuta = odRuta.Obtener(oeRuta)
            If oeRuta.Id = "" Then
                Throw New Exception("Seleccionado no existe como Ruta")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarZonaD2(ByVal oeRuta As EntidadesWCF.e_Ruta) As Boolean Implements Il_Ruta.ValidarZonaD2
        Try
            If oeRuta.TipoOperacion <> "E" Then
                If Trim(oeRuta.Id) <> "" And oeRuta.loZonaD2.Count = 0 Then Exit Function
                If oeRuta.loZonaD2.Count = 0 Then Throw New Exception("Ingrese detalle de Zona Combustible")
                Dim NroMayor As Integer
                NroMayor = oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.Count()
                If oeRuta.IdOrigen <> oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E" And i.Orden = "1")(0).IdOrigen Then
                    Throw New Exception("El origen de la Ruta es distinto al origen de la Zona de Combustible de orden 1")
                End If
                If oeRuta.IdDestino <> oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E" And i.Orden = NroMayor)(0).IdDestino Then
                    Throw New Exception("El destino de la Ruta es distinto al destino de la Zona de Combustible del mayor oden")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function VerificarAntesEliminar(ByVal oeRuta As EntidadesWCF.e_Ruta) As Integer
        Try
            Return odRuta.VerificarAntesEliminar(oeRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
