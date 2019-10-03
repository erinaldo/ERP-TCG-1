Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_BonificacionProduccion
    Implements Il_BonificacionProduccion

    Private odBonificacionProduccion As New d_BonificacionProduccion
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeBonificacionProduccion As EntidadesWCF.e_BonificacionProduccion) As Boolean Implements Il_BonificacionProduccion.Eliminar
        Try
            Return odBonificacionProduccion.Eliminar(oeBonificacionProduccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeBonificacionProduccion As EntidadesWCF.e_BonificacionProduccion) As Boolean Implements Il_BonificacionProduccion.Guardar
        Try
            If Validar(oeBonificacionProduccion) Then
                Return odBonificacionProduccion.Guardar(oeBonificacionProduccion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeBonificacionProduccion As EntidadesWCF.e_BonificacionProduccion) As List(Of EntidadesWCF.e_BonificacionProduccion) Implements Il_BonificacionProduccion.Listar
        Try
            Return odBonificacionProduccion.Listar(oeBonificacionProduccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeBonificacionProduccion As EntidadesWCF.e_BonificacionProduccion) As EntidadesWCF.e_BonificacionProduccion Implements Il_BonificacionProduccion.Obtener
        Try
            Return odBonificacionProduccion.Obtener(oeBonificacionProduccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeBonificacionProduccion As EntidadesWCF.e_BonificacionProduccion) As Boolean Implements Il_BonificacionProduccion.Validar
        Try
            With oeBonificacionProduccion
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_BonificacionProduccion.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_BonificacionProduccion.CrearDT
        Dim BonPro As New Data.DataTable
        With BonPro
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoPlanilla", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoCaja", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndRuta", Type.GetType("System.Int16")))
        End With
        Return BonPro
    End Function

    Public Function GuardarMasivo(leBonificacionProduccion As List(Of e_BonificacionProduccion), ByVal PrefijoID As String) As Boolean Implements Il_BonificacionProduccion.GuardarMasivo
        Try
            Dim dtBP As Data.DataTable = CrearDT()
            Dim id As String = odBonificacionProduccion.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeSueTra In leBonificacionProduccion
                Dim rwBP As Data.DataRow
                rwBP = dtBP.NewRow
                With oeSueTra
                    rwBP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwBP("IdPlanilla") = .IdPlanilla
                    rwBP("IdTrabajador") = .IdTrabajador
                    rwBP("MontoPlanilla") = .MontoPlanilla
                    rwBP("MontoCaja") = .MontoCaja
                    rwBP("IndRuta") = .IndRuta
                    rwBP("FechaCreacion") = Date.Now.Date
                    rwBP("UsuarioCreacion") = .UsuarioCreacion
                    rwBP("FechaModifica") = .FechaModifica
                    rwBP("UsuarioModifica") = .UsuarioModifica
                    rwBP("Activo") = .Activo
                End With
                dtBP.Rows.Add(rwBP)
                lsNumero = lsNumero + 1
            Next
            Return odBonificacionProduccion.GuardarMasivo(dtBP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
