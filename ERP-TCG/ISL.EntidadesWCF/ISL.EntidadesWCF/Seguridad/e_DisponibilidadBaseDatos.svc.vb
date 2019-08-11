Imports System.IO
Imports System.Xml
Imports System.Configuration
Imports System.Collections.Specialized


''' <summary>
''' Clase que permite establecer la disponibilidad de acceso a la base de datos
''' a partir de la información contenida en el archivo de configuración Entorno.xml
''' ubicado en la carpeta compartida /Imagenes del servidor
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_DisponibilidadBaseDatos
    Implements Ie_DisponibilidadBaseDatos

#Region "Declaración de variables"

    ''' <summary>
    ''' Variable global que retorna el IP del servidor de cada sede
    ''' </summary>
    ''' <remarks></remarks>
    Public IPServidor As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")

    'Archivo XML, que debe estar copiado en la carpeta compartida Imagenes del servidor
    'Public archivoXML As String = "\\" & IPServidor & "\Imagenes\Entorno2.xml"
    Public archivoXML As String = "\\" & IPServidor & "\Imagenes\Entorno.xml"
    Private directorioFotos As String = "\\" & IPServidor & "\Fotos"
    'Private directorioFotos As String = "D:\Fotos"

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Indicador utilizada para mostrar un mensaje personalizado a los usuarios que intentan conectarse al sistema, mientras la base de datos se encuentra en mantenimiento
    ''' </summary>
    ''' <remarks></remarks>
    Private _mensajeInicial As String
    <DataMember()> _
    Public Property MensajeInicial() As String
        Get
            Return _mensajeInicial
        End Get
        Set(ByVal value As String)
            _mensajeInicial = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador utilizado para mostrar un mensaje personalizado a los usuarios que están conectados al sistema, minutos antes que la base de datos pase a estar en mantenimiento
    ''' </summary>
    ''' <remarks></remarks>
    Private _mensajeUsuariosConectados As String
    <DataMember()> _
    Public Property MensajeUsuariosConectados() As String
        Get
            Return _mensajeUsuariosConectados
        End Get
        Set(ByVal value As String)
            _mensajeUsuariosConectados = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador que permite determinar la disponibilidad de la conexión a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private _estadoDisponibilidadBD As String
    <DataMember()> _
    Public Property EstadoDisponibilidadBD() As String
        Get
            Return _estadoDisponibilidadBD
        End Get
        Set(ByVal value As String)
            _estadoDisponibilidadBD = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador que permite indicar si la réplica de la bd está Activa o no.
    ''' </summary>
    ''' <remarks></remarks>
    Private _estadoDisponibilidadReplica As String
    <DataMember()> _
    Public Property EstadoDisponibilidadReplica() As String
        Get
            Return _estadoDisponibilidadReplica
        End Get
        Set(ByVal value As String)
            _estadoDisponibilidadReplica = value
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_DisponibilidadBaseDatos
    ''' </summary>
    ''' <param name="disponibilidadBaseDatos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal disponibilidadBaseDatos As e_DisponibilidadBaseDatos) As e_DisponibilidadBaseDatos Implements Ie_DisponibilidadBaseDatos.Obtener
        Return disponibilidadBaseDatos
    End Function

    ''' <summary>
    ''' Función para obtener el estado de disponibilidad de acceso a la base de datos
    ''' a partir de la información contenida en el archivo de configuración Entorno.xml
    ''' ubicado en la carpeta compartida /Imagenes del servidor
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarDisponibilidadBD() As Boolean Implements Ie_DisponibilidadBaseDatos.VerificarDisponibilidadBD
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Creamos el "XML Document"
            m_xmld = New XmlDocument()
            If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la disponibilidad del acceso a la base de datos")
            m_xmld.Load(archivoXML)
            'Obtenemos la lista de los nodos "name"
            m_nodelist = m_xmld.SelectNodes("/Entorno/ConexionBD")
            'Iniciamos el ciclo de lectura
            For Each m_node In m_nodelist
                'Obtenemos el atributo del Estado
                EstadoDisponibilidadBD = m_node.Attributes.GetNamedItem("EstadoDisponibilidadBD").Value
                'Obtenemos el Elemento nombre
                MensajeInicial = m_node.ChildNodes.Item(0).InnerText
                'Obtenemos el Elemento apellido
                MensajeUsuariosConectados = m_node.ChildNodes.Item(1).InnerText
            Next
            If EstadoDisponibilidadBD = "Activa" Then Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para obtener el estado de disponibilidad de la replicación de datos
    ''' a partir de la información contenida en el archivo de configuración Entorno.xml
    ''' ubicado en la carpeta compartida /Imagenes del servidor    
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarDisponibilidadReplica() As Boolean Implements Ie_DisponibilidadBaseDatos.VerificarDisponibilidadReplica
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Creamos el "XML Document"
            m_xmld = New XmlDocument()
            If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la disponibilidad del acceso a la base de datos")
            m_xmld.Load(archivoXML)
            'Obtenemos la lista de los nodos "name"
            m_nodelist = m_xmld.SelectNodes("/Entorno/ConexionReplica")
            'Iniciamos el ciclo de lectura
            For Each m_node In m_nodelist
                'Obtenemos el atributo del Estado
                EstadoDisponibilidadReplica = m_node.Attributes.GetNamedItem("EstadoDisponibilidadReplica").Value
                'Obtenemos el Elemento nombre
                MensajeInicial = m_node.ChildNodes.Item(0).InnerText
                'Obtenemos el Elemento apellido
                MensajeUsuariosConectados = m_node.ChildNodes.Item(1).InnerText
            Next
            If EstadoDisponibilidadReplica = "Activa" Then Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FotosDisponibles() As Boolean
        Try
            If Directory.Exists(directorioFotos) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la fecha límite para creación y/o modificación de información almacenada en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FechaLimite(area As gAreasSGI) As Date
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Creamos el "XML Document"
            m_xmld = New XmlDocument()
            If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la última Fecha del acceso a la base de datos")
            m_xmld.Load(archivoXML)
            'Obtenemos la lista de los nodos "name"
            m_nodelist = m_xmld.SelectNodes("/Entorno/FechaLimite")
            'Iniciamos el ciclo de lectura
            Dim NroDias As String = String.Empty
            For Each m_node In m_nodelist
                Select Case area
                    Case gAreasSGI.Compras
                        NroDias = m_node.Attributes.GetNamedItem("Compras").Value
                    Case gAreasSGI.Ventas
                        NroDias = m_node.Attributes.GetNamedItem("Ventas").Value
                    Case gAreasSGI.Administracion
                        NroDias = m_node.Attributes.GetNamedItem("Administracion").Value
                    Case gAreasSGI.Contabilidad
                        NroDias = m_node.Attributes.GetNamedItem("Contabilidad").Value
                    Case gAreasSGI.Neumaticos
                        NroDias = m_node.Attributes.GetNamedItem("Neumaticos").Value
                    Case Else
                        Throw New Exception("Area sin datos de configuración para fecha límite")
                End Select
            Next
            Return DateSerial(Now.Year, Now.Month, CInt(NroDias))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FechaLimitePerfil(Perfil As String) As Integer
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Creamos el "XML Document"
            m_xmld = New XmlDocument()
            If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la última Fecha del acceso a la base de datos")
            m_xmld.Load(archivoXML)
            'Obtenemos la lista de los nodos "name"
            m_nodelist = m_xmld.SelectNodes("/Entorno/FechaLimitePerfil")
            'Iniciamos el ciclo de lectura
            Dim NroDias As String = String.Empty
            For Each m_node In m_nodelist
                Select Case Perfil
                    Case "Coordinador"
                        NroDias = m_node.Attributes.GetNamedItem("Coordinador").Value
                    Case "Jefe"
                        NroDias = m_node.Attributes.GetNamedItem("Jefe").Value
                    Case "Gerente"
                        NroDias = m_node.Attributes.GetNamedItem("Gerente").Value
                End Select
            Next
            Return CInt(NroDias)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

