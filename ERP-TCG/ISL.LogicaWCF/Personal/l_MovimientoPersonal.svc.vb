Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MovimientoPersonal
    Implements Il_MovimientoPersonal

    Private odMovimientoPersonal As New d_MovimientoPersonal
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un MovimientoPersonal especificado
    ''' </summary>
    ''' <param name="oeMovimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean Implements Il_MovimientoPersonal.Eliminar
        Try
            Return odMovimientoPersonal.Eliminar(oeMovimientoPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información del MovimientoPersonal
    ''' </summary>
    ''' <param name="oeMovimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean Implements Il_MovimientoPersonal.Guardar
        Try
            If Validar(oeMovimientoPersonal) Then
                Return odMovimientoPersonal.Guardar(oeMovimientoPersonal)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de MovimientoPersonals
    ''' </summary>
    ''' <param name="oeMovimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As System.Collections.Generic.List(Of e_MovimientoPersonal) Implements Il_MovimientoPersonal.Listar
        Try
            Return odMovimientoPersonal.Listar(oeMovimientoPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un MovimientoPersonal específico
    ''' </summary>
    ''' <param name="oeMovimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal Implements Il_MovimientoPersonal.Obtener
        Try
            Return odMovimientoPersonal.Obtener(oeMovimientoPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método que valida los datos correctos del MovimientoPersonal
    ''' </summary>
    ''' <param name="oeMovimientoPersonal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean Implements Il_MovimientoPersonal.Validar
        Try
            With oeMovimientoPersonal
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "Debe seleccionar algún empleado")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdSituacionAdministrativa, "Debe seleccionar el motivo o situación administrativa que se va a registrar")
                'ValidarDuplicado(.Id, .Codigo, "codigo")
                'ValidarDuplicado(.Id, .Nombre, "nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
