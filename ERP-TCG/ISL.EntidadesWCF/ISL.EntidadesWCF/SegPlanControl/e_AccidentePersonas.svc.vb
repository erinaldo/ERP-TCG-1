''' <summary>
''' Clase para administrar la lista de personas vinculadas a accidentes
''' </summary>
''' <remarks></remarks>
Public Class e_AccidentePersonas
    Implements Ie_AccidentePersonas

    Private AccidentePersonas As New List(Of e_AccidentePersona)

    ''' <summary>
    ''' Permite agregar o vincular una persona a un accidente
    ''' </summary>
    ''' <param name="accidentePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Agregar(ByVal accidentePersona As e_AccidentePersona) As System.Collections.Generic.List(Of e_AccidentePersona) Implements Ie_AccidentePersonas.Agregar
        Try
            If String.IsNullOrEmpty(accidentePersona.IdTrabajador) Then Throw New Exception("No se ha asignado ningún trabajador")
            AccidentePersonas.Add(accidentePersona)
            Return AccidentePersonas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Cuenta el número de personas vinculadas al accidente 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Cuantos() As Integer Implements Ie_AccidentePersonas.Cuantos
        Return AccidentePersonas.Count
    End Function

    ''' <summary>
    ''' Filtra las personas que participan en un accidente 
    ''' </summary>
    ''' <param name="accidentePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Filtro(ByVal accidentePersona As e_AccidentePersona) As Boolean
        If accidentePersona.IdTrabajador.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtiene y genera una lista de personas que participan en un accidente 
    ''' </summary>
    ''' <param name="listaAccidentePersonas"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal listaAccidentePersonas As System.Collections.Generic.List(Of e_AccidentePersona)) As System.Collections.Generic.List(Of e_AccidentePersona) Implements Ie_AccidentePersonas.Obtener
        AccidentePersonas.Clear()
        For Each accidentePersona As e_AccidentePersona In listaAccidentePersonas
            AccidentePersonas.Add(accidentePersona)
        Next
        Return AccidentePersonas
    End Function

    ''' <summary>
    ''' Filtra la lista de personas que participan en un accidente 
    ''' </summary>
    ''' <param name="accidentePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Filtrar(ByVal accidentePersona As e_AccidentePersona) As System.Collections.Generic.List(Of e_AccidentePersona) Implements Ie_AccidentePersonas.Filtrar
        Try
            Dim resultado As List(Of e_AccidentePersona) = AccidentePersonas.FindAll(AddressOf Filtro)
            If resultado.Count = 0 Then Throw New Exception("Información no registrada")
            Return AccidentePersonas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Quitar o desvincular una persona de un accidente
    ''' </summary>
    ''' <param name="accidentePersona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Quitar(ByVal accidentePersona As e_AccidentePersona) As System.Collections.Generic.List(Of e_AccidentePersona) Implements Ie_AccidentePersonas.Quitar
        Try
            If String.IsNullOrEmpty(accidentePersona.IdTrabajador) Then Throw New Exception("No se ha asignado ningún trabajador")
            'Dim resultado As List(Of e_AccidentePersona) = AccidentePersonas.RemoveAll(AddressOf Filtro)
            'If resultado.Count = 0 Then Throw New Exception("Información no registrada")
            Return AccidentePersonas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
