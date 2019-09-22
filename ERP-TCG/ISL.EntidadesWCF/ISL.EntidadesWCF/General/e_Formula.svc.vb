''' <summary>
''' Clase para definir la entidad: Formula
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Formula
    Implements Ie_Formula
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_Formula)
    Implements IDisposable

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _datotrabajador As String
    Private _parametros As String
    Private _constantes As String
    Private _variables As String
    Private _instrucciones As String
    Private _esquema As String
    Private _descripcion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    Private _cad As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property DatoTrabajador() As String
        Get
            Return _datotrabajador
        End Get
        Set(ByVal value As String)
            _datotrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Parametros() As String
        Get
            Return _parametros
        End Get
        Set(ByVal value As String)
            _parametros = value
        End Set
    End Property

    <DataMember()> _
    Public Property Constantes() As String
        Get
            Return _constantes
        End Get
        Set(ByVal value As String)
            _constantes = value
        End Set
    End Property

    <DataMember()> _
    Public Property Variables() As String
        Get
            Return _variables
        End Get
        Set(ByVal value As String)
            _variables = value
        End Set
    End Property

    <DataMember()> _
    Public Property Instrucciones() As String
        Get
            Return _instrucciones
        End Get
        Set(ByVal value As String)
            _instrucciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property Esquema() As String
        Get
            Return _esquema
        End Get
        Set(ByVal value As String)
            _esquema = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _parametros = String.Empty
        _constantes = String.Empty
        _variables = String.Empty
        _instrucciones = String.Empty
        _esquema = String.Empty
        _descripcion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_DatoTrabajador As String _
              , ByVal ls_Parametros As String _
              , ByVal ls_Constantes As String _
              , ByVal ls_Variables As String _
              , ByVal ls_Instruccion As String _
              , ByVal ls_Descripcion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _datotrabajador = ls_DatoTrabajador
        _parametros = ls_Parametros
        _constantes = ls_Constantes
        _variables = ls_Variables
        _instrucciones = ls_Instruccion
        _cad = String.Empty
        If _datotrabajador.Trim <> "" Then _cad = _datotrabajador.Trim
        If _parametros.Trim <> "" Then _cad = IIf(_cad.Trim.Length > 0, _cad = _cad & "," & _parametros, _cad = _parametros)
        If _constantes.Trim <> "" Then _cad = IIf(_cad.Trim.Length > 0, _cad = _cad & "," & _constantes, _cad = _constantes)
        If _variables.Trim <> "" Then _cad = IIf(_cad.Trim.Length > 0, _cad = _cad & "," & _variables, _cad = _variables)
        _esquema = "Function " & _nombre & "()" & Environment.NewLine _
                            & _nombre & " = " & _instrucciones & Environment.NewLine _
                    & "End Function"
        _descripcion = ls_Descripcion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo

    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(formula As e_Formula) As e_Formula Implements Ie_Formula.Obtener
        Return formula
    End Function

    Public Overloads Function Equals(ByVal oeFor As e_Formula) As Boolean Implements System.IEquatable(Of e_Formula).Equals
        Select Case oeFor.Equivale
            Case 1 : If Me.Id = oeFor.Id Then Return True
            Case 2 : If Me.Codigo.Trim = oeFor.Codigo.Trim Then Return True
            Case 3 : If Me.Nombre.Trim = oeFor.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

#Region "IDisposable Support"

    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: eliminar estado administrado (objetos administrados).
            End If

            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: invalidar Finalize() sólo si la instrucción Dispose(ByVal disposing As Boolean) anterior tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Ponga el código de limpieza en la instrucción Dispose(ByVal disposing As Boolean) anterior.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
