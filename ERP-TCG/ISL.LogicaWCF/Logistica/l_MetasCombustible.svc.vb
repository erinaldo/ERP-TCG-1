Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MetasCombustible
    Implements Il_MetasCombustible

    Dim odMetasCombustible As New d_MetasCombustible
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Private Function ValidarDuplicado(ByVal oeMeta As e_MetasCombustible) As Boolean
        Try
            Dim _TipoOperacion As String = oeMeta.TipoOperacion
            oeMeta.TipoOperacion = "V"
            If odMetasCombustible.Listar(oeMeta).Count > 0 Then
                Throw New Exception("Ya existe ruta: " & oeMeta.Ruta & " con los mismos parametros asignados.")
            End If
            oeMeta.TipoOperacion = _TipoOperacion
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMetasCombustible As e_MetasCombustible) As e_MetasCombustible Implements Il_MetasCombustible.Obtener
        Try
            Return odMetasCombustible.Obtener(oeMetasCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMetasCombustible As e_MetasCombustible) As List(Of e_MetasCombustible) Implements Il_MetasCombustible.Listar
        Try
            Return odMetasCombustible.Listar(oeMetasCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean
        Try
            With oeMetasCombustible
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdModeloTracto, "Debe seleccionar un modelo de tracto")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Ruta, "Debe crear una ruta")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Pesos, "Debe ingresar los pesos de la ruta")
                ValidarDuplicado(oeMetasCombustible)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean Implements Il_MetasCombustible.Guardar
        Try
            If Validar(oeMetasCombustible) Then
                Return odMetasCombustible.Guardar(oeMetasCombustible)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMetasCombustible As e_MetasCombustible) As Boolean Implements Il_MetasCombustible.Eliminar
        Try
            Return odMetasCombustible.Eliminar(oeMetasCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
