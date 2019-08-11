Imports System.Text
Imports System.CodeDom.Compiler
Imports System.Collections.Specialized

Public Class c_Ensamblado
    Implements IDisposable

    Private oEnsamblado As System.Reflection.Assembly
    Private CodigoFuente As New StringBuilder()
    Private oCProvider As New VBCodeProvider()
    Private oCParam As New CompilerParameters()
    Private oCResult As CompilerResults

    Public Function PrecompilarEnsamblado(ByVal ls_Funcion As String) As Boolean
        Try
            'Definimos un objeto de tipo StringBuilder que contendra el código a compilar

            'Agregamos los Imports necesarios a nuestro codigo fuente 
            CodigoFuente.Clear()
            CodigoFuente.Append("Imports Microsoft.VisualBasic" & vbCr)

            'Terminamos de construir la clase a compilar
            CodigoFuente.Append("Public Class EvalClase" & vbCr)
            CodigoFuente.Append(ls_Funcion & vbCr)
            CodigoFuente.Append("End Class " & vbCr)

            'Creamos una instancia de la clase VBCodeProvider que usaremos para obtener una referencia a una interfaz ICodeCompiler
            oCProvider = New VBCodeProvider()
            ' Dim oCompiler As ICodeCompiler = oCProvider.CreateCompiler

            'Usamos la clase CompilerParameters para pasar parámetros al compilador En particular, definimos que el assembly sea compilado en memoria.
            oCParam = New CompilerParameters()
            'oCParam.GenerateInMemory = True

            'Creamos un objeto CompilerResult que obtendrá los resultados de la compilación
            oCResult = oCProvider.CompileAssemblyFromSource(oCParam, CodigoFuente.ToString)
            'Comprobamos que no existan errores de compilación.
            Dim oCError As CompilerError
            If oCResult.Errors.Count > 0 Then
                'Si existen errores los mostramos. Si bien, podriamos implementar un mejor método para visualizar los errores de compilación, este nos servirá por los momentos.
                Dim strMensaje As String = ""
                For Each oCError In oCResult.Errors
                    strMensaje = strMensaje & "(*) " & oCError.ErrorText.ToString & Environment.NewLine
                    'MsgBox(oCError.ErrorText.ToString)
                Next
                Throw New Exception(strMensaje)
                ' Return False
            Else
                'Como el ensamblado se generó en memoria, debemos obtener una referencia al ensamblado generado, para esto usamos la propiedad CompiledAssembly
                oEnsamblado = oCResult.CompiledAssembly
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Evaluar(ByVal ls_NombreFuncion As String) As Object
        Try
            If oEnsamblado Is Nothing Then
                Return Nothing
            Else
                'Instanciamos la clase EvalClase de nuestro assembly creando un tipo a partir de ella.
                'Dim oClass As Type = oEnsamblado.GetType("EvalClase")
                'Usamos GetMethod para accesar al método Eval, e invocamos este con los parametros necesarios.
                'Return oClass.GetMethod(ls_NombreFuncion).Invoke(Nothing, Nothing)
                Return oEnsamblado.GetType("EvalClase").GetMethod(ls_NombreFuncion).Invoke(Nothing, Nothing)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtieneResultado(ByVal ls_NombreFuncion As String, ByVal ls_Codigo As String) As Object
        Try
            'Definimos un objeto de tipo StringBuilder que contendra el código a compilar

            'Agregamos los Imports necesarios a nuestro codigo fuente 
            CodigoFuente.Clear()
            CodigoFuente.Append("Imports Microsoft.VisualBasic" & vbCr)

            'Terminamos de construir la clase a compilar
            CodigoFuente.Append("Public Class EvalClase" & vbCr)
            CodigoFuente.Append(ls_Codigo & vbCr)
            CodigoFuente.Append("End Class " & vbCr)

            'Creamos una instancia de la clase VBCodeProvider que usaremos para obtener una referencia a una interfaz ICodeCompiler
            oCProvider = New VBCodeProvider()
            ' Dim oCompiler As ICodeCompiler = oCProvider.CreateCompiler
            oCParam = New CompilerParameters()
            'Creamos un objeto CompilerResult que obtendrá los resultados de la compilación
            'Dim oCResult As CompilerResults
            'oCResult = oCProvider.CompileAssemblyFromSource(oCParam, CodigoFuente.ToString)
            'Comprobamos que no existan errores de compilación.
            'Dim oCError As CompilerError
            'If oCResult.Errors.Count > 0 Then
            '    'Si existen errores los mostramos. Si bien, podriamos implementar un mejor método para visualizar los errores de compilación, este nos servirá por los momentos.
            '    Dim strMensaje As String = ""
            '    For Each oCError In oCResult.Errors
            '        strMensaje = strMensaje & "(*) " & oCError.ErrorText.ToString & Environment.NewLine
            '    Next
            '    Throw New Exception(strMensaje)
            'End If
            ' Return oCResult.CompiledAssembly.GetType("EvalClase").GetMethod(ls_NombreFuncion).Invoke(Nothing, Nothing)
            Return oCProvider.CompileAssemblyFromSource(oCParam, CodigoFuente.ToString).CompiledAssembly.GetType("EvalClase").GetMethod(ls_NombreFuncion).Invoke(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "IDisposable Support"

    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: eliminar estado administrado (objetos administrados).
                oCParam.TempFiles.Delete()
                oCProvider.Dispose()
                ' oCResult.TempFiles.Delete()
            End If

            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: invalidar Finalize() sólo si la instrucción Dispose(ByVal disposing As Boolean) anterior tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Ponga el código de limpieza en la instrucción Dispose(ByVal disposing As Boolean) anterior.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.

    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
