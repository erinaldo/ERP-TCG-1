Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_HistorialLaboral
    Implements Il_HistorialLaboral

    Dim odHistorialLaboral As New d_HistorialLaboral
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As Boolean Implements Il_HistorialLaboral.Eliminar
        Try
            Return odHistorialLaboral.Eliminar(oeHistorialLaboral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As Boolean Implements Il_HistorialLaboral.Guardar
        Try
            If Validar(oeHistorialLaboral) Then Return odHistorialLaboral.Guardar(oeHistorialLaboral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As System.Collections.Generic.List(Of EntidadesWCF.e_HistorialLaboral) Implements Il_HistorialLaboral.Listar
        Try
            Return odHistorialLaboral.Listar(oeHistorialLaboral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As EntidadesWCF.e_HistorialLaboral Implements Il_HistorialLaboral.Obtener
        Try
            Return odHistorialLaboral.Obtener(oeHistorialLaboral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As Boolean Implements Il_HistorialLaboral.Validar
        Try
            With oeHistorialLaboral
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "No se ha identificado el trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.FechaIngreso, "Falta la fecha de ingreso")
                ValidarDuplicado(oeHistorialLaboral)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los procesos asociados a algún tipo de documento
    ''' </summary>
    ''' <param name="oeHistorialLaboral">Objeto de tipo HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal oeHistorialLaboral As EntidadesWCF.e_HistorialLaboral) As Boolean Implements Il_HistorialLaboral.ValidarDuplicado
        Try
            'If String.IsNullOrEmpty(oeHistorialLaboral.IdProcesoNegocio) Then Throw New Exception("No se ha definido que proceso se va a verificar si existe")
            'If String.IsNullOrEmpty(oeHistorialLaboral.Nombre) Then Throw New Exception("No se ha especificado concepto que se va a validar")
            ''Dim idPrevio As String = oeHistorialLaboral.Id
            ''Dim p As New List(Of e_HistorialLaboral)
            ''p = odHistorialLaboral.Listar(oeHistorialLaboral)
            ''If p.Count > 0 Then
            ''    If p.Item(0).Id <> idPrevio Then Throw New Exception("El concepto general ya se encuentra registrado")
            ''End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
