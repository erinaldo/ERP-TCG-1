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
Public Class l_ProcesoNegocio
    Implements Il_ProcesoNegocio

    Dim odProcesoNegocio As New d_ProcesoNegocio
    Dim olActividadnegocio As New l_ActividadNegocio
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean Implements Il_ProcesoNegocio.Eliminar
        Try
            If oeProcesoNegocio.Protegido Then Throw New Exception("El proceso está protegido, por consiguiente no puede ser eliminado")
            Return odProcesoNegocio.Eliminar(oeProcesoNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean Implements Il_ProcesoNegocio.Guardar
        Try
            If Validar(oeProcesoNegocio) Then
                Return odProcesoNegocio.Guardar(oeProcesoNegocio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As System.Collections.Generic.List(Of e_ProcesoNegocio) Implements Il_ProcesoNegocio.Listar
        Try
            Return odProcesoNegocio.Listar(oeProcesoNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio Implements Il_ProcesoNegocio.Obtener
        Try
            Return odProcesoNegocio.Obtener(oeProcesoNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean Implements Il_ProcesoNegocio.Validar
        Try
            With oeProcesoNegocio
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                olActividadnegocio.ValidarLista(oeProcesoNegocio.leActividadNegocio)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
