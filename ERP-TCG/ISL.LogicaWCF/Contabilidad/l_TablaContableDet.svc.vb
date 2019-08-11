Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TablaContableDet
    Implements Il_TablaContableDet

    Dim odTablaContableDet As New d_TablaContableDet
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As Boolean Implements Il_TablaContableDet.Eliminar
        Try
            Return odTablaContableDet.Eliminar(oeTablaContableDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As Boolean Implements Il_TablaContableDet.Guardar
        Try
            If Validar(oeTablaContableDet) Then
                Return odTablaContableDet.Guardar(oeTablaContableDet)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As System.Collections.Generic.List(Of EntidadesWCF.e_TablaContableDet) Implements Il_TablaContableDet.Listar
        Try
            Return odTablaContableDet.Listar(oeTablaContableDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarBind(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As System.ComponentModel.BindingList(Of EntidadesWCF.e_TablaContableDet) Implements Il_TablaContableDet.ListarBind
        Try
            Return odTablaContableDet.ListarBind(oeTablaContableDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As EntidadesWCF.e_TablaContableDet Implements Il_TablaContableDet.Obtener
        Try
            Return odTablaContableDet.Obtener(oeTablaContableDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTablaContableDet As EntidadesWCF.e_TablaContableDet) As Boolean Implements Il_TablaContableDet.Validar
        Try
            With oeTablaContableDet
                l_FuncionesGenerales.ValidarCampoNoNulo(oeTablaContableDet.Nombre, "Ingrese el Nombre del Item")

                ValidarDuplicado(.Id, .Nombre, "nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TablaContableDet.ValidarDuplicado
        Dim oeTablaContableDet As New e_TablaContableDet
        Try
            If String.IsNullOrEmpty(valor) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            If String.IsNullOrEmpty(campo) Then Throw New Exception("No se ha especificado el campo que se va a validar")
            Select Case campo
                'Case "codigo"
                '    oePerido.Codigo = valor
                Case "nombre"
                    oeTablaContableDet.Nombre = valor
            End Select
            Dim leTablaCtbleDet As New List(Of e_TablaContableDet)
            leTablaCtbleDet.AddRange(Listar(oeTablaContableDet))
            If id = "" Then 'inserta
                If leTablaCtbleDet.Count > 0 Then ' existe con el mismo nombre, no puede insertar,  error
                    Throw New Exception("Esta Detalle ya existe: " & leTablaCtbleDet(0).Nombre)
                End If
            Else 'actualiza
                If leTablaCtbleDet.Count > 0 AndAlso leTablaCtbleDet(0).Id <> id Then ' existe con el mismo nombre y diferente id,  error
                    Throw New Exception("Esta Detalle ya existe: " & leTablaCtbleDet(0).Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_TablaContableDet.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_TablaContableDet.CrearDT
        Dim TabCtbleDet As New Data.DataTable
        With TabCtbleDet
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTableContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Nombre", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Texto1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Texto2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Texto3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Valor1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Valor2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Valor3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Logico1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Logico2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Logico3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return TabCtbleDet
    End Function

    Public Function GuardarMasivo(leTablaContableDet As List(Of e_TablaContableDet)) As Boolean Implements Il_TablaContableDet.GuardarMasivo
        Try
            Dim dtTCD As Data.DataTable = CrearDT()
            Dim id As String = odTablaContableDet.UltimoIdInserta
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeTabCtbleDet In leTablaContableDet
                Dim rwTCD As Data.DataRow
                rwTCD = dtTCD.NewRow
                With oeTabCtbleDet
                    rwTCD("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwTCD("Nombre") = .Nombre
                    rwTCD("Texto1") = .Texto1
                    rwTCD("Texto2") = .Texto2
                    rwTCD("Texto3") = .Texto3
                    rwTCD("Valor1") = .Valor1
                    rwTCD("Valor2") = .Valor2
                    rwTCD("Valor3") = .Valor3
                    rwTCD("Logico1") = .Logico1
                    rwTCD("Logico2") = .Logico2
                    rwTCD("Logico3") = .Logico3
                    rwTCD("Activo") = True
                End With
                dtTCD.Rows.Add(rwTCD)
                lsNumero = lsNumero + 1
            Next
            Return odTablaContableDet.GuardarMasivo(dtTCD)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
