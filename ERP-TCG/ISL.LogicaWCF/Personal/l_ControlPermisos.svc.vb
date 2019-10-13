'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Globalization

Public Class l_ControlPermisos
    Implements Il_ControlPermisos
    Dim odControlPermisos As New d_ControlPermisos

    Public Function Obtener(ByVal oeControlPermisos As e_ControlPermisos) As e_ControlPermisos Implements Il_ControlPermisos.Obtener
        Try
            Return odControlPermisos.Obtener(oeControlPermisos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeControlPermisos As e_ControlPermisos) As List(Of e_ControlPermisos) Implements Il_ControlPermisos.Listar
        Try
            Return odControlPermisos.Listar(oeControlPermisos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean Implements Il_ControlPermisos.Validar
        Try
            With oeControlPermisos
                If .TipoOperacion = "I" AndAlso Not String.IsNullOrWhiteSpace(oeControlPermisos.IdTrabajador) Then
                    Dim oeCtrlPerm As New e_ControlPermisos
                    Dim loCtrlPerm As New List(Of e_ControlPermisos)
                    oeCtrlPerm.IdTrabajador = oeControlPermisos.IdTrabajador
                    oeCtrlPerm.TipoOperacion = ""
                    loCtrlPerm.AddRange(odControlPermisos.Listar(oeCtrlPerm))
                    If loCtrlPerm.Where(Function(item) item.IndConfirmaIngreso = False).ToList.Count > 0 Then
                        Throw New Exception("El Trabajador ya tiene un Permiso Vigente. Verificar")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean Implements Il_ControlPermisos.Guardar
        Try
            If Validar(oeControlPermisos) Then
                Return odControlPermisos.Guardar(oeControlPermisos)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean Implements Il_ControlPermisos.Eliminar
        Try
            Return odControlPermisos.Eliminar(oeControlPermisos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function GuardarMasivo(loControlPermisos As List(Of e_ControlPermisos), ByVal PrefijoID As String) As Boolean Implements Il_ControlPermisos.GuardarMasivo
        Try
            odControlPermisos = New d_ControlPermisos
            Dim XML As New StringBuilder
            XML.AppendLine("<DETALLES>")
            Dim Id As String = odControlPermisos.IdCodigoInsertar(PrefijoID)(0)
            Dim Codigo As String = odControlPermisos.IdCodigoInsertar(PrefijoID)(1)
            Dim lsPrefijo As String = Left(Id, 3)
            Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))
            Dim lsNumeroCodigo As Integer = CInt(Codigo)
            For Each _Permiso As e_ControlPermisos In loControlPermisos
                With _Permiso
                    XML.AppendLine("<DETALLE><Id>" & lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(Id) - 3) & "</Id>")
                    XML.AppendLine("<Codigo>" & CompletaConCeros(lsNumeroCodigo.ToString, Len(Codigo)) & "</Codigo>")
                    XML.AppendLine("<IdSituacionAdministrativa>" & .IdSituacionAdministrativa & "</IdSituacionAdministrativa>")
                    XML.AppendLine("<IdTrabajador>" & .IdTrabajador & "</IdTrabajador>")
                    XML.AppendLine("<IdArea>" & .IdArea & "</IdArea>")
                    XML.AppendLine("<IdCentro>" & .IdCentro & "</IdCentro>")
                    XML.AppendLine("<IdOcupacion>" & .IdOcupacion & "</IdOcupacion>")
                    XML.AppendLine("<Fecha>" & .Fecha.ToString("MM/dd/yyyy HH:mm") & "</Fecha>")
                    XML.AppendLine("<FechaSalida>" & .FechaSalida.ToString("MM/dd/yyyy HH:mm") & "</FechaSalida>")
                    XML.AppendLine("<FechaIngreso>" & .FechaIngreso.ToString("MM/dd/yyyy HH:mm") & "</FechaIngreso>")
                    XML.AppendLine("<Motivo>" & .Motivo & "</Motivo>")
                    XML.AppendLine("<Observacion>" & .Observacion & "</Observacion>")
                    XML.AppendLine("<TipoPermiso>" & .TipoPermiso & "</TipoPermiso>")
                    XML.AppendLine("<IndConfirmaSalida>" & Convert.ToInt64(.IndConfirmaSalida) & "</IndConfirmaSalida>")
                    XML.AppendLine("<FechaConfirmaSalida>" & .FechaConfirmaSalida.ToString("MM/dd/yyyy HH:mm") & "</FechaConfirmaSalida>")
                    XML.AppendLine("<IndConfirmaIngreso>" & Convert.ToInt64(.IndConfirmaIngreso) & "</IndConfirmaIngreso>")
                    XML.AppendLine("<FechaConfirmaIngreso>" & .FechaConfirmaIngreso.ToString("MM/dd/yyyy HH:mm") & "</FechaConfirmaIngreso>")
                    XML.AppendLine("<IdJefeArea>" & .IdJefeArea & "</IdJefeArea>")
                    XML.AppendLine("<IdJefeAdministracion>" & .IdJefeAdministracion & "</IdJefeAdministracion>")
                    XML.AppendLine("<IndPapeleta>" & .IndPapeleta & "</IndPapeleta>")
                    XML.AppendLine("<IndVenta>" & .IndVenta & "</IndVenta>")
                    XML.AppendLine("<FechaInicioVta>" & .FechaInicioVtaVacaciones.ToString("MM/dd/yyyy HH:mm") & "</FechaInicioVta>")
                    XML.AppendLine("<FechaFinVta>" & .FechaFinVtaVacaciones.ToString("MM/dd/yyyy HH:mm") & "</FechaFinVta>")
                    XML.AppendLine("<UsuarioCreacion>" & .UsuarioCreacion & "</UsuarioCreacion>")
                    XML.AppendLine("<FechaCreacion>" & .FechaCreacion.ToString("MM/dd/yyyy HH:mm") & "</FechaCreacion>")
                    XML.AppendLine("<Activo>" & .Activo & "</Activo>")
                    XML.AppendLine("<TotalDias>" & .TotalDias & "</TotalDias>")
                    XML.AppendLine("<IndGoce>" & .IndGoce & "</IndGoce></DETALLE>")
                End With
                lsNumero += 1
                lsNumeroCodigo += 1
            Next
            XML.AppendLine("</DETALLES>")
            Return odControlPermisos.GuardarMasivo(XML.ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String
        Try
            Dim Retorna As String = ""
            For i As Integer = 1 To lnCantidad - Len(ls_Tex)
                Retorna = Retorna & "0"
            Next
            Return Retorna + ls_Tex
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
