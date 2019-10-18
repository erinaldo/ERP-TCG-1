'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF


Public Class d_Banco
    Private sqlhelper As New SqlHelper

    Private oeBanco As e_Banco

    Private Function Cargar(ByVal o_fila As DataRow) As e_Banco
        Try
            Dim oebanco = New e_Banco( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), o_fila("Activo"))
            Return oebanco
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    ''' Dim odBanco As New d_Banco
    ''' Dim oeBanco as New e_Banco 
    ''' 
    ''' Public Function ObtenerIdBanco(ByVal nombreBanco As String) As String
    '''     Try
    '''         oeBanco.Activo = True
    '''         oeBanco.Nombre = nombreBanco
    '''        oeBanco = odBanco.Obtener(oeBanco)
    '''         Return oeBanco.Id
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    '''  End Function


    Public Function Obtener(ByVal oeBanco As e_Banco) As e_Banco
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", oeBanco.Id, oeBanco.Nombre, oeBanco.Codigo)
            oeBanco = New e_Banco
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeBanco = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal id As String) As e_Banco
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", oeBanco.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeBanco = Cargar(ds.Tables(0).Rows(0))
            Else
                oeBanco = New e_Banco
            End If
            Return oeBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' Public Function ListarBancosActivos(ByVal oeBanco As e_Banco) As List(Of e_Banco)
    '''     Try
    '''         oeBanco.Activo = True
    '''         Dim odBanco As New d_Banco
    '''         Return odBanco.Listar(oeBanco)
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    ''' End Function

    Public Function Listar(ByVal oeBanco As e_Banco) As List(Of e_Banco)
        Try
            Dim ldBanco As New List(Of e_Banco)
            Dim ds As DataSet
            With oeBanco
                ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo)
            End With
            oeBanco = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBanco = Cargar(o_Fila)
                    ldBanco.Add(oeBanco)
                Next
                Return ldBanco
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function



    ''' Sub GrabarBanco()
    '''    Try
    '''        Dim oeBanco as new e_Banco
    '''        Dim odBanco As New d_Banco
    '''
    '''        oeBanco.Activo = True
    '''        oeBanco.Codigo = "001"
    '''        oeBanco.Nombre = "Banco de la Nación"
    '''     
    '''        if odBanco.Guardar(oeBanco) Then 
    ''' Thow New Exception("El banco fue grabado exitosamente")
    ''' 
    ''' EndSub


    Public Function Guardar(ByVal oeBanco As e_Banco) As Boolean
        Try
            With oeBanco
                sqlhelper.ExecuteNonQuery("TES.Isp_Banco_IAE", .TipoOperacion,
                .Id, .Codigo, .Nombre, .Abreviatura, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



    Public Function Eliminar(ByVal oeBanco As e_Banco) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Banco_IAE", "E", oeBanco.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
