Class MainWindow
    Private Sub textBoxInputCharacter_Copy_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBoxInputCharacter_Copy.TextChanged

    End Sub

    Private Sub buttonMakeStory_Click(sender As Object, e As RoutedEventArgs) Handles buttonMakeStory.Click

        String character = textBoxInputCharacter.Text;

        String mood = textBoxInputMood.Text;


        textBlockStoryOutput.Text = String.Format("Once upon a time there was a [0], who was in a [1] mood."
                                                  , character, mood);
    End Sub
End Class
