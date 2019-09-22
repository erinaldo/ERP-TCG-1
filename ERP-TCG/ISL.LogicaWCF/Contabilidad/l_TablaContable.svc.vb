Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TablaContable
    Implements Il_TablaContable

    Dim odTablaContable As New d_TablaContable
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTablaContable As EntidadesWCF.e_TablaContable) As Boolean Implements Il_TablaContable.Eliminar
        Try
            Return odTablaContable.Eliminar(oeTablaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaContable As EntidadesWCF.e_TablaContable) As Boolean Implements Il_TablaContable.Guardar
        Try
            If Validar(oeTablaContable) Then
                Return odTablaContable.Guardar(oeTablaContable)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTablaContable As EntidadesWCF.e_TablaContable) As System.Collections.Generic.List(Of EntidadesWCF.e_TablaContable) Implements Il_TablaContable.Listar
        Try
            Return odTablaContable.Listar(oeTablaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTablaContable As EntidadesWCF.e_TablaContable) As EntidadesWCF.e_TablaContable Implements Il_TablaContable.Obtener
        Try
            Return odTablaContable.Obtener(oeTablaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTablaContable As EntidadesWCF.e_TablaContable) As Boolean Implements Il_TablaContable.Validar
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(oeTablaContable.Nombre, "Ingrese el Nombre de la Tabla Contable")
            If oeTablaContable.Tipooperacion = "I" Then
                Dim oeTC As New e_TablaContable
                Dim leTC As New List(Of e_TablaContable)
                oeTC.Nombre = oeTablaContable.Nombre
                leTC.AddRange(Listar(oeTC))
                If leTC.Count < 0 Then
                    Throw New Exception("Este nombre ya existe")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_TablaContable.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_TablaContable.CrearDT
        Dim TabCtble As New Data.DataTable
        With TabCtble
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Nombre", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaTexto1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaTexto2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaTexto3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaValor1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaValor2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaValor3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaLogico1", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaLogico2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ColumnaLogico3", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return TabCtble
    End Function

    Public Function GuardarMasivo(leTablaContable As List(Of e_TablaContable), ByVal PrefijoID As String) As Boolean Implements Il_TablaContable.GuardarMasivo
        Try
            Dim dtTC As Data.DataTable = CrearDT()
            Dim id As String = odTablaContable.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeTabCtble In leTablaContable
                Dim rwTC As Data.DataRow
                rwTC = dtTC.NewRow
                With oeTabCtble
                    rwTC("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwTC("Nombre") = .Nombre
                    rwTC("ColumnaTexto1") = .Texto1
                    rwTC("ColumnaTexto2") = .Texto2
                    rwTC("ColumnaTexto3") = .Texto3
                    rwTC("ColumnaValor1") = .Valor1
                    rwTC("ColumnaValor2") = .Valor2
                    rwTC("ColumnaValor3") = .Valor3
                    rwTC("ColumnaLogico1") = .Logico1
                    rwTC("ColumnaLogico2") = .Logico2
                    rwTC("ColumnaLogico3") = .Logico3
                    rwTC("Activo") = True
                End With
                dtTC.Rows.Add(rwTC)
                lsNumero = lsNumero + 1
            Next
            Return odTablaContable.GuardarMasivo(dtTC)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
