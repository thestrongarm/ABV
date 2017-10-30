Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Me.AdministratorTableAdapter.AdminLoginQuery(txtUsername.Text, txtPassword.Text) = 1 Then
            adminPortal.Show()
            Me.Hide()

        ElseIf Me.UsersTableAdapter.UserLoginQuery(txtUsername.Text, txtPassword.Text) = 1 Then
            userPortal.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Username and/or Password")
            txtUsername.Clear()
            txtPassword.Clear()

        End If




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AdministratorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdministratorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminDataSet1)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminDataSet1.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.AdminDataSet1.Users)
        'TODO: This line of code loads data into the 'AdminDataSet1.Administrator' table. You can move, or remove it, as needed.
        Me.AdministratorTableAdapter.Fill(Me.AdminDataSet1.Administrator)

    End Sub
End Class
