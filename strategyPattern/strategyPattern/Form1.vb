Public Class Form1

    Dim context As Context
    Private Sub subt_Click(sender As Object, e As EventArgs) Handles subt.Click
        context = New Context(New OperationSubstract(NumericUpDown1.Value, NumericUpDown2.Value))
        Answer.Text = $"Sub operation: {context.Operation()}"
    End Sub

    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click
        context = New Context(New OperationAdd(NumericUpDown1.Value, NumericUpDown2.Value))
        Answer.Text = $"Add operation: {context.Operation()}"
    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        context = New Context(New OperationMultiply(NumericUpDown1.Value, NumericUpDown2.Value))
        Answer.Text = $"Mult operation: {context.Operation()}"
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        context = New Context(New OperationDivision(NumericUpDown1.Value, NumericUpDown2.Value))
        Answer.Text = $"Div operation: {context.Operation()}"
    End Sub
End Class
