'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Lugar
    Implements Il_Lugar

    Dim odLugar As New d_Lugar
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Private Function ValidarDuplicado(ByVal oeLugar As e_Lugar) As Boolean
        Try
            Dim _TipoOperacion As String = oeLugar.TipoOperacion
            oeLugar.TipoOperacion = "V"
            If odLugar.Listar(oeLugar).Count > 0 Then
                Throw New Exception("Ya existe lugar: " & oeLugar.Nombre)
            End If
            oeLugar.TipoOperacion = _TipoOperacion
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaLugar As System.Collections.Generic.List(Of e_Lugar)) As Object Implements Il_Lugar.ComboGrilla
        Try
            Return odLugar.ComboGrilla(ListaLugar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeLugar As e_Lugar) As Boolean Implements Il_Lugar.Eliminar
        Try
            Return odLugar.Eliminar(oeLugar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeLugar As e_Lugar) As Boolean Implements Il_Lugar.Guardar
        Try
            If Validar(oeLugar) Then
                Return odLugar.Guardar(oeLugar)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeLugar As e_Lugar) As System.Collections.Generic.List(Of e_Lugar) Implements Il_Lugar.Listar
        Try
            Return odLugar.Listar(oeLugar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As List(Of e_ClienteLugar) Implements Il_Lugar.ListarClienteLugar
        Try
            Return odLugar.ListarClienteLugar(oeClienteLugar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As List(Of e_VentanaHoraria) Implements Il_Lugar.ListarVentanaHoraria
        Try
            Return odLugar.ListarVentanaHoraria(oeVentanaHoraria)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLugar As e_Lugar) As e_Lugar Implements Il_Lugar.Obtener
        Try
            Return odLugar.Obtener(oeLugar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeLugar As e_Lugar) As Boolean Implements Il_Lugar.Validar
        Try
            If oeLugar.TipoOperacion <> "B" Then
                With oeLugar
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar un nombre")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdUbigeo, "Debe seleccionar el ubigeo")
                    ValidarDuplicado(oeLugar)
                End With
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function VerificarAntesEliminar(ByVal oeLugar As e_Lugar) As Integer
        Try
            Return odLugar.VerificarAntesEliminar(oeLugar)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
