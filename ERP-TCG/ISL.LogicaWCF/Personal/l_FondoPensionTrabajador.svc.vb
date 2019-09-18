Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FondoPensionTrabajador
    Implements Il_FondoPensionTrabajador

    Private odFondoPensionTrabajador As New d_FondoPensionTrabajador
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeFondoPensionTrabajador As EntidadesWCF.e_FondoPensionTrabajador) As Boolean Implements Il_FondoPensionTrabajador.Eliminar
        Try
            Return odFondoPensionTrabajador.Eliminar(oeFondoPensionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFondoPensionTrabajador As EntidadesWCF.e_FondoPensionTrabajador) As Boolean Implements Il_FondoPensionTrabajador.Guardar
        Try
            If Validar(oeFondoPensionTrabajador) Then
                Return odFondoPensionTrabajador.Guardar(oeFondoPensionTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(ByVal leFondoPensionTrabajador As System.Collections.Generic.List(Of EntidadesWCF.e_FondoPensionTrabajador), ByVal PrefijoID As String) As Boolean Implements Il_FondoPensionTrabajador.GuardarMasivo
        Try
            Dim dtRP As Data.DataTable = CrearDT()
            Dim id As String = odFondoPensionTrabajador.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeRegPen In leFondoPensionTrabajador
                Dim rwRP As Data.DataRow
                rwRP = dtRP.NewRow
                With oeRegPen
                    rwRP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwRP("IdEmpresa") = .IdEmpresa
                    rwRP("IdTrabajador") = .IdTrabajador
                    rwRP("CUSPP") = .CUSPP
                    rwRP("Mixta") = .Mixta
                    rwRP("FechaActividad") = .FechaActividad
                    rwRP("FechaInactividad") = .FechaInactividad
                    rwRP("Vigente") = .Vigente
                    rwRP("FechaCreacion") = Date.Now
                    rwRP("UsuarioCreacion") = .UsuarioCreacion
                    rwRP("Activo") = True
                End With
                dtRP.Rows.Add(rwRP)
                lsNumero = lsNumero + 1
            Next
            Return odFondoPensionTrabajador.GuardarMasivo(dtRP)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFondoPensionTrabajador As EntidadesWCF.e_FondoPensionTrabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_FondoPensionTrabajador) Implements Il_FondoPensionTrabajador.Listar
        Try
            Return odFondoPensionTrabajador.Listar(oeFondoPensionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeFondoPensionTrabajador As EntidadesWCF.e_FondoPensionTrabajador) As EntidadesWCF.e_FondoPensionTrabajador Implements Il_FondoPensionTrabajador.Obtener
        Try
            Return odFondoPensionTrabajador.Obtener(oeFondoPensionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFondoPensionTrabajador As EntidadesWCF.e_FondoPensionTrabajador) As Boolean Implements Il_FondoPensionTrabajador.Validar
        Try
            With oeFondoPensionTrabajador
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "No ha Ingresado Trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresa, "No ha Ingresado Empresa")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_FondoPensionTrabajador.CrearDT
        Dim FonPenTra As New Data.DataTable
        With FonPenTra
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEmpresa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CUSPP", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Mixta", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaActividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaInactividad", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Vigente", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return FonPenTra
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_FondoPensionTrabajador.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

End Class
