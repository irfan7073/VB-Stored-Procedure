Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Clear.Click
        IDText.Clear()
        NameText.Clear()
        PhoneText.Clear()
        AddressText.Clear()
        EmailText.Clear()
        IDText.Focus()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        con = New SqlConnection("server=DESKTOP-EES6UNB\SMSQLSERVER;database=CustomerData;integrated security=True")
        cmd = New SqlCommand

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "InsertCustomerInfo"

        cmd.Parameters.AddWithValue("@name", NameText.Text)
        cmd.Parameters.AddWithValue("@phone", PhoneText.Text)
        cmd.Parameters.AddWithValue("@address", AddressText.Text)
        cmd.Parameters.AddWithValue("@email", EmailText.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        lblmessage.Text = "Record Inserted Successfully"

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click

        con = New SqlConnection("server=DESKTOP-EES6UNB\SMSQLSERVER;database=CustomerData;integrated security=True")
        cmd = New SqlCommand

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UpdateCustomerInfo"

        cmd.Parameters.AddWithValue("@id", IDText.Text)
        cmd.Parameters.AddWithValue("@name", NameText.Text)
        cmd.Parameters.AddWithValue("@phone", PhoneText.Text)
        cmd.Parameters.AddWithValue("@address", AddressText.Text)
        cmd.Parameters.AddWithValue("@email", EmailText.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        lblmessage.Text = "Record Updated Successfully"

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        con = New SqlConnection("server=DESKTOP-EES6UNB\SMSQLSERVER;database=CustomerData;integrated security=True")
        cmd = New SqlCommand

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "DeleteCustomerInfo"

        cmd.Parameters.AddWithValue("@id", IDText.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        lblmessage.Text = "Record Deleted Successfully"

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        con = New SqlConnection("server=DESKTOP-EES6UNB\SMSQLSERVER;database=CustomerData;integrated security=True")
        cmd = New SqlCommand

        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SearchCustomer"

        cmd.Parameters.AddWithValue("@id", IDText.Text)
        cmd.Parameters.AddWithValue("@name", NameText.Text)
        cmd.Parameters.AddWithValue("@phone", PhoneText.Text)
        cmd.Parameters.AddWithValue("@address", AddressText.Text)
        cmd.Parameters.AddWithValue("@email", EmailText.Text)

        Dim adapter As New SqlDataAdapter
        Dim dt As New DataTable
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(dt)

        For Each dr As DataRow In dt.Rows
            NameText.Text = dr.Item(0)
            PhoneText.Text = dr.Item(1)
            AddressText.Text = dr.Item(2)
            EmailText.Text = dr.Item(3)

            lblmessage.Text = "Record found"
        Next

    End Sub
End Class
