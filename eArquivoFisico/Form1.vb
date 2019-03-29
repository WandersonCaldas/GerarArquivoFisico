Public Class Form1
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Application.Exit()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim erro As String = String.Empty

        If erro = String.Empty AndAlso txt_binario.Text = "" Then
            erro = "CAMPO BINÁRIO NÃO PODE SER VAZIO."
        End If
        If erro = String.Empty AndAlso txt_extensao.Text = "" Then
            erro = "CAMPO EXTENSÃO NÃO PODE SER VAZIO."
        End If
        If erro = String.Empty AndAlso txt_gravar.Text = "" Then
            erro = "CAMPO CAMINHO DE GRAVAÇÃO NÃO PODE SER VAZIO."
        End If

        If Not String.IsNullOrEmpty(erro) Then
            MsgBox(erro)
        Else
            If GravarArquivo(txt_binario.Text) Then
                MsgBox("ARQUIVO GRAVADO.")
                'Application.Exit()
            End If
        End If
    End Sub

    Private Function GravarArquivo(ByVal value As String) As Boolean
        Dim retorno As Boolean = False
        Dim arquivo As String = String.Empty

        Try
            Dim bytConteudo() As Byte = System.Text.Encoding.Unicode.GetBytes(value.Trim)

            arquivo = txt_gravar.Text.Trim & "\{" & UCase(System.Guid.NewGuid().ToString()) & "}_." & txt_extensao.Text.Trim
            System.IO.File.WriteAllBytes(arquivo.Replace("\", "/").Trim, bytConteudo)
            retorno = True
        Catch ex As Exception
            retorno = False
            MsgBox(ex.Message)
        End Try

        Return retorno
    End Function
End Class
