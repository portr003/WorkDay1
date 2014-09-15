Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim st As String
        st = txtFullName.Text

        Dim st2 As String
        st2 = st.Trim()

        Dim fstSpace As Integer
        fstSpace = st2.IndexOf(" ")

        Dim fstName As String
        fstName = st2.Substring(0, fstSpace)


        txtFirstName.Text = fstName





    End Sub
End Class
