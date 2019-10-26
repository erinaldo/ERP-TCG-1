
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ConfiguracionTabla
    Implements Il_ConfiguracionTabla

    Dim odConfiguracionTabla As New d_ConfiguracionTabla
    Private olConfDato As New l_ConfiguracionDato, odConfDato As New d_ConfiguracionDato
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean Implements Il_ConfiguracionTabla.Eliminar
        Try
            Return odConfiguracionTabla.Eliminar(oeConfiguracionTabla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean Implements Il_ConfiguracionTabla.Guardar
        Try
            If Validar(oeConfiguracionTabla) Then
                Dim dtCDato As Data.DataTable = olConfDato.CrearDT
                Dim id As String = odConfDato.UltimoIdInserta(oeConfiguracionTabla.PrefijoID)
                Dim lsPrefijo As String = Left(id, 3)
                Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))
                Dim _leDatoAux = oeConfiguracionTabla.leDato.Where(Function(it) it.TipoOperacion = "I").ToList
                If _leDatoAux.Count > 0 Then
                    For Each oeRegPen In _leDatoAux
                        Dim rwCD As Data.DataRow
                        rwCD = dtCDato.NewRow
                        With oeRegPen
                            rwCD("Id") = lsPrefijo & olConfDato.CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                            rwCD("IdColumna") = .IdColumna
                            rwCD("NroFila") = .NroFila
                            rwCD("Descripcion") = .Descripcion
                            rwCD("TipoReferencia") = .TipoReferencia
                            rwCD("IdReferencia") = .IdReferencia
                            rwCD("FechaCreacion") = Date.Now.Date
                            rwCD("UsuarioCreacion") = .UsuarioCreacion
                            rwCD("FechaModifica") = .FechaModifica
                            rwCD("UsuarioModifica") = .UsuarioModifica
                            rwCD("Activo") = .Activo
                        End With
                        dtCDato.Rows.Add(rwCD)
                        lsNumero = lsNumero + 1
                    Next
                    oeConfiguracionTabla.dsCDato = dtCDato
                End If
                Return odConfiguracionTabla.Guardar(oeConfiguracionTabla)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeConfiguracionTabla As e_ConfiguracionTabla) As List(Of e_ConfiguracionTabla) Implements Il_ConfiguracionTabla.Listar
        Try
            Return odConfiguracionTabla.Listar(oeConfiguracionTabla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeConfiguracionTabla As e_ConfiguracionTabla) As e_ConfiguracionTabla Implements Il_ConfiguracionTabla.Obtener
        Try
            Return odConfiguracionTabla.Obtener(oeConfiguracionTabla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean Implements Il_ConfiguracionTabla.Validar
        Try
            With oeConfiguracionTabla
                l_FuncionesGenerales.ValidarCampoNoNulo(oeConfiguracionTabla.Nombre, "No se ha Ingresado Nombre")
                If .leColumna.Count < 2 Then
                    Throw New Exception("Ingrese al menos 2 Columnas")
                Else
                    Dim leColAux = .leColumna.Where(Function(it) it.IndClave = 1).ToList
                    If leColAux.Count <> 1 Then Throw New Exception("Debe seleccionar una Clave Principal para la Tabla: " & .Nombre)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
