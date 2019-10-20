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
Public Class l_Neumatico
    Implements Il_Neumatico

    Dim odNeumatico As New d_Neumatico
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeNeumatico As e_Neumatico) As Boolean Implements Il_Neumatico.Eliminar
        Try
            Return odNeumatico.Eliminar(oeNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeNeumatico As e_Neumatico) As Boolean Implements Il_Neumatico.Guardar
        Try
            If Validar(oeNeumatico) Then
                Return odNeumatico.Guardar(oeNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeNeumatico As e_Neumatico) As System.Collections.Generic.List(Of e_Neumatico) Implements Il_Neumatico.Listar
        Try
            Return odNeumatico.Listar(oeNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeNeumatico As e_Neumatico) As System.Data.DataSet Implements Il_Neumatico.ListarDS
        Try
            Return odNeumatico.ListarDS(oeNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeNeumatico As e_Neumatico) As e_Neumatico Implements Il_Neumatico.Obtener
        Try
            Return odNeumatico.Obtener(oeNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeNeumatico As e_Neumatico) As Boolean Implements Il_Neumatico.Validar
        Try
            With oeNeumatico
                l_FuncionesGenerales.ValidarCampoNoNulo(oeNeumatico.Codigo, "No ha ingresado Codigo nuevo: ")
                ValidarDuplicado(oeNeumatico.Id, oeNeumatico.Codigo)
                If oeNeumatico.TipoOperacion <> "C" Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(oeNeumatico.IdMaterial, "Seleccione un material")
                    l_FuncionesGenerales.ValidarCampoNoNulo(oeNeumatico.IdMarca, "Seleccione una marca ")
                    l_FuncionesGenerales.ValidarCampoNoNulo(oeNeumatico.IdDiseño, "Seleccione un diseño ")
                    l_FuncionesGenerales.ValidarNumero(.CostoTotalSoles, "Ingrese un costo en soles.")
                    l_FuncionesGenerales.ValidarNumero(.CostoTotalDolares, "Ingrese un costo en dolares.")
                    l_FuncionesGenerales.ValidarNumero(.CostoCascoDolares, "Ingrese un costo del casco.")
                    l_FuncionesGenerales.ValidarNumero(.CocadaMinima, "Ingrese un valor a la cocada minima.")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Codigo As String) As Boolean Implements Il_Neumatico.ValidarDuplicado
        Try
            Dim objNeumatico As New e_Neumatico
            objNeumatico.TipoOperacion = ""
            objNeumatico.Codigo = ls_Codigo
            objNeumatico.Activo = True
            objNeumatico = odNeumatico.Obtener(objNeumatico)
            If objNeumatico.Id <> Nothing Then
                If ls_Id = "" OrElse objNeumatico.Id <> ls_Id Then Throw New Exception("Ya existe: " & ls_Codigo)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Confirmar(ByVal oeNeumatico As e_Neumatico) As Boolean Implements Il_Neumatico.Confirmar
        Try
            If Validar(oeNeumatico) Then
                Return odNeumatico.ConfirmarNeu(oeNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizarKmGeneral() As Boolean Implements Il_Neumatico.ActualizarKmGeneral
        Try
            Dim oeNeumantico As New e_Neumatico
            Dim oeVidaNeumantico As New e_VidaNeumatico
            Dim oeOperacionNeumantico As New e_OperacionNeumatico
            Dim ListaNeumatico As New List(Of e_Neumatico)
            Dim ListaVidaNeumatico As New List(Of e_VidaNeumatico)
            Dim ListaOperacionNeumatico As New List(Of e_OperacionNeumatico)
            Dim olVidaNeumatico As New l_VidaNeumatico
            Dim olOperacionNeumatico As New l_OperacionNeumatico

            oeNeumantico.TipoOperacion = "T"
            oeNeumantico.Activo = True
            ListaNeumatico = odNeumatico.Listar(oeNeumantico)

            oeVidaNeumantico.TipoOperacion = "T"
            oeVidaNeumantico.Activo = True
            ListaVidaNeumatico = olVidaNeumatico.Listar(oeVidaNeumantico)

            oeOperacionNeumantico.TipoOperacion = "T"
            oeOperacionNeumantico.Activo = True
            ListaOperacionNeumatico = olOperacionNeumatico.Listar(oeOperacionNeumantico)

            For Each oeNeu In ListaNeumatico
                If oeNeu.Codigo = "00004152" Then oeNeu.Codigo = "00004152"
                Dim lisAuxVidaNeu = ListaVidaNeumatico.Where(Function(x) x.IdNeumatico = oeNeu.Id).ToList
                For Each oeVidaN In lisAuxVidaNeu
                    Dim lisOpeNeu = ListaOperacionNeumatico.Where(Function(y) y.IdVidaNeumatico = oeVidaN.Id).ToList
                    Dim _idVeh As String = "", _KmVehIni As Double = 0, _kmNeuIni As Double = 0, _OpePriVeh As Boolean = False, _band As Boolean = False
                    Dim _kmVida As Double = 0
                    For Each oeOpeNeuAux In lisOpeNeu.OrderBy(Function(it) it.FechaOperacion).ToList
                        oeOperacionNeumantico = New e_OperacionNeumatico
                        oeOperacionNeumantico.Equivale = 1
                        oeOperacionNeumantico.Id = oeOpeNeuAux.Id
                        If lisOpeNeu.Contains(oeOperacionNeumantico) Then
                            oeOperacionNeumantico = lisOpeNeu.Item(lisOpeNeu.IndexOf(oeOperacionNeumantico))
                            oeOperacionNeumantico.TipoOperacion = "A"
                        End If
                        If _idVeh <> oeOpeNeuAux.IdVehiculo Then
                            _idVeh = oeOpeNeuAux.IdVehiculo
                            _OpePriVeh = False
                        End If
                        If oeOpeNeuAux.Posicion < 0 Then _OpePriVeh = False
                        If Not _OpePriVeh Then
                            _OpePriVeh = True
                            If Not _band Then _kmNeuIni = oeOpeNeuAux.KmNeumatico
                            _KmVehIni = oeOpeNeuAux.KmVehiculo
                            oeOperacionNeumantico.KmNeumatico = _kmNeuIni
                        Else
                            oeOperacionNeumantico.KmNeumatico = _kmNeuIni + (oeOpeNeuAux.KmVehiculo - _KmVehIni)
                            _kmNeuIni = _kmNeuIni + (oeOpeNeuAux.KmVehiculo - _KmVehIni)
                            _KmVehIni = oeOpeNeuAux.KmVehiculo
                        End If
                        _band = True
                    Next
                    _kmVida = _kmNeuIni
                    oeVidaN.TipoOperacion = "K"
                    oeVidaN.Kilometraje = _kmVida
                    oeVidaN.leOpeNeuAux = lisOpeNeu.Where(Function(it) it.TipoOperacion = "A").ToList
                    If olVidaNeumatico.ActualizaKM(oeVidaN) Then
                        oeNeu.TipoOperacion = "G"
                        GuardarSinValidar(oeNeu)
                    End If
                Next
            Next
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarSinValidar(ByVal oeNeumatico As e_Neumatico) As Boolean Implements Il_Neumatico.GuardarSinValidar
        Try
            Return odNeumatico.Guardar(oeNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
