Partial Public Class instructions
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub btnInstructions_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnInstructions.Click
        Try
            NavigationService.Navigate(New Uri("/MainPage.xaml", UriKind.Relative))
        Catch ex As Exception
            MessageBox.Show("Uh oh! An error occured while trying to navigate to the Main page. Please try again.")
        End Try
    End Sub
End Class
