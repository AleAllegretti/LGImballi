Public Class Imballi
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Alt_b, Lung_N, Larg_N, Alt_I, Lung_I, Larg_I, Vol_N, Vol_Imb, Somma_circ, i, ang, Alt_N, r As Decimal
        Dim Num_giri, Larg_cassa, Larg_cassa1, Alt_cassa, Costo, Lato_1, Lato_2, Lato_3, Larg_b, nstrati, n As Decimal
        Dim Materiale As String

        'Variable assignment
        Materiale = "Ferro"
        Alt_b = Me.Alt_B.Text
        Lung_N = Me.Lung.Text
        Larg_N = Me.Larg.Text
        Vol_N = Lung_N * Alt_b
        Vol_Imb = -0.0276 * Vol_N ^ 2 + 1.8935 * Vol_N - 0.247

        'Wooden pallet
        Somma_circ = 0
        i = 0
        ang = 0
        If Vol_N < 3.1 And Lung_N < 25 Then
            Materiale = "Legno"
            Alt_N = Alt_b + 0.002
            r = Alt_N + 0.02
            Num_giri = 0
            Do Until Somma_circ > Lung_N
                If i = 40 Then
                    r = r + Alt_N + 0.002
                    i = 0
                End If
                ang = ang + 9
                Somma_circ = (2 * 3.14 * r) / 40 + Somma_circ
                Num_giri = Num_giri + 0.025
                i = i + 1
            Loop
            Larg_cassa = r * 2 + 0.2

            If Larg_cassa < 0.8 Then
                Larg_cassa = 0.8
                Larg_cassa1 = 1.2
                Alt_cassa = Larg_N + 0.15
                Costo = 20
            End If

            If Larg_cassa < 1.2 And Larg_cassa > 0.8 Then
                Larg_cassa = 1.2
                Alt_cassa = Larg_N + 0.15
                Costo = 20
            End If

            If Larg_cassa < 1.4 And Larg_cassa > 1.2 Then
                Larg_cassa = 1.4
                Alt_cassa = Larg_N + 0.15
                Costo = 50
            End If

            If Larg_cassa < 1.8 And Larg_cassa > 1.4 Then
                Larg_cassa = 1.8
                Alt_cassa = Larg_N + 0.15
                Costo = 100
            End If

            If Larg_cassa < 2.2 And Larg_cassa > 1.8 Then
                Larg_cassa = 2.2
                Alt_cassa = Larg_N + 0.15
                Costo = 120
            End If
        End If

        '40 piedi dry box
        Lato_2 = Larg_N + 0.15                      'Larghezza
        Lato_1 = 2.24                               'Altezza porta
        Lato_3 = Math.Round(Vol_Imb / (Lato_1), 1)  'Lunghezza

        'High cube
        If Lato_3 > 11.8 Then
            Lato_1 = 2.6
            Lato_3 = Math.Round(Vol_Imb / (Lato_1), 1)
        End If

        'High cube con 1 giro laterale
        If Lato_3 > 11.8 Then
            Lato_2 = Lato_2 + Alt_b + 0.15
            Lato_1 = 2.6
            Lato_3 = 11.8
        End If

        '40 piedi high cube
        If Lato_3 > 11.8 Then
            Lato_2 = Larg_N + Larg_b * 2 + 0.15
            Lato_1 = 2.6
            nstrati = Lato_1 / (Alt_b + 0.04)
            n = (Math.Round(nstrati - 0.4, 0) * 2) - 2
        End If

        If Lato_3 > 11.8 Then
            MessageBox.Show("Imballo speciale", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'Output
        Me.Alt_I.Text = Lato_1
        Me.Larg_I.Text = Lato_2
        Me.Lungh_I.Text = Lato_3
        Me.Mat.Text = Materiale
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles MinButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaxButton_Click(sender As Object, e As EventArgs) Handles MaxButton.Click
        Me.WindowState = FormWindowState.Maximized
        Me.NormalButton.Visible = True
        Me.MaxButton.Visible = False
    End Sub

    Private Sub NormalButton_Click(sender As Object, e As EventArgs) Handles NormalButton.Click
        Me.WindowState = FormWindowState.Normal
        Me.MaxButton.Visible = True
    End Sub
End Class
