Imports System.Collections

''' <summary>
''' Clase de tipo lista genérica para administrar los Tipos de Operación realizadas por los usuarios
''' </summary>
''' <remarks></remarks>
Public Class e_TiposOperaciones
    Inherits CollectionBase
    Implements Ie_TiposOperaciones

#Region "Constructores"

    Public Sub New()
        Inicializar()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Permite agregar un nuevo tipo de operación
    ''' </summary>
    Public Sub Agregar(ByVal tipoOperacion As e_TipoOperacion) Implements Ie_TiposOperaciones.Agregar
        MyBase.List.Add(tipoOperacion)
    End Sub

    ''' <summary>
    ''' Cuenta el número de tipos de operación que están disponibles
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Cuantos() As Integer Implements Ie_TiposOperaciones.Cuantos
        Return MyBase.List.Count
    End Function

    ''' <summary>
    ''' Asignar, establecer o actualizar un tipo de operación en un lugar específico de la lista
    ''' </summary>
    ''' <param name="indice">Indice o ubicación del tipo de operación</param>
    ''' <param name="tipoOperacion">Objeto tipo de operación a asignar o establecer</param>
    ''' <remarks></remarks>
    Public Sub Establecer(ByVal indice As Integer, ByVal tipoOperacion As e_TipoOperacion) Implements Ie_TiposOperaciones.Establecer
        MyBase.List(indice) = tipoOperacion
    End Sub

    ''' <summary>
    ''' Permite establecer la operación actual de la lista
    ''' </summary>
    ''' <param name="indice"></param>
    ''' <remarks></remarks>
    Public Sub EstablecerOperacionActual(ByVal indice As Integer) Implements Ie_TiposOperaciones.EstablecerOperacionActual
        For Each lista As e_TipoOperacion In MyBase.List
            lista.Actual = False
        Next
        Dim operacionActual As e_TipoOperacion = Obtener(indice)
        operacionActual.Actual = True
        Establecer(indice, operacionActual)
    End Sub

    ''' <summary>
    ''' Inicializar la lista de tipos de operación con los valores por defecto según corresponda
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub Inicializar() Implements Ie_TiposOperaciones.Inicializar
    End Sub

    ''' <summary>
    ''' Obtener un tipo de operación específico a partir de su ubicación en la lista
    ''' </summary>
    ''' <param name="indice">Indice del tipo de operación</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal indice As Integer) As e_TipoOperacion Implements Ie_TiposOperaciones.Obtener
        Return CType(MyBase.List(indice), e_TipoOperacion)
    End Function

    Public Function ObtenerOperacionActual() As e_TipoOperacion Implements Ie_TiposOperaciones.ObtenerOperacionActual
        Dim operacionActual As New e_TipoOperacion
        For Each lista As e_TipoOperacion In MyBase.List
            If lista.Actual = True Then
                operacionActual = lista
            End If
        Next
        Return operacionActual
    End Function

    ''' <summary>
    ''' Quitar, remover o eliminar un objeto de tipo e_TipoOperacion de la lista
    ''' </summary>
    ''' <param name="tipoOperacion"></param>
    ''' <remarks></remarks>
    Public Sub Quitar(ByVal tipoOperacion As e_TipoOperacion) Implements Ie_TiposOperaciones.Quitar
        MyBase.List.Remove(tipoOperacion)
    End Sub

    ''' <summary>
    ''' Quitar, remover o eliminar un tipo de operación a partir de su índice o número de orden
    ''' </summary>
    ''' <param name="indice"></param>
    ''' <remarks></remarks>
    Public Sub QuitarIndice(ByVal indice As Integer) Implements Ie_TiposOperaciones.QuitarIndice
        Try
            If indice <= Cuantos() - 1 OrElse indice >= 0 Then MyBase.List.RemoveAt(indice)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Quitar, remover y/o eliminar un tipo de operación a partir de su nombre
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <remarks></remarks>
    Public Sub QuitarNombre(ByVal dato As String) Implements Ie_TiposOperaciones.QuitarNombre
        Try
            If Not String.IsNullOrEmpty(dato) Then MyBase.List.Remove(dato)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Filtra los tipos de operación específicos
    ''' </summary>
    ''' <param name="tipoOperacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Filtro(ByVal tipoOperacion As e_TipoOperacion) As Boolean
        If tipoOperacion.Abreviatura.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class



