Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBandeja.Click
        btnBandeja.ForeColor = Color.Teal
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black

        Bandeja_de_Entrada.Show()

    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnHoy.Click
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Teal
        btnProximos.ForeColor = Color.Black
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black

        Hoy.Show()

    End Sub

    Private Sub btnProximos_Click(sender As Object, e As EventArgs) Handles btnProximos.Click
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Teal
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black

        Proximos_Dias.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnLunes.Click
        btnLunes.ForeColor = Color.Teal
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black

        Lunes.Show()

    End Sub

    Private Sub btnMartes_Click(sender As Object, e As EventArgs) Handles btnMartes.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Teal
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

    Private Sub btnMiercoles_Click(sender As Object, e As EventArgs) Handles btnMiercoles.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Teal
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

    Private Sub btnJueves_Click(sender As Object, e As EventArgs) Handles btnJueves.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Teal
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

    Private Sub btnViernes_Click(sender As Object, e As EventArgs) Handles btnViernes.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Teal
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

    Private Sub btnSabado_Click(sender As Object, e As EventArgs) Handles btnSabado.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Teal
        btnDomingo.ForeColor = Color.Black
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

    Private Sub btnDomingo_Click(sender As Object, e As EventArgs) Handles btnDomingo.Click
        btnLunes.ForeColor = Color.Black
        btnMartes.ForeColor = Color.Black
        btnMiercoles.ForeColor = Color.Black
        btnJueves.ForeColor = Color.Black
        btnViernes.ForeColor = Color.Black
        btnSabado.ForeColor = Color.Black
        btnDomingo.ForeColor = Color.Teal
        btnBandeja.ForeColor = Color.Black
        btnHoy.ForeColor = Color.Black
        btnProximos.ForeColor = Color.Black
    End Sub

End Class
