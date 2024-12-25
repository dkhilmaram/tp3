Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"petit", "Moyenne", "Grande"})
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taille As String = ComboBox1.SelectedItem.ToString()
        Dim croute As String = ""
        If RadioButton1.Checked Then
            croute = "Croûte fine"
        ElseIf RadioButton2.Checked Then
            croute = "Croûte classique"
        ElseIf RadioButton3.Checked Then
            croute = "Croûte épaisse"
        End If

        ' Get selected ingredients
        Dim ingredients As String = "Ingrédients supplémentaires : "
        If CheckBox1.Checked Then
            ingredients &= "Champignons, "
        End If
        If CheckBox2.Checked Then
            ingredients &= "Olives, "
        End If
        If CheckBox3.Checked Then
            ingredients &= "Poivrons, "
        End If
        If CheckBox4.Checked Then
            ingredients &= "Fromage supplémentaire, "
        End If


        If ingredients.EndsWith(", ") Then
            ingredients = ingredients.Substring(0, ingredients.Length - 2)
        Else
            ingredients = "Aucun ingrédient supplémentaire sélectionné."
        End If

        ' Display the summary in a MessageBox
        Dim recapitulatif As String = $"Taille de la pizza : {taille}" & vbCrLf &
                                      $"Type de croûte : {croute}" & vbCrLf &
                                      $"{ingredients}"
        MessageBox.Show(recapitulatif, "Récapitulatif de la commande")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
