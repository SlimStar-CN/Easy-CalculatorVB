Public Class MainActivity
    Dim currentInput As String = ""
    Dim op As String = ""       ' 
    Dim firstNumber As Double = 0
    Dim secondNumber As Double = 0
    Dim isNewCalculation As Boolean = True
    Dim expression As String = ""
    Dim isResultShown As Boolean = False
    Private Sub AddOperator(op As String)
        If expression = "" Then Return
        If isResultShown Then isResultShown = False
        Dim lastChar = expression(expression.Length - 1)
        If lastChar = "+" Or lastChar = "-" Or lastChar = "*" Or lastChar = "/" Then
            Return
        End If

        expression &= op
        TextBox.Text = expression
    End Sub

    Private Sub MainActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "7"
        TextBox.Text = expression
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "8"
        TextBox.Text = expression
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "9"
        TextBox.Text = expression
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "4"
        TextBox.Text = expression
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "5"
        TextBox.Text = expression
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "6"
        TextBox.Text = expression
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "1"
        TextBox.Text = expression
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "2"
        TextBox.Text = expression
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "3"
        TextBox.Text = expression
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        expression &= "0"
        TextBox.Text = expression
    End Sub

    Private Sub Buttonpoint_Click(sender As Object, e As EventArgs) Handles Buttonpoint.Click
        If isResultShown Then
            expression = ""
            isResultShown = False
        End If
        Dim lastPart = expression.Split({" ", "+", "-", "*", "/"}, StringSplitOptions.None).Last()
        If Not lastPart.Contains(".") Then
            expression &= "."
            TextBox.Text = expression
        End If
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        AddOperator("+")
    End Sub

    Private Sub Buttonmin_Click(sender As Object, e As EventArgs) Handles Buttonmin.Click
        AddOperator("-")
    End Sub

    Private Sub ButtonChen_Click(sender As Object, e As EventArgs) Handles ButtonChen.Click
        AddOperator("*")
    End Sub

    Private Sub ButtonProp_Click(sender As Object, e As EventArgs) Handles ButtonProp.Click
        AddOperator("/")
    End Sub

    Private Sub Buttonequal_Click(sender As Object, e As EventArgs) Handles Buttonequal.Click
        If isResultShown Then Return
        Try
            If expression.Trim = "" Then Return
            Dim result = New DataTable().Compute(expression, Nothing)
            TextBox.Text = result.ToString()
            expression = result.ToString()
            isResultShown = True
        Catch
            TextBox.Text = "错误"
            expression = ""
            isResultShown = True
        End Try
    End Sub

    Private Sub Buttonblack_Click(sender As Object, e As EventArgs) Handles Buttonblack.Click
        expression = ""
        TextBox.Text = ""
        isResultShown = False
    End Sub

    Private Sub Buttonback_Click(sender As Object, e As EventArgs) Handles Buttonback.Click
        If expression.Length > 0 Then
            expression = expression.Substring(0, expression.Length - 1)
            TextBox.Text = expression
        End If
    End Sub

    Private Sub DdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DdToolStripMenuItem.Click

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 清空ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 清空ToolStripMenuItem.Click
        expression = ""
        TextBox.Text = ""
        isResultShown = False
    End Sub

    Private Sub 导入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入ToolStripMenuItem.Click
        MessageBox.Show("出错了。" & vbCrLf & "原因可能如下：" & vbCrLf & "您的计算器未正确安装" & vbCrLf & "缺少来自 Calc_DonGhost 的证书", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub 帮助ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 帮助ToolStripMenuItem.Click
        Aboutme.ShowDialog()
    End Sub
End Class
