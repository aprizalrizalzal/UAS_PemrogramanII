Public Class FormIdealWeight

    Dim KurangKurang As String = "Kurang dari 17,0 = Kurus, kekurangan berat badan berat"
    Dim Kurang As String = "17,0 - 18,4 = Kurus, kekurangan berat badan ringan"
    Dim Normal As String = "18,5 – 25,0 = Normal"
    Dim Gemuk As String = "25,1 – 27,0 = Gemuk, kelebihan berat badan tingkat ringan"
    Dim GemukGemuk As String = "Lebih dari 27 = Gemuk, kelebihan berat badan tingkat berat"
    Private Sub ViewResult()
        LblResultName.Text = "Nama: " + TbName.Text
        LblResultAge.Text = "Umur : " + TbAge.Text
        LblResultHeight.Text = "Tinggi : " + TbHeight.Text
        If (RadioBtnMale.Checked) Then
            LblResultGender.Text = "Jenis kelamin : " + RadioBtnMale.Text
        Else
            LblResultGender.Text = "Jenis kelamin : " + RadioBtnFemale.Text
        End If
        LblResultWeightNow.Text = "Berat Badan : " + TbWeightNow.Text
    End Sub
    Private Sub BtnResult_Click(sender As Object, e As EventArgs) Handles BtnResult.Click
        Dim heightGender = TbHeight.Text
        Dim weightNow = TbWeightNow.Text

        Dim resultMale As Double
        Dim resultFemale As Double
        Dim resultBMI As Double

        If TbName.Text = Nothing Then
            MsgBox("Maaf, nama tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong")
        ElseIf TbAge.Text = Nothing Then
            MsgBox("Maaf, Umur tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong")
        ElseIf TbHeight.Text = Nothing Then
            MsgBox("Maaf, Tinggi tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong")


        ElseIf TbWeightNow.Text = Nothing Then
            MsgBox("Maaf, Berat Badan tidak boleh kosong!", MsgBoxStyle.Exclamation, "Kosong")
        Else
            Dim resultheightGender As Double = heightGender - 100
            resultMale = (heightGender - 100) - ((resultheightGender / 100) * 10)
            resultFemale = (heightGender - 100) - ((resultheightGender / 100) * 15)

            If (RadioBtnMale.Checked = True) Then
                LblResult.Text = "Berat badan ideal Laki-Laki (kg): badan " + heightGender.ToString + " cm - 100 - (( " + heightGender.ToString + " cm - 100) x 10 %) = " + resultMale.ToString + " kg"
            ElseIf (RadioBtnFemale.Checked = True) Then
                LblResult.Text = "Berat badan ideal Perempuan (kg): badan " + heightGender.ToString + " cm - 100 - (( " + heightGender.ToString + " cm - 100) x 15 %) = " + resultFemale.ToString + " kg"
            Else
                MsgBox("Maaf, Jenis kelamin harus ada!", MsgBoxStyle.Exclamation, "Tidak Ada")
            End If

            Dim resultHeight As Double = heightGender / 100
            resultBMI = (weightNow / (resultHeight * resultHeight))

            If (resultBMI <= 17.0) Then
                ViewResult()
                LblBMI.Text = "Indeks massa tubuh : " + weightNow + "/ (" + resultHeight.ToString + "*" + resultHeight.ToString + ") = " + resultBMI.ToString
                LblBMIInformation.Text = "BMI Informasi : " + KurangKurang
            ElseIf (resultBMI <= 18.4) Then
                ViewResult()
                LblBMI.Text = "Indeks massa tubuh : " + weightNow + "/ (" + resultHeight.ToString + "*" + resultHeight.ToString + ") = " + resultBMI.ToString
                LblBMIInformation.Text = "BMI Informasi : " + Kurang
            ElseIf (resultBMI <= 25.0) Then
                ViewResult()
                LblBMI.Text = "Indeks massa tubuh : " + weightNow + "/ (" + resultHeight.ToString + "*" + resultHeight.ToString + ") = " + resultBMI.ToString
                LblBMIInformation.Text = "BMI Informasi : " + Normal
            ElseIf (resultBMI <= 26.9) Then
                ViewResult()
                LblBMI.Text = "Indeks massa tubuh : " + weightNow + "/ (" + resultHeight.ToString + "*" + resultHeight.ToString + ") = " + resultBMI.ToString
                LblBMIInformation.Text = "BMI Informasi : " + Gemuk
            ElseIf (resultBMI >= 27.0) Then
                ViewResult()
                LblBMI.Text = "Indeks massa tubuh : " + weightNow + "/ (" + resultHeight.ToString + "*" + resultHeight.ToString + ") = " + resultBMI.ToString
                LblBMIInformation.Text = "BMI Informasi : " + GemukGemuk
            End If
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If CbRating.Text = "Berikan nilai 1 sampai 10" Then
            MsgBox("Maaf sebelum keluar, berikan nilai aplikasi", MsgBoxStyle.Information, "Nilai")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub RefreshView()
        RadioBtnMale.Checked = False
        RadioBtnFemale.Checked = False
        LblResultName.Text = Nothing
        LblResultAge.Text = Nothing
        LblResultHeight.Text = Nothing
        LblResultGender.Text = Nothing
        LblResultWeightNow.Text = Nothing
        LblResult.Text = Nothing
        LblBMI.Text = Nothing
        LblBMIInformation.Text = Nothing
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TbName.Text = Nothing
        TbAge.Text = Nothing
        TbHeight.Text = Nothing
        TbWeightNow.Text = Nothing
        RefreshView()
    End Sub

    Private Sub FormIdealWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshView()
        CbRating.Text = "Berikan nilai 1 sampai 10"
        Dim rating As Integer
        rating = 0
        While rating < 10
            rating += 1
            CbRating.Items.Add(rating)
        End While
    End Sub

    Private Sub CbRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRating.SelectedIndexChanged
        MsgBox("Terima kasih atas nilai " + CbRating.Text + " yang diberikan", MsgBoxStyle.Information, "Terima kasih")
    End Sub
End Class