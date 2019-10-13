'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConceptosGenerales
    Implements Il_ConceptosGenerales

    Dim odConceptosGenerales As New d_ConceptosGenerales
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As Boolean Implements Il_ConceptosGenerales.Eliminar
        Try
            If oeConceptosGenerales.Protegido Then Throw New Exception("El concepto general está protegido y por tal no puede ser eliminado")
            Return odConceptosGenerales.Eliminar(oeConceptosGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As Boolean Implements Il_ConceptosGenerales.Guardar
        Try
            If Validar(oeConceptosGenerales) Then Return odConceptosGenerales.Guardar(oeConceptosGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As System.Collections.Generic.List(Of EntidadesWCF.e_ConceptosGenerales) Implements Il_ConceptosGenerales.Listar
        Try
            Return odConceptosGenerales.Listar(oeConceptosGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As EntidadesWCF.e_ConceptosGenerales Implements Il_ConceptosGenerales.Obtener
        Try
            Return odConceptosGenerales.Obtener(oeConceptosGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As Boolean Implements Il_ConceptosGenerales.Validar
        Try
            With oeConceptosGenerales
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdProcesoNegocio, "Debe seleccionar algún proceso asociado")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "El nombre del concepto es obligatorio")
                ValidarDuplicado(oeConceptosGenerales)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los procesos asociados a algún tipo de documento
    ''' </summary>
    ''' <param name="oeConceptosGenerales">Objeto de tipo ConceptosGenerales</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal oeConceptosGenerales As EntidadesWCF.e_ConceptosGenerales) As Boolean Implements Il_ConceptosGenerales.ValidarDuplicado
        Try
            If String.IsNullOrEmpty(oeConceptosGenerales.IdProcesoNegocio) Then Throw New Exception("No se ha definido que proceso se va a verificar si existe")
            If String.IsNullOrEmpty(oeConceptosGenerales.Nombre) Then Throw New Exception("No se ha especificado concepto que se va a validar")
            'Dim idPrevio As String = oeConceptosGenerales.Id
            'Dim p As New List(Of e_ConceptosGenerales)
            'p = odConceptosGenerales.Listar(oeConceptosGenerales)
            'If p.Count > 0 Then
            '    If p.Item(0).Id <> idPrevio Then Throw New Exception("El concepto general ya se encuentra registrado")
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
