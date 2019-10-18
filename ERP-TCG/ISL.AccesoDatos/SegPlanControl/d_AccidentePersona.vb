'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF


Public Class d_AccidentePersona

    Private sqlhelper As New SqlHelper

    Private oeAccidentePersona As New e_AccidentePersona

    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidentePersona
        Try
            Dim oeAccidentePersona = New e_AccidentePersona( _
            o_fila("Id"), o_fila("idAccidente"), o_fila("IdTrabajador"), o_fila("Detalle"), o_fila("Observacion"), o_fila("Activo"), _
            o_fila("NombreCompleto").ToString, o_fila("Area").ToString)
            Return oeAccidentePersona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidentePersona As e_AccidentePersona) As e_AccidentePersona
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_AccidentePersona_Listar", "", oeAccidentePersona.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAccidentePersona = Cargar(ds.Tables(0).Rows(0))
            Else
                oeAccidentePersona = New e_AccidentePersona
            End If
            Return oeAccidentePersona
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' Public Function ListarAccidentesActivos(ByVal oeAccidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)
    '''     Try
    '''         oeAccidentePersona.Activo = True
    '''         Dim odAccidente As New d_AccidentePersona
    '''         Return odAccidentePersona.Listar(oeAccidentePersona)
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    ''' End Function

    Public Function Listar(ByVal oeAccidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)
        Try
            Dim ldAccidente As New List(Of e_AccidentePersona)
            Dim ds As DataSet
            With oeAccidentePersona
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Persona_Listar", .TipoOperacion, .Id, .IdAccidente, .IdTrabajador, .Activo)
            End With
            oeAccidentePersona = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAccidentePersona = Cargar(o_Fila)
                    ldAccidente.Add(oeAccidentePersona)
                Next
                Return ldAccidente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    ''' Sub GrabarAccidente()
    '''    Try
    '''        Dim oeAccidente as new e_Accidente
    '''        Dim odAccidente As New d_Accidente
    '''
    '''        oeAccidente.Activo = True
    '''        oeAccidente.Fecha = "16/06/2012"
    '''        oeAccidente.Hora = "10:30"
    '''        oeAccidente.idTipoAccidente = "1CH021"
    '''        oeAccidente.Lugar = "140101"
    '''        oeAccidente.Detalle = "Accidente de prueba"
    '''     
    '''        if odAccidente.Guardar(oeAccidente) Then 
    ''' mensajeEmegergente.Confirmacion("El Accidente fue grabado exitosamente")
    ''' 
    ''' EndSub


    Public Function Guardar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean
        Try
            With oeAccidentePersona
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Persona_IAE", .TipoOperacion,
                .PrefijoID, .Id, .IdAccidente, .IdTrabajador, .Detalle, .Observacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



    Public Function Eliminar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidentePersona_IAE", "E", oeAccidentePersona.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



    Public Function EliminacionDefinitiva(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidentePersona_IAE", "X", oeAccidentePersona.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
