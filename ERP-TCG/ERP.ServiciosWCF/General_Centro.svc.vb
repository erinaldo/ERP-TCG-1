' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "General_Centro" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione General_Centro.svc o General_Centro.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports ISL.LogicaWCF

Public Class General_Centro
    Implements IGeneral_Centro

    Public Sub New()
    End Sub

    Private odCentro As New d_Centro
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un centro especificado
    ''' </summary>
    ''' <param name="oeCentro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeCentro As e_Centro) As Boolean Implements IGeneral_Centro.Eliminar
        Try
            Return odCentro.Eliminar(oeCentro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información del centro
    ''' </summary>
    ''' <param name="oeCentro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeCentro As e_Centro) As Boolean Implements IGeneral_Centro.Guardar
        Try
            If Validar(oeCentro) Then
                Return odCentro.Guardar(oeCentro)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de centros
    ''' </summary>
    ''' <param name="oeCentro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeCentro As e_Centro) As System.Collections.Generic.List(Of e_Centro) Implements IGeneral_Centro.Listar
        Try
            Return odCentro.Listar(oeCentro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un centro específico
    ''' </summary>
    ''' <param name="oeCentro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeCentro As e_Centro) As e_Centro Implements IGeneral_Centro.Obtener
        Try
            Return odCentro.Obtener(oeCentro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerSAlmacen(ByVal oeCentro As e_Centro) As e_Centro Implements IGeneral_Centro.ObtenerSAlmacen
        Try
            Return odCentro.ObtenerCentroSAlmacen(oeCentro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método que valida los datos correctos del Centro
    ''' </summary>
    ''' <param name="oeCentro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeCentro As e_Centro) As Boolean Implements IGeneral_Centro.Validar
        Try
            With oeCentro
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el codigo del centro")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del centro")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar la abreviatura")
                If .IdLugar IsNot Nothing Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdLugar.Trim, "Debe seleccionar el lugar donde está ubicado el centro")
                Else
                    Throw New Exception("Debe seleccionar el lugar donde está ubicado el centro")
                End If
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los centros
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="valor"></param>
    ''' <param name="campo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements IGeneral_Centro.ValidarDuplicado
        Dim oeCentro As New e_Centro
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeCentro.Codigo = valor
                    Case "nombre"
                        oeCentro.Nombre = valor
                    Case "abreviatura"
                        oeCentro.Abreviatura = valor
                End Select
                oeCentro.TipoOperacion = "3"
                oeCentro = odCentro.Obtener(oeCentro)
                If Not oeCentro.Id Is Nothing And oeCentro.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaCentro As System.Collections.Generic.List(Of e_Centro)) As Object Implements IGeneral_Centro.ComboGrilla
        Try
            Return odCentro.ComboGrilla(ListaCentro)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
