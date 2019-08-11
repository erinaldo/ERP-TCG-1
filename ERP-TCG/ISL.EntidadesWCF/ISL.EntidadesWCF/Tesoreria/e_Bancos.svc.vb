


''' <summary>
''' Clase que administra la información de listas de entidades de tipo e_Banco
''' </summary>
''' <remarks></remarks>
Public Class e_Bancos
    Implements Ie_Bancos

    Private Bancos As New List(Of e_Banco)

    ''' <summary>
    ''' Permite agregar un banco a la lista
    ''' </summary>
    ''' <param name="banco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Agregar(ByVal banco As e_Banco) As System.Collections.Generic.List(Of e_Banco) Implements Ie_Bancos.Agregar
        Bancos.Add(banco)
        Return Bancos
    End Function

    ''' <summary>
    ''' Cuenta el número de bancos listados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Cuantos() As Integer Implements Ie_Bancos.Cuantos
        Return Bancos.Count
    End Function

    ''' <summary>
    ''' Filtra bancos
    ''' </summary>
    ''' <param name="banco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Filtro(ByVal banco As e_Banco) As Boolean
        If banco.Nombre.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Filtra la lista de bancos 
    ''' </summary>
    ''' <param name="banco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Filtrar(ByVal banco As e_Banco) As System.Collections.Generic.List(Of e_Banco) Implements Ie_Bancos.Filtrar
        Try
            Dim resultado As List(Of e_Banco) = Bancos.FindAll(AddressOf Filtro)
            If resultado.Count = 0 Then Throw New Exception("Información no registrada")
            Return Bancos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene y genera una lista de bancos
    ''' </summary>
    ''' <param name="listaBancos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal listaBancos As System.Collections.Generic.List(Of e_Banco)) As System.Collections.Generic.List(Of e_Banco) Implements Ie_Bancos.Obtener
        Bancos.Clear()
        For Each banco As e_Banco In listaBancos
            Bancos.Add(banco)
        Next
        Return Bancos
    End Function

End Class


