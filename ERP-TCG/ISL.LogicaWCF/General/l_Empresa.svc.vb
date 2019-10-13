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

''' <summary>
''' Clase: Empresa;
''' Fecha: 15/10/2011
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Empresa
    Implements Il_Empresa

    Const Mensaje As String = "No se ha Ingresado: "
    Dim odEmpresa As New d_Empresa
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal Empresa As System.Collections.Generic.List(Of EntidadesWCF.e_Empresa)) As Object Implements Il_Empresa.ComboGrilla
        Try
            Return odEmpresa.ComboGrilla(Empresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As Boolean Implements Il_Empresa.Eliminar
        Try
            Return odEmpresa.Eliminar(oeEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As Boolean Implements Il_Empresa.Guardar
        Try
            Dim id As String = ""
            Dim Retorna As Boolean = False
            If Validar(oeEmpresa) Then
                id = odEmpresa.Guardar(oeEmpresa)
            End If
            If id <> "" Then Retorna = True
            Return Retorna
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarCliente(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As String
        Try
            Dim id As String = ""
            Dim Retorna As Boolean = False
            If Validar(oeEmpresa) Then
                id = odEmpresa.Guardar(oeEmpresa)
            End If
            If id <> "" Then Retorna = True
            Return id
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As System.Collections.Generic.List(Of EntidadesWCF.e_Empresa) Implements Il_Empresa.Listar
        Try
            Return odEmpresa.Listar(oeEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As EntidadesWCF.e_Empresa Implements Il_Empresa.Obtener
        Try
            Return odEmpresa.Obtener(oeEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As Boolean Implements Il_Empresa.Validar
        Try
            With oeEmpresa
                If .TipoOperacion = "G" Or .TipoOperacion = "B" Then
                    Return True
                End If
                ValidarNombre(.Nombre)
                ValidarRuc(.Ruc)
                ValidarDuplicado(.Id, .Ruc, "Ruc")
                ValidarDuplicado(.Id, .Nombre, "Razon Social")
                ValidarTipoPago(.oeClienteProveedor, .leTipoPago)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Función para validar el Id de la empresa
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarId(ByVal Id As String) As Boolean Implements Il_Empresa.ValidarId
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Id, Mensaje & "Id")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar Nombre Empresa
    ''' </summary>
    ''' <param name="Nombre">Nombre Empresa</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarNombre(ByVal Nombre As String) As Boolean Implements Il_Empresa.ValidarNombre
        Try
            If String.IsNullOrEmpty(Nombre) Then Throw New Exception(Mensaje & "Ruc")

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para validar el número de RUC de la empresa
    ''' </summary>
    ''' <param name="Ruc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarRuc(ByVal Ruc As String) As Boolean Implements Il_Empresa.ValidarRuc
        Try
            'El RUC tiene que ser numérico
            If Not IsNumeric(Ruc) Then Throw New Exception("Por favor, verifique el número de RUC")
            'El RUC no puede ser vacío
            l_FuncionesGenerales.ValidarCampoNoNulo(Ruc, Mensaje & "Ruc")
            'El RUC debe tener 11 dígitos
            If Ruc.Trim.Length < 11 Then Throw New Exception("Por favor, verifique el número de RUC")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Empresa.ValidarDuplicado
        Dim oeEmpr As New e_Empresa
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(valor, "No se ha definido que información se va a verificar si existe")
            l_FuncionesGenerales.ValidarCampoNoNulo(campo, "No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "Ruc"
                    oeEmpr.Ruc = valor
                Case "Razon Social"
                    oeEmpr.Nombre = valor
            End Select
            oeEmpr = odEmpresa.Obtener(oeEmpr)
            If Not String.IsNullOrEmpty(oeEmpr.Id) And oeEmpr.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoPago(ByVal oeClieProv As EntidadesWCF.e_ClienteProveedor, ByVal leTipPag As System.Collections.Generic.List(Of EntidadesWCF.e_PersonaEmpresa_TipoPago)) As Boolean Implements Il_Empresa.ValidarTipoPago
        Try
            Dim letp As New List(Of e_PersonaEmpresa_TipoPago)
            If oeClieProv.Cliente = 1 Then
                letp = leTipPag.Where(Function(item) item.IndClienteProveedor = "1").ToList
                If letp.Count = 0 Then Throw New Exception("Debe Ingresar al menos un Tipo Pago como Cliente")
            End If
            If oeClieProv.Proveedor = 1 Then
                letp = leTipPag.Where(Function(item) item.IndClienteProveedor = "2").ToList
                If letp.Count = 0 Then Throw New Exception("Debe Ingresar al menos un Tipo Pago como Proveedor")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizaFec(ByVal oeEmpresa As EntidadesWCF.e_Empresa) As Boolean Implements Il_Empresa.ActualizaFec
        Try
            Return odEmpresa.ActualizaFec(oeEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
