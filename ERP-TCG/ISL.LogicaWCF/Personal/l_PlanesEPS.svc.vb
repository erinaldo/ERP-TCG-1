'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_PlanesEPS
    Implements Il_PlanesEPS
    Dim odPlanesEPS As New d_PlanesEPS
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePlanesEPS As e_PlanesEPS) As Boolean Implements Il_PlanesEPS.Eliminar
        Try
            Return odPlanesEPS.Eliminar(oePlanesEPS)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePlanesEPS As e_PlanesEPS) As Boolean Implements Il_PlanesEPS.Guardar
        Try
            If Validar(oePlanesEPS) Then
                Return odPlanesEPS.Guardar(oePlanesEPS)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePlanesEPS As e_PlanesEPS) As System.Collections.Generic.List(Of e_PlanesEPS) Implements Il_PlanesEPS.Listar
        Try
            Return odPlanesEPS.Listar(oePlanesEPS)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePlanesEPS As e_PlanesEPS) As e_PlanesEPS Implements Il_PlanesEPS.Obtener
        Try
            Return odPlanesEPS.Obtener(oePlanesEPS)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePlanesEPS As e_PlanesEPS) As Boolean Implements Il_PlanesEPS.Validar
        Try
            With oePlanesEPS
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresa, "No ha Ingresado Empresa")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                If .Precio = 0 Then Throw New Exception("Ingrese Precio")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
