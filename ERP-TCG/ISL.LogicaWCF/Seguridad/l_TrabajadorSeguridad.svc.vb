'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TrabajadorSeguridad
    Implements Il_TrabajadorSeguridad

    Dim odTrabajadorSeguridad As New d_TrabajadorSeguridad

    Public Function Eliminar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean Implements Il_TrabajadorSeguridad.Eliminar
        Try
            Return odTrabajadorSeguridad.Eliminar(oeTrabajadorSeguridad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean Implements Il_TrabajadorSeguridad.Guardar
        Try
            If Validar(oeTrabajadorSeguridad) Then
                Return odTrabajadorSeguridad.Guardar(oeTrabajadorSeguridad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function ListarProcesosDelTrabajador(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As System.Collections.Generic.List(Of e_TrabajadorSeguridad) Implements Il_TrabajadorSeguridad.ListarProcesosDelTrabajador
    '    Try
    '        'Return odTrabajadorSeguridad.ListarProcesosDelTrabajador(oeTrabajadorSeguridad)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Listar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As System.Collections.Generic.List(Of e_TrabajadorSeguridad) Implements Il_TrabajadorSeguridad.Listar
        Try
            Return odTrabajadorSeguridad.Listar(oeTrabajadorSeguridad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As e_TrabajadorSeguridad Implements Il_TrabajadorSeguridad.Obtener
        Try
            Return odTrabajadorSeguridad.Obtener(oeTrabajadorSeguridad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean Implements Il_TrabajadorSeguridad.Validar
        Try
            With oeTrabajadorSeguridad
                '---------VALIDARRRRRRRRRR-------------
                If oeTrabajadorSeguridad.IdProcesoNegocio Is Nothing Then Throw New Exception("Seleccione un proceso de negocio para guardar la información.")
                If oeTrabajadorSeguridad.IdTrabajador Is Nothing Then Throw New Exception("Seleccione un trabajador para guardar la información.")
                If oeTrabajadorSeguridad.CantidadLimite = 0.0 Then Throw New Exception("Agrege un monto mayor a 0 para guardar la información.")
                ValidarDuplicado(oeTrabajadorSeguridad)

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ValidarDuplicado(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) Implements Il_TrabajadorSeguridad.ValidarDuplicado
        Dim oeTraSeg As New e_TrabajadorSeguridad
        Try
            oeTraSeg = odTrabajadorSeguridad.Obtener(oeTrabajadorSeguridad)
            If oeTrabajadorSeguridad.TipoOperacion = "I" AndAlso _
             (oeTraSeg.IdTrabajador = oeTrabajadorSeguridad.IdTrabajador And oeTraSeg.IdProcesoNegocio = oeTrabajadorSeguridad.IdProcesoNegocio) Then
                Throw New Exception("Trabajador ya se encuentra registrado")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Retorna si un usuario tiene el permiso para realizar una accion respectiva en el SGI.
    ''' </summary>
    ''' <param name="IdTrabajador"></param>
    ''' <param name="Proceso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Permisos(IdTrabajador As String, ByVal Proceso As String) As Boolean
        Try
            Dim oeTrabSeg As New e_TrabajadorSeguridad
            Dim olTrabSeg As New l_TrabajadorSeguridad
            oeTrabSeg.IdTrabajador = IdTrabajador
            oeTrabSeg.TipoOperacion = "H"
            oeTrabSeg.NombreProceso = Proceso
            oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
            If oeTrabSeg.IdTrabajador = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
