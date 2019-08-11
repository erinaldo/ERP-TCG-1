Imports ISL.EntidadesWCF

''' <summary>
''' Clase que se encarga de gestionar los Accidentes asociados a personas y/o trabajadores de la empresa
''' </summary>
''' <example> Este ejemplo muestra como cargar una clase de tipo d_AccidentePersona
''' <code>
'''    Dim odAccidentePersona As New d_AccidentePersona
''' </code>
''' </example>
''' <remarks>Esta clase controla los metodos de accesos la tabla SPC.Accidente_Persona<see cref="e_AccidentePersona"/><seealso cref="e_AccidentePersona"/></remarks>
Public Class d_AccidentePersona

    Private sqlhelper As New SqlHelper

    Private oeAccidentePersona As e_AccidentePersona

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

    ''' <summary>
    ''' Caso especial para obtener el accidente vinculado al trabajador a partir de su Id
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Esta función permite generar una lista de Accidentes vinculados a trabajadores, a partir de algunos datos cargados en el objeto e_AccidentePersona
    ''' que se le pasa como parámetro
    ''' </summary>
    ''' <param name="oeAccidentePersona">Recibe una variable oeAccidentePersona de tipo e_AccidentePersona.</param>
    ''' <returns>Devuelve una lista de objetos de tipo e_AccidentePersona
    ''' </returns>
    ''' <example> Este ejemplo muestra como obtener una lista de todos los objetos de tipo <see cref="e_AccidentePersona"/> se encuentran Activos en el sistema
    ''' <code>
    ''' 
    ''' Public Function ListarAccidentesActivos(ByVal oeAccidentePersona As e_AccidentePersona) As List(Of e_AccidentePersona)
    '''     Try
    '''         oeAccidentePersona.Activo = True
    '''         Dim odAccidente As New d_AccidentePersona
    '''         Return odAccidentePersona.Listar(oeAccidentePersona)
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    ''' End Function
    ''' 
    ''' </code>
    ''' </example>
    ''' <remarks>Este método genera una lista de Accidentes vinculados a Personas, a partir del objeto <see cref="e_AccidentePersona"/><seealso cref="e_AccidentePersona"/> que se pasa como parámetro</remarks>
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

    ''' <summary>
    ''' Esta función permite Guardar o Grabar la información de un Accidente vinculado a una persona y/o trabajador específico, a partir de algunos datos cargados en el objeto e_AccidentePersona
    ''' que se le pasa como parámetro
    ''' </summary>
    ''' <param name="oeAccidentePersona">Recibe una variable oeAccidentePersona de tipo <see cref="e_AccidentePersona"/></param>
    ''' <returns>Devuelve un valor de tipo booleano, True en caso la grabación sea exitosa, False en caso se haya presentado algún tipo de error al momento de grabar
    ''' </returns>
    ''' <example> Este ejemplo muestra como Guardar la información de un Accidente vinculado a una persona y/o trabajador, habiendo cargado directamente en el objeto los datos de éste
    ''' <code>
    ''' 
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
    ''' 
    ''' 
    ''' </code>
    ''' </example>
    ''' <remarks>Este método genera una lista de Accidentes, a partir del objeto <see cref="e_Accidente"/><seealso cref="e_Empresa"/> que se pasa como parámetro</remarks>
    Public Function Guardar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeAccidentePersona
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Persona_IAE", .TipoOperacion, _
                d_DatosConfiguracion.PrefijoID, .Id, .IdAccidente, .IdTrabajador, .Detalle, .Observacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de documento,a travez del procedimiento almacenado
    ''' SPC.Isp_AccidentePersona_IAE,por el cual va a ser enviado el id del accidente vinculado al trabajador a desactivar, 
    ''' obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:20/07/2012
    ''' </summary>
    ''' <param name="oeAccidentePersona">Recibe una variable oeAccidentePersona de tipo objeto e_AccidentePersona</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeAccidentePersona As e_AccidentePersona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidentePersona_IAE", "E", oeAccidentePersona.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina definitivamente de la base de datos la información relacionada al accidente vinculado a la persona
    ''' </summary>
    ''' <param name="oeAccidentePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
