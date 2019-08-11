Imports System.Text
Imports System.Data.SqlClient
Imports ISL.EntidadesWCF

Public Class frm_Mapa
    Inherits ISL.Win.frm_MenuPadre
    Dim conexion As New SqlConnection("Data Source=10.1.0.20;Initial Catalog=GPS;Persist Security Info=True;User ID=isl;Password=induamerica")

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Mapa = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Mapa()
        End If
        instancia.Activate()
        Return instancia

    End Function

    ''' <summary>
    ''' Obtiene la lista de placas de vehículos monitoreados por GPS
    ''' </summary>
    ''' <remarks></remarks>
    Private Function ObtenerPlacas() As List(Of e_GPS)
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("Isp_GPS_Listar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim param As System.Data.SqlClient.SqlParameter
            param = New System.Data.SqlClient.SqlParameter()
            param.ParameterName = "@TipoOperacion"
            param.SqlDbType = SqlDbType.VarChar
            param.Value = "T"

            cmd.Parameters.Add(param)

            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0) Is Nothing Then Throw New Exception("Sin información para mostrar")
            Dim lista As New List(Of e_GPS)
            For Each fila As DataRow In ds.Tables(0).Rows
                Dim estadoVehiculo As New e_GPS
                estadoVehiculo.Placa = fila("Placa")
                lista.Add(estadoVehiculo)
            Next
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function


    ''' <summary>
    ''' Obtener información específica de un vehículo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ObtenerInformacionGPS(ByVal placa As String) As e_GPS
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("Isp_GPS_Listar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim tipoOperacion As System.Data.SqlClient.SqlParameter
            tipoOperacion = New System.Data.SqlClient.SqlParameter()
            tipoOperacion.ParameterName = "@TipoOperacion"
            tipoOperacion.SqlDbType = SqlDbType.VarChar
            tipoOperacion.Value = "P"
            cmd.Parameters.Add(tipoOperacion)

            Dim placa2 As System.Data.SqlClient.SqlParameter
            placa2 = New System.Data.SqlClient.SqlParameter()
            placa2.ParameterName = "@Placa"
            placa2.SqlDbType = SqlDbType.VarChar
            placa2.Value = placa
            cmd.Parameters.Add(placa2)

            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0) Is Nothing Then Throw New Exception("Sin información para mostrar")
            Dim vehiculo As New e_GPS
            For Each fila As DataRow In ds.Tables(0).Rows
                vehiculo.Placa = fila("Placa")
                vehiculo.Latitud = fila("Latitud")
                vehiculo.Longitud = fila("Longitud")
                vehiculo.Curso = fila("Curso")
                vehiculo.Velocidad = fila("Velocidad")
                vehiculo.Odometro = fila("Odometro")
                vehiculo.Lugar = fila("Lugar")
                vehiculo.Fecha = fila("FechaCreacion")
                vehiculo.Encendido = fila("Encendido")
                vehiculo.Puerta = fila("Puerta")
                vehiculo.Panico = fila("Panico")
            Next
            Return vehiculo
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'BuscarLugar(txtCalle.Text, txtCiudad.Text, txtEstado.Text)
            Dim vehiculo As e_GPS = ObtenerInformacionGPS(cboVehiculo.Text)
            BuscarCoordenadas(vehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function TipoMapa() As String
        Dim tipo As String = String.Empty
        Select Case cboTipoMapa.Text
            Case "Terreno"
                tipo = "terrain"
            Case "Ruta"
                tipo = "roadmap"
            Case "Satelital"
                tipo = "satellite"
            Case "Hibrido"
                tipo = "hybrid"
        End Select
        Return tipo
    End Function


    ''' <summary>
    ''' Busca y muestra el mapa de acuerdo a coordenadas especificadas
    ''' </summary>
    Private Sub BuscarCoordenadas(ByVal vehiculo As e_GPS)
        Try
            If String.IsNullOrEmpty(vehiculo.Latitud.ToString) And String.IsNullOrEmpty(vehiculo.Longitud.ToString) Then Throw New Exception("Debe ingresar algún dato a buscar")
            Dim buscar As New StringBuilder()
            buscar.Append("http://maps.google.com.es/maps?q=")
            'buscar.Append("http://maps.googleapis.com/maps/api/staticmap?center=")

            If Not String.IsNullOrEmpty(vehiculo.Latitud.ToString) Then
                buscar.Append(vehiculo.Latitud.ToString + "%2C")
                'buscar.Append(vehiculo.Latitud.ToString + ",")
            End If

            If Not String.IsNullOrEmpty(vehiculo.Longitud.ToString) Then
                buscar.Append(vehiculo.Longitud.ToString + "%7C&sensor=false")
                'buscar.Append(vehiculo.Longitud.ToString + "&zoom=12&size=512x512&maptype=" + TipoMapa() + "\&markers=size:mid%7Ccolor:0xFFFF00%7Clabel:" + vehiculo.Placa + "%7C&sensor=false")
            End If

            WebBrowser1.Navigate(buscar.ToString)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Buscar un lugar específico en el mapa, a partir de sus datos básicos de calle y ciudad
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarLugar(ByVal calle As String, ByVal ciudad As String, ByVal estado As String)
        Try
            If String.IsNullOrEmpty(txtEstado.Text) And String.IsNullOrEmpty(txtCalle.Text) And String.IsNullOrEmpty(txtCiudad.Text) Then Throw New Exception("Debe ingresar algún dato a buscar")
            Dim buscar As New StringBuilder()
            buscar.Append("http://maps.google.com/maps?q=")

            If Not String.IsNullOrEmpty(txtCalle.Text) Then
                calle = txtCalle.Text.Replace(" ", "+")
                buscar.Append(calle + "," & "+")
            End If

            If Not String.IsNullOrEmpty(txtCiudad.Text) Then
                ciudad = txtCiudad.Text.Replace(" ", "+")
                buscar.Append(ciudad + "," & "+")
            End If

            If Not String.IsNullOrEmpty(txtEstado.Text) Then
                estado = txtEstado.Text.Replace(" ", "+")
                buscar.Append(estado + "," & "+")
            End If

            WebBrowser1.Navigate(buscar.ToString)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub


    Private Sub frm_Mapa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Mapa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        'e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    'Private Sub btnMapLatLong_Click(ByVal sender As System.Object, ByVal e As  
    'System.EventArgs) Handles btnMapLatLong.Click

    '        If txtLat.Text = String.Empty Or txtLong.Text = String.Empty Then
    '            MessageBox.Show("Supply a latitude and longitude value.", "Missing Data")
    '        End If

    '        Try
    '            Dim lat As String = String.Empty
    '            Dim lon As String = String.Empty
    '            Dim queryAddress As New StringBuilder()
    '            queryAddress.Append("http://maps.google.com/maps?q=")
    '            ' build latitude part of query string
    '            If txtLat.Text <> String.Empty Then
    '                lat = txtLat.Text
    '                queryAddress.Append(lat + "%2C")
    '            End If
    '            ' build longitude part of query string
    '           If txtLong.Text <> String.Empty Then
    '                lon = txtLong.Text
    '                queryAddress.Append(lon)
    '            End If
    '            webBrowser1.Navigate(queryAddress.ToString())
    '        Catch ex As Exception
    'mensajeEmergente.Problema(ex.Message)
    '        End Try
    '    End Sub

    Private Sub frm_Mapa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cboVehiculo.DataSource = ObtenerPlacas()
            cboVehiculo.ValueMember = "Placa"
            cboVehiculo.DisplayMember = "Placa"
            cboVehiculo.SelectedIndex = 0
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

End Class