Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_ReporteFlujoBanco
    Implements Il_ReporteFlujoBanco
    Dim odReporteFlujoBanco As New d_ReporteFlujoBanco
    Dim olFuncionesGenerales As New l_FuncionesGenerales

    Public Function Listar(oe As EntidadesWCF.e_ReporteFlujoBanco) As List(Of EntidadesWCF.e_ReporteFlujoBanco) Implements Il_ReporteFlujoBanco.Listar
        Try
            Return odReporteFlujoBanco.Listar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(lo As List(Of EntidadesWCF.e_ReporteFlujoBanco), IdPeriodo As String, ByVal PrefijoID As String) As Boolean Implements Il_ReporteFlujoBanco.Guardar
        Try
            Using TransScope As New TransactionScope()
                If olFuncionesGenerales.ValidarPeriodo(IdPeriodo, gAreasSGI.Tesoreria) Then
                    ' Insertar
                    Dim dt As Data.DataTable = CrearDT()
                    Dim IdReporteFlujo As String = odReporteFlujoBanco.UltimoIdInserta(PrefijoID)
                    Dim lsPrefijo As String = Left(IdReporteFlujo, 3)
                    Dim lsNumeroIdReporteFlujo As Integer = CInt(Right(IdReporteFlujo, Len(IdReporteFlujo) - 3))
                    For Each oe In lo.Where(Function(it) it.Id.Trim = "" And it.IdFlujoNuevo.Trim <> "").ToList
                        Dim rowRepFlu As Data.DataRow
                        With oe
                            rowRepFlu = dt.NewRow
                            rowRepFlu("Id") = lsPrefijo + olFuncionesGenerales.CompletaConCeros(lsNumeroIdReporteFlujo, 12)
                            rowRepFlu("IdPeriodo") = .IdPeriodo
                            rowRepFlu("IdMovCajaBanco") = .IdMovCajaBanco
                            rowRepFlu("IdFlujoNuevo") = .IdFlujoNuevo
                            rowRepFlu("IngresoEgreso") = .IngresoEgreso
                            rowRepFlu("IndFinanciamiento") = .IndFinanciamiento
                            rowRepFlu("FechaCreacion") = Date.Now
                            rowRepFlu("UsuarioCreacion") = .UsuarioCreacion
                            lsNumeroIdReporteFlujo += 1
                            dt.Rows.Add(rowRepFlu)
                        End With
                    Next
                    If dt.Rows.Count > 0 Then odReporteFlujoBanco.GuardaMasivo(dt)
                    ' Actualizar 
                    Dim _IdFBAux As String = String.Empty
                    Dim _oeRFBAux As New e_ReporteFlujoBanco
                    _oeRFBAux.PrefijoID = PrefijoID '@0001
                    Dim _leRFB As New List(Of e_ReporteFlujoBanco)
                    Dim _lsCadena As String = ""
                    Dim _lbAdd As Boolean = False
                    For Each oe In lo.Where(Function(it) it.Id.Trim <> "" And it.IdFlujoNuevo.Trim <> it.IdFlujoApoyo).OrderBy(Function(it) it.IdFlujoApoyo).ToList
                        If _IdFBAux <> oe.IdFlujoNuevo Then
                            If _lbAdd Then
                                _lsCadena = _lsCadena.Substring(0, Len(_lsCadena) - 1)
                                _oeRFBAux.Id = _lsCadena
                                _oeRFBAux.IdFlujoNuevo = _IdFBAux
                                _leRFB.Add(_oeRFBAux)
                            End If
                            _IdFBAux = oe.IdFlujoNuevo
                            _oeRFBAux = New e_ReporteFlujoBanco
                            _oeRFBAux.PrefijoID = PrefijoID '@0001
                            _lbAdd = True
                            _lsCadena = String.Empty
                            _lsCadena = "'" & oe.Id & "',"
                        Else
                            _lsCadena = _lsCadena & "'" & oe.Id & "',"
                        End If
                    Next
                    If _lbAdd Then
                        _lsCadena = _lsCadena.Substring(0, Len(_lsCadena) - 1)
                        _oeRFBAux.Id = _lsCadena
                        _oeRFBAux.IdFlujoNuevo = _IdFBAux
                        _leRFB.Add(_oeRFBAux)
                    End If
                    If _leRFB.Count > 0 Then odReporteFlujoBanco.ActualizarLista(_leRFB)
                    TransScope.Complete()
                    Return True
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(IdPeriodo As String) As Boolean Implements Il_ReporteFlujoBanco.Validar
        Try
            Dim oe As New EntidadesWCF.e_ReporteFlujoBanco
            Dim lo As New List(Of EntidadesWCF.e_ReporteFlujoBanco)
            oe.IdPeriodo = IdPeriodo
            oe.TipoOperacion = "1"
            lo = odReporteFlujoBanco.Listar(oe)
            If lo.Count > 0 Then Throw New Exception("Ya Guardo los Flujos para Este Periodo")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As Data.DataTable
        Dim Reporte As New Data.DataTable
        With Reporte
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovCajaBanco", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdFlujoNuevo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IngresoEgreso", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndFinanciamiento", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
        End With
        Return Reporte
    End Function

End Class
