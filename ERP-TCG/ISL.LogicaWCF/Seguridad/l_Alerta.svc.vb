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
Public Class l_Alerta
    Implements Il_Alerta
    Dim odAlerta As New d_Alerta
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeAlerta As EntidadesWCF.e_Alerta) As Boolean Implements Il_Alerta.Eliminar
        Try
            Return odAlerta.Eliminar(oeAlerta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlerta As EntidadesWCF.e_Alerta) As Boolean Implements Il_Alerta.Guardar
        Try
            If Validar(oeAlerta) Then
                Return odAlerta.Guardar(oeAlerta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlerta As EntidadesWCF.e_Alerta) As System.Collections.Generic.List(Of EntidadesWCF.e_Alerta) Implements Il_Alerta.Listar
        Try
            Return odAlerta.Listar(oeAlerta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAlerta As EntidadesWCF.e_Alerta) As EntidadesWCF.e_Alerta Implements Il_Alerta.Obtener
        Try
            Return odAlerta.Obtener(oeAlerta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAlerta As EntidadesWCF.e_Alerta) As Boolean Implements Il_Alerta.Validar
        Try
            With oeAlerta
                l_FuncionesGenerales.ValidarCampoNoNulo(oeAlerta.oeAlertaDetalle.Glosa, "No ha Ingresado Glosa")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
