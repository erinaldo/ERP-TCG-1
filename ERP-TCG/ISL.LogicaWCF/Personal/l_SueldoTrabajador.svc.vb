'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_SueldoTrabajador
    Implements Il_SueldoTrabajador

    Private odSueldoTrabajador As New d_SueldoTrabajador
    Private l_FuncionesGenerales As New l_FuncionesGenerales


    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_SueldoTrabajador.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_SueldoTrabajador.CrearDT
        Dim SueTra As New Data.DataTable
        With SueTra
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Sueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TipoPago", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Periocidad", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaActividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaInactividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Vigente", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return SueTra
    End Function

    Public Function Eliminar(ByVal oeSueldoTrabajador As EntidadesWCF.e_SueldoTrabajador) As Boolean Implements Il_SueldoTrabajador.Eliminar
        Try
            Return odSueldoTrabajador.Eliminar(oeSueldoTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSueldoTrabajador As EntidadesWCF.e_SueldoTrabajador) As Boolean Implements Il_SueldoTrabajador.Guardar
        Try
            If Validar(oeSueldoTrabajador) Then
                Return odSueldoTrabajador.Guardar(oeSueldoTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal leSueldoTrabajador As System.Collections.Generic.List(Of EntidadesWCF.e_SueldoTrabajador), ByVal PrefijoID As String) As Boolean Implements Il_SueldoTrabajador.GuardarMasivo
        Try
            Dim dtST As Data.DataTable = CrearDT()
            Dim id As String = odSueldoTrabajador.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeSueTra In leSueldoTrabajador
                Dim rwST As Data.DataRow
                rwST = dtST.NewRow
                With oeSueTra
                    rwST("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwST("IdTrabajador") = .IdTrabajador
                    rwST("Sueldo") = .Sueldo
                    rwST("TipoPago") = .TipoPago
                    rwST("Periocidad") = .Periocidad
                    rwST("FechaActividad") = .FechaActividad
                    rwST("FechaInactividad") = .FechaInactividad
                    rwST("Vigente") = .Vigente
                    rwST("FechaCreacion") = Date.Now
                    rwST("UsuarioCreacion") = .UsuarioCreacion
                    rwST("Activo") = True
                End With
                dtST.Rows.Add(rwST)
                lsNumero = lsNumero + 1
            Next
            Return odSueldoTrabajador.GuardarMasivo(dtST)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSueldoTrabajador As EntidadesWCF.e_SueldoTrabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_SueldoTrabajador) Implements Il_SueldoTrabajador.Listar
        Try
            Return odSueldoTrabajador.Listar(oeSueldoTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSueldoTrabajador As EntidadesWCF.e_SueldoTrabajador) As EntidadesWCF.e_SueldoTrabajador Implements Il_SueldoTrabajador.Obtener
        Try
            Return odSueldoTrabajador.Obtener(oeSueldoTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSueldoTrabajador As EntidadesWCF.e_SueldoTrabajador) As Boolean Implements Il_SueldoTrabajador.Validar
        Try
            With oeSueldoTrabajador
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "No ha Ingresado Trabajador")
                If .Sueldo = 0 Then Throw New Exception("El Saldo debe ser mayor o igual al Sueldo Minimo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
