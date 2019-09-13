Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
'Imports Microsoft.ApplicationBlocks.Data

''' <summary>
''' Clase de tipo general, para obtener datos masivos
''' </summary>
''' <remarks></remarks>
Public Class d_Datos

    Dim conecta As New d_Conexion
    Private sqlhelper As New SqlHelper


    Public Shared Function Ejecutar_DataSet(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray a_Parametros As Object()) As Data.DataSet
        Dim mds_DataSet As New System.Data.DataSet
        CrearDataAdapter(ProcedimientoAlmacenado, a_Parametros).Fill(mds_DataSet)
        Return mds_DataSet
    End Function

    Public Shared Function Ejecutar(ByVal ProcedimientoAlmacenado As String, ByVal a_Parametros As Object()) As Integer
        Dim con As New SqlConnection
        Try
            Dim d_conexion As New d_Conexion
            con.ConnectionString = d_conexion.CadenaConexionSGI
            Dim mCom As SqlCommand = Comando(ProcedimientoAlmacenado)
            con.Open()
            mCom.Connection = con
            mCom.CommandType = Data.CommandType.StoredProcedure
            Dim i As Integer = CargarParametros(mCom, a_Parametros)
            Dim Resp As Integer = mCom.ExecuteNonQuery
            mCom.Parameters.Item(1).ToString()
            con.Close()
            Return Resp
        Catch ex As Exception
            Throw ex
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Function

    Private Shared Function Comando(ByVal ProcedimientoAlmacenado As String) As SqlCommand
        Dim con As New SqlConnection
        Try
            Dim d_conexion As New d_Conexion
            con.ConnectionString = d_conexion.CadenaConexionSGI
            Dim mComando As SqlCommand
            con.Open()
            mComando = New SqlCommand(ProcedimientoAlmacenado, con)
            Dim mContructor As New SqlCommandBuilder()
            mComando.Connection = con
            mComando.CommandType = Data.CommandType.StoredProcedure
            mComando.CommandText = ProcedimientoAlmacenado
            SqlCommandBuilder.DeriveParameters(mComando)
            con.Close()
            Return mComando
        Catch ex As Exception
            Throw ex
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Function

    Private Shared Function CargarParametros(ByVal Comando As SqlCommand, ByVal Args() As Object) As Integer
        Dim i As Integer
        With Comando
            For i = 0 To Args.Length - 1 ' Args.GetUpperBound(0) - 1
                Try
                    CType(.Parameters(i + 1), SqlParameter).Value = Args(i)
                Catch Qex As Exception
                    Throw (Qex)
                End Try
            Next
        End With
        Return -1
    End Function

    Private Shared Function CrearDataAdapter(ByVal ProcedimientoAlmacenado As String, ByVal ParamArray Args() As Object) As SqlDataAdapter
        Dim mCom As SqlCommand = Comando(ProcedimientoAlmacenado)
        If Not Args Is Nothing Then
            Dim i As Integer
            i = CargarParametros(mCom, Args)
        End If
        Return New SqlDataAdapter(mCom)
    End Function

    Public Function d_GeneraId(ByVal C_Base As e_Base) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            Dim d_conexion As New d_Conexion
            Dim stResultado() As String = sqlhelper.ExecuteScalar(d_Conexion.CadenaConexionSGI, "ISP_Genera_IdTabla",
               C_Base.Nombre,
               C_Base.PrefijoID).ToString.Split("_")
            Dim IdDemanda As String = stResultado(0)
            Return IdDemanda
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Obtener el esquema o estructura de una tabla específica
    ''' Para utilizarla se debe utilizar por ejemplo:
    ''' Dim datos As New d_Datos
    ''' Dim tablita As List(Of e_Tabla) = datos.Obtener_Estructura_Tabla("Direccion", "STD")
    ''' </summary>
    ''' <param name="nombreTabla">Nombre de la tabla</param>
    ''' <param name="esquemaTabla">Esquema de la tabla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Estructura_Tabla(ByVal nombreTabla As String, Optional ByVal esquemaTabla As String = "dbo") As List(Of e_Tabla)
        Try
            ' Dim datos As New d_Conexion
            Dim connectionString As String = d_Conexion.CadenaConexionSGI()
            Dim Lista As New List(Of e_Tabla)
            Dim conConexion As New SqlConnection(connectionString)
            ' Dim conConexion As New SqlConnection(datos.CadenaConexionSGI)
            Dim coSQL As New SqlCommand("SELECT COLUMN_NAME AS NombreColumna, DATA_TYPE as TipoDato, CHARACTER_MAXIMUM_LENGTH as Longitud, IS_NULLABLE as Nulo FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" & esquemaTabla & "' AND TABLE_NAME = '" & nombreTabla & "'", conConexion)
            Dim drColumnas As SqlDataReader
            conConexion.Open()
            drColumnas = coSQL.ExecuteReader

            While drColumnas.Read()
                Dim i As Integer = 0
                Dim tabla As New e_Tabla
                tabla.NombreColumna = drColumnas(0)
                tabla.TipoDato = drColumnas(1)
                tabla.Longitud = IIf(Not IsDBNull(drColumnas(2)), drColumnas(2), "NULO")
                tabla.Nulo = IIf(Not IsDBNull(drColumnas(3)), drColumnas(3), "NULO")
                Lista.Add(tabla)
            End While
            drColumnas.Close()
            conConexion.Close()
            Return Lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
