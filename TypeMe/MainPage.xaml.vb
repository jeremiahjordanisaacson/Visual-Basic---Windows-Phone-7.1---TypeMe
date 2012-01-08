Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
        strWords(0) = "A"
        strWords(1) = "AND"
        strWords(2) = "AWAY"
        strWords(3) = "BIG"
        strWords(4) = "BLUE"
        strWords(5) = "CAN"
        strWords(6) = "COME"
        strWords(7) = "DOWN"
        strWords(8) = "FIND"
        strWords(9) = "FOR"
        strWords(10) = "FUNNY"
        strWords(11) = "GO"
        strWords(12) = "HELP"
        strWords(13) = "HERE"
        strWords(14) = "I"
        strWords(15) = "IN"
        strWords(16) = "IS"
        strWords(17) = "IT"
        strWords(18) = "JUMP"
        strWords(19) = "LITTLE"
        strWords(20) = "LOOK"
        strWords(21) = "MAKE"
        strWords(22) = "ME"
        strWords(23) = "MY"
        strWords(24) = "NOT"
        strWords(25) = "ONE"
        strWords(26) = "PLAY"
        strWords(27) = "RED"
        strWords(28) = "SAID"
        strWords(29) = "SEE"
        strWords(30) = "THE"
        strWords(31) = "THREE"
        strWords(32) = "TO"
        strWords(33) = "TWO"
        strWords(34) = "UP"
        strWords(35) = "WE"
        strWords(36) = "WHERE"
        strWords(37) = "YELLOW"
        strWords(38) = "YOU"
    End Sub



    Dim intScore As Integer = 0
    Dim intCounter As Integer = 0
    Dim intCongratsMessage As Integer = 0
    Dim strWords(0 To 38) As String



    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Try

            If intCounter = 38 Then
                intCounter = 0
                TextBlock1.Text = CStr(strWords(intCounter))
            Else
                If TextBlock1.Text = txtTypebox.Text Then
                    Try
                        If intCongratsMessage = 0 Then
                            MessageBox.Show("Great Work!")
                            intCongratsMessage = intCongratsMessage + 1
                        ElseIf intCongratsMessage = 1 Then
                            MessageBox.Show("Warming Up!")
                            intCongratsMessage = intCongratsMessage + 1
                        ElseIf intCongratsMessage = 9 Then
                            MessageBox.Show("Ten In A Row! Fantastic!")
                            intCongratsMessage = intCongratsMessage + 1
                        ElseIf intCongratsMessage = 19 Then
                            MessageBox.Show("Twenty In Row! Amazing!")
                            intCongratsMessage = intCongratsMessage + 1
                        ElseIf intCongratsMessage = 29 Then
                            MessageBox.Show("Thirty In Row! You're Amazing!")
                            intCongratsMessage = intCongratsMessage + 1
                        ElseIf intCongratsMessage = 100 Then
                            MessageBox.Show("You're Really Dedicated! You Are A Super Speller!")
                            intCongratsMessage = intCongratsMessage + 1
                        Else
                            MessageBox.Show("You're On Fire!")
                            intCongratsMessage = intCongratsMessage + 1
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Uh oh! An error occured while trying to print a success message. Please try again.")
                    End Try


                    ' Add one to the counter value to change the word.
                    intCounter = intCounter + 1

                    ' Add one to the score value because the user got the word correct.
                    intScore = intScore + 1

                    ' Print the next word to spell in the array to the screen
                    TextBlock1.Text = CStr(strWords(intCounter))

                    ' Print the current words typed score to the screen
                    TextBlock3.Text = intScore

                    ' Clear where the user types so they can type the next word
                    txtTypebox.Text = ""
                Else
                    MessageBox.Show("Try Again! Let's See What You Can Do!")
                    intCongratsMessage = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Uh oh! An error occured while trying to check the word. Please try again.")
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button2.Click
        Try
            If intCounter = 38 Then
                intCounter = 0
                TextBlock1.Text = CStr(strWords(intCounter))
            Else
                intCounter = intCounter + 1
                TextBlock1.Text = CStr(strWords(intCounter))
            End If

            ' Clear where the user types so they can type the next word
            txtTypebox.Text = ""
        Catch ex As Exception
            MessageBox.Show("Uh oh! An error occured while trying to change the word. Please try again.")
        End Try
    End Sub

    Private Sub btnInstructions_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnInstructions.Click
        Try
            NavigationService.Navigate(New Uri("/instructions.xaml", UriKind.Relative))
        Catch ex As Exception
            MessageBox.Show("Uh oh! An error occured while trying to navigate to the Instructions page. Please try again.")
        End Try
    End Sub
End Class
