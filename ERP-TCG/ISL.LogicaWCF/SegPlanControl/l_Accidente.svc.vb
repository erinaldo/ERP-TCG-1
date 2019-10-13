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
Public Class l_Accidente
    Implements Il_Accidente

    Dim odAccidente As New d_Accidente
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeAccidente As EntidadesWCF.e_Accidente) As Boolean Implements Il_Accidente.Eliminar
        Try
            Return odAccidente.Eliminar(oeAccidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidente As EntidadesWCF.e_Accidente) As Boolean Implements Il_Accidente.Guardar
        Try
            If Validar(oeAccidente) Then
                Return odAccidente.Guardar(oeAccidente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidente As EntidadesWCF.e_Accidente) As System.Collections.Generic.List(Of EntidadesWCF.e_Accidente) Implements Il_Accidente.Listar
        Try
            Return odAccidente.Listar(oeAccidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidente As EntidadesWCF.e_Accidente) As EntidadesWCF.e_Accidente Implements Il_Accidente.Obtener
        Try
            Return odAccidente.Obtener(oeAccidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidente As EntidadesWCF.e_Accidente) As Boolean Implements Il_Accidente.Validar
        Try
            With oeAccidente
                l_FuncionesGenerales.ValidarCampoNoNulo(.Fecha, "Debe ingresar la fecha del Accidente")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoAccidente, "Debe ingresar el tipo de Accidente")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Hora, "Debe ingresar la hora del Accidente")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Lugar, "Debe ingresar el lugar donde sucedió el Accidente")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Detalle, "Debe ingresar algún detalle del Accidente")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
