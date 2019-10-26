Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CtaCte_ProAdq
    Implements Il_CtaCte_ProAdq

    Private odCtaCte_ProAdq As d_CtaCte_ProAdq

    Public Function ComboGrilla(Lista As List(Of e_CtaCte_ProAdq)) As Object 'Implements Il_Combo.ComboGrilla
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Cuenta")
            For Each item As e_CtaCte_ProAdq In Lista
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Cuenta") = item.Cuenta
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As e_CtaCte_ProAdq Implements Il_CtaCte_ProAdq.Obtener
        Try
            odCtaCte_ProAdq = New d_CtaCte_ProAdq
            Return odCtaCte_ProAdq.Obtener(oeCtaCte_ProAdq)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As List(Of e_CtaCte_ProAdq) Implements Il_CtaCte_ProAdq.Listar
        Try
            odCtaCte_ProAdq = New d_CtaCte_ProAdq
            Return odCtaCte_ProAdq.Listar(oeCtaCte_ProAdq)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean Implements Il_CtaCte_ProAdq.Guardar
        Try
            odCtaCte_ProAdq = New d_CtaCte_ProAdq
            Dim bol_guardado As Boolean = False
            If Validar(oeCtaCte_ProAdq) Then
                bol_guardado = odCtaCte_ProAdq.Guardar(oeCtaCte_ProAdq)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean Implements Il_CtaCte_ProAdq.Eliminar
        Try
            odCtaCte_ProAdq = New d_CtaCte_ProAdq
            Return odCtaCte_ProAdq.Eliminar(oeCtaCte_ProAdq)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeCtaCte_ProAdq As e_CtaCte_ProAdq) As Boolean
        Try
            If oeCtaCte_ProAdq.TipoOperacion = "I" Then
                odCtaCte_ProAdq = New d_CtaCte_ProAdq
                With oeCtaCte_ProAdq
                    Dim oe As New e_CtaCte_ProAdq
                    oe.IdClienteProveedor = .IdClienteProveedor
                    oe = odCtaCte_ProAdq.Obtener(oe)
                    If oe.Id <> "" Then
                        Throw New Exception("Ya existe cuenta para la Empresa: " & .Empresa)
                    End If
                End With
            End If         
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
