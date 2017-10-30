Public Class userPortal
    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        cbDropYear.Items.Clear()
        cbDropYear.Items.Add("2018")
        cbDropYear.Items.Add("2017")

        cbDropMake.Items.Clear()
        cbDropMake.Items.Add("Acura")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cbDropYear.Items.Clear()
        cbDropYear.Items.Add("2017")
        cbDropYear.Items.Add("2016")
        cbDropYear.Items.Add("2015")
        cbDropYear.Items.Add("2014")
        cbDropYear.Items.Add("2013")

        cbDropMake.Items.Clear()
        cbDropMake.Items.Add("Acura")
        cbDropMake.Items.Add("Honda")
        cbDropMake.Items.Add("Ford")
        cbDropMake.Items.Add("Chevrolet")
    End Sub

    'Event Handlers for Drop down lists'
    'Year'
    Private Sub cbDropYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDropYear.SelectedIndexChanged
        lblStatus.Text = cbDropYear.Text
    End Sub

    'Make'
    Private Sub cbDropMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDropMake.SelectedIndexChanged
        lblStatus.Text = cbDropYear.Text + "  >  " + cbDropMake.Text

        If cbDropMake.SelectedIndex = 0 Then
            cbDropModel.Items.Clear()
            cbDropModel.Items.Add("ILX")
            cbDropModel.Items.Add("MDX")
            cbDropModel.Items.Add("NSX")
            cbDropModel.Items.Add("RDX")
            cbDropModel.Items.Add("RLX")
            cbDropModel.Items.Add("TLX")

        ElseIf cbDropMake.SelectedIndex = 1 Then
            cbDropModel.Items.Clear()
            cbDropModel.Items.Add("Camaro")
            cbDropModel.Items.Add("Corvette")
            cbDropModel.Items.Add("Cruze")
            cbDropModel.Items.Add("Impala")
            cbDropModel.Items.Add("Malibu")
            cbDropModel.Items.Add("Silverado 1500")
            cbDropModel.Items.Add("Tahoe")

        ElseIf cbDropMake.SelectedIndex = 2 Then
            cbDropModel.Items.Clear()
            cbDropModel.Items.Add("Explorer")
            cbDropModel.Items.Add("Expedition")
            cbDropModel.Items.Add("Focus")
            cbDropModel.Items.Add("Fusion")
            cbDropModel.Items.Add("F-150")
            cbDropModel.Items.Add("Mustang")
            cbDropModel.Items.Add("Taurus")

        ElseIf cbDropMake.SelectedIndex = 3 Then
            cbDropModel.Items.Clear()
            cbDropModel.Items.Add("Accord")
            cbDropModel.Items.Add("Civic")
            cbDropModel.Items.Add("CR-V")
            cbDropModel.Items.Add("HR-V")
            cbDropModel.Items.Add("Odyssey")
            cbDropModel.Items.Add("Pilot")
            cbDropModel.Items.Add("Ridgeline")
        End If
    End Sub

    'Model'
    Private Sub cbDropModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDropModel.SelectedIndexChanged
        lblStatus.Text = cbDropYear.Text + "  >  " + cbDropMake.Text + "  >  " + cbDropModel.Text



    End Sub




    'Clear the drop down combo boxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbDropYear.SelectedIndex = -1
        cbDropYear.Text = "Select the Year"

        cbDropMake.SelectedIndex = -1
        cbDropMake.Text = "Select the Make"

        cbDropModel.SelectedIndex = -1
        cbDropModel.Text = "Select the Model"

        lblStatus.Text = String.Empty
    End Sub




End Class
