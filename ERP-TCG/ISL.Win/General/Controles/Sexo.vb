Imports ERP.EntidadesWCF
Public Class Sexo

    ''' <summary>
    ''' Evento que permite establecer si se ha modificado el valor de sexo
    ''' </summary>
    ''' <remarks></remarks>
    Public Event DatoCambiado()
    Private oeSexo As New e_Sexo

    ''' <summary>
    ''' Constructor del control sexo
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oeSexo.AsignaValores(1)
    End Sub

    ''' <summary>
    ''' Cargar los valores del control a partir de un objeto de tipo sexo
    ''' </summary>
    ''' <param name="sexo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sexo As e_Sexo)
        InitializeComponent()

        If sexo.Id = 1 Or sexo.Nombre = "Masculino" Or sexo.Abreviatura = "M" Then
            opcMasculino.Checked = True
        Else
            opcFemenino.Checked = True
        End If

    End Sub

    Private Sub opcFemenino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcFemenino.CheckedChanged
        If Not opcFemenino.Checked Then
            oeSexo.AsignaValores(1)
        Else
            oeSexo.AsignaValores(2)
        End If
    End Sub

    Private Sub opcMasculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcMasculino.CheckedChanged
        If opcMasculino.Checked Then
            oeSexo.AsignaValores(1)
        Else
            oeSexo.AsignaValores(2)
        End If
    End Sub

    Public Property Sexo() As e_Sexo
        Get
            Return oeSexo
        End Get
        Set(ByVal value As e_Sexo)
            oeSexo = value
            If value.Id = 1 Then
                opcMasculino.Checked = True
            Else
                opcFemenino.Checked = True
            End If
            RaiseEvent DatoCambiado()
        End Set
    End Property

End Class
