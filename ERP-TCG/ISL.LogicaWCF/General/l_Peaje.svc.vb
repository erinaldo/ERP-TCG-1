'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Public Class l_Peaje
    Implements Il_Peaje
    Private odPeaje As d_Peaje

    Public Function Eliminar(oePeaje As e_Peaje, bolTarifa As Boolean) As Boolean Implements Il_Peaje.Eliminar
        Try
            odPeaje = New d_Peaje
            Return odPeaje.Eliminar(oePeaje, bolTarifa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oePeaje As e_Peaje) As Boolean Implements Il_Peaje.Guardar
        Try
            odPeaje = New d_Peaje
            Return odPeaje.Guardar(oePeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oePeaje As e_Peaje) As List(Of e_Peaje) Implements Il_Peaje.Listar
        Try
            odPeaje = New d_Peaje
            Return odPeaje.Listar(oePeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oePeaje As e_Peaje, bolTarifa As Boolean) As e_Peaje Implements Il_Peaje.Obtener
        Try
            odPeaje = New d_Peaje
            oePeaje = odPeaje.Obtener(oePeaje)
            If Not String.IsNullOrEmpty(oePeaje.Id.Trim().Length) Then
                If bolTarifa Then
                    Dim odPeajeTarifa As New d_PeajeTarifa
                    Dim olPeajeTarifa As New l_PeajeTarifa
                    oePeaje.ListaTarifa.AddRange(olPeajeTarifa.Listar(New e_PeajeTarifa With {.TipoOperacion = "GEN", .IdPeaje = oePeaje.Id}))
                End If
            End If
            Return oePeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
