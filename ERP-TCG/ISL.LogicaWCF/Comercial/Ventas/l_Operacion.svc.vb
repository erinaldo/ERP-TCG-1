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
Public Class l_Operacion
    Implements Il_Operacion

    Dim odOperacion As New d_Operacion

    Public Function EliminarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean Implements Il_Operacion.EliminarOperacionDetalle
        Try
            Return odOperacion.EliminarOperacionDetalle(oeOperacionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarViaje(ByVal oeViaje As e_Viaje) As Boolean Implements Il_Operacion.EliminarViaje
        Try
            Return odOperacion.EliminarViaje(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarViajes(ByVal oeViaje As e_Viaje) As String
        Try
            Return odOperacion.EliminarViajeDemanda(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GuardarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean Implements Il_Operacion.GuardarOperacionDetalle
        Try
            If ValidarOperacionDetalle(oeOperacionDetalle) Then
                Return odOperacion.GuardarOperacionDetalle(oeOperacionDetalle)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarOperacionDetalleLista(ByVal OperacionDetalleLista As List(Of e_OperacionDetalle)) As Boolean Implements Il_Operacion.GuardarOperacionDetalleLista
        Try
            Return odOperacion.GuardarOperacionDetalleLista(OperacionDetalleLista)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarViaje(ByVal oeViaje As e_Viaje) As Boolean Implements Il_Operacion.GuardarViaje
        Try
            If ValidarViaje(oeViaje) Then odOperacion.GuardarViaje(oeViaje)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacion As e_Operacion) As Boolean Implements Il_Operacion.Eliminar
        Try
            Return odOperacion.Eliminar(oeOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOperacion As e_Operacion) As Boolean Implements Il_Operacion.Guardar
        Try
            If Validar(oeOperacion) Then
                Return odOperacion.Guardar(oeOperacion)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarODBloeque(ByVal ListaPTP As List(Of e_ProcesarTarifasProceso), ByVal ListaOD As List(Of e_OperacionDetalle)) As Boolean Implements Il_Operacion.GuardarODBloque
        Try
            Return odOperacion.GuardarODBloque(ListaPTP, ListaOD)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function ActualizaLista(ByVal oeViaje As e_Viaje) As Boolean
    '    Try
    '        Return TreeNode
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function Listar(ByVal oeOperacion As e_Operacion) As System.Collections.Generic.List(Of e_Operacion) Implements Il_Operacion.Listar
        Try
            Return odOperacion.Listar(oeOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As System.Collections.Generic.List(Of e_OperacionDetalle) Implements Il_Operacion.ListarOperacionDetalle
        Try
            Return odOperacion.ListarOperacionDetalle(oeOperacionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarViaje(ByVal oeViaje As e_Viaje) As System.Collections.Generic.List(Of e_Viaje) Implements Il_Operacion.ListarViaje
        Try
            Return odOperacion.ListarViaje(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarViajeLurin(ByVal oeViaje As e_Viaje) As DataTable Implements Il_Operacion.ListarViajeLurin
        Try
            Return odOperacion.ListarViajesLurin(oeViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarViajeProceso(ByVal oeViaje As e_Viaje) As DataSet Implements Il_Operacion.ListarViajeProceso
        Try
            Return odOperacion.ListarViajesProceso(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarViajeDT(ByVal oeViaje As e_Viaje) As DataTable Implements Il_Operacion.ListarViajeDT
        Try
            Return odOperacion.ListarViajeDT(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDocumentosViaje(ByVal oeViaje As e_Viaje) As System.Data.DataTable Implements Il_Operacion.ListarDocumentosViaje
        Try
            Return odOperacion.ListarDocumentosViaje(oeViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeDetalleDocOpeDet As e_DetalleDoc_OperacionDet) As System.Collections.Generic.List(Of e_DetalleDoc_OperacionDet) Implements Il_Operacion.ListarDS
        Try
            Return odOperacion.ListarOperacionDetalleDS(oeDetalleDocOpeDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarFletes(ByVal oeViaje As e_Viaje) As System.Collections.Generic.List(Of e_Viaje) Implements Il_Operacion.ListarFletes
        Try
            Return odOperacion.ListarFletes(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarVehiculoEstadoSituacional() As System.Data.DataTable Implements Il_Operacion.ListarVehiculoEstadoSituacional
        Try
            Return odOperacion.ListarVehiculoEstadoSituacional()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacion As e_Operacion) As e_Operacion Implements Il_Operacion.Obtener
        Try
            Return odOperacion.Obtener(oeOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle Implements Il_Operacion.ObtenerOperacionDetalle
        Try
            Return odOperacion.ObtenerOperacionDetalle(oeOperacionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerViaje(ByVal oeViaje As e_Viaje) As e_Viaje Implements Il_Operacion.ObtenerViaje
        Try
            Return odOperacion.ObtenerViaje(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerRango(ByVal oeViaje As e_Viaje) As e_Viaje Implements Il_Operacion.ObtenerRango
        Try
            Return odOperacion.ObtenerViajeRango(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeOperacion As e_Operacion) As Boolean Implements Il_Operacion.Validar
        Try
            With oeOperacion
                '---------VALIDARRRRRRRRRR-------------                
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarOperacionDetalle(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean Implements Il_Operacion.ValidarOperacionDetalle
        Try
            With oeOperacionDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarViaje(ByVal oeViaje As e_Viaje) As Boolean Implements Il_Operacion.ValidarViaje
        Try
            With oeViaje
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegfacturarOperacionDet(ByVal oeOperacionDetalle As e_OperacionDetalle) As Boolean Implements Il_Operacion.RegfacturarOperacionDet
        Try
            Return odOperacion.RefacturarOperacionDet(oeOperacionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(ByVal oeViaje As e_Viaje) As System.Data.DataSet Implements Il_Operacion.ListarDataSet
        Try
            Return odOperacion.ListarDataSet(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSetViajesAntiguos(ByVal oeViaje As e_Viaje) As System.Data.DataSet Implements Il_Operacion.ListarDataSetViajesAntiguos
        Try
            Return odOperacion.ListarDataSetViajesAntiguos(oeViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerOperacionDetalleViaje(ByVal oeOperacionDetalle As e_OperacionDetalle) As e_OperacionDetalle Implements Il_Operacion.ObtenerOperacionDetalleViaje
        Try
            Return odOperacion.ObtenerOperacionDetalleViaje(oeOperacionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
