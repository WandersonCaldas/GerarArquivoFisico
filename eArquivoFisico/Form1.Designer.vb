<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lb_binario = New System.Windows.Forms.Label()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.txt_binario = New System.Windows.Forms.TextBox()
        Me.lb_extensao = New System.Windows.Forms.Label()
        Me.txt_extensao = New System.Windows.Forms.TextBox()
        Me.lb_local_gravar = New System.Windows.Forms.Label()
        Me.txt_gravar = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'lb_binario
        '
        Me.lb_binario.AutoSize = True
        Me.lb_binario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_binario.Location = New System.Drawing.Point(13, 24)
        Me.lb_binario.Name = "lb_binario"
        Me.lb_binario.Size = New System.Drawing.Size(59, 17)
        Me.lb_binario.TabIndex = 0
        Me.lb_binario.Text = "Binário"
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(149, 371)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(75, 23)
        Me.btn_fechar.TabIndex = 1
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(30, 371)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 2
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'txt_binario
        '
        Me.txt_binario.Location = New System.Drawing.Point(16, 45)
        Me.txt_binario.MaxLength = 9999999
        Me.txt_binario.Multiline = True
        Me.txt_binario.Name = "txt_binario"
        Me.txt_binario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_binario.Size = New System.Drawing.Size(782, 186)
        Me.txt_binario.TabIndex = 3
        '
        'lb_extensao
        '
        Me.lb_extensao.AutoSize = True
        Me.lb_extensao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_extensao.Location = New System.Drawing.Point(13, 248)
        Me.lb_extensao.Name = "lb_extensao"
        Me.lb_extensao.Size = New System.Drawing.Size(74, 17)
        Me.lb_extensao.TabIndex = 4
        Me.lb_extensao.Text = "Extensão"
        '
        'txt_extensao
        '
        Me.txt_extensao.Location = New System.Drawing.Point(16, 268)
        Me.txt_extensao.Name = "txt_extensao"
        Me.txt_extensao.Size = New System.Drawing.Size(256, 20)
        Me.txt_extensao.TabIndex = 5
        '
        'lb_local_gravar
        '
        Me.lb_local_gravar.AutoSize = True
        Me.lb_local_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_local_gravar.Location = New System.Drawing.Point(13, 307)
        Me.lb_local_gravar.Name = "lb_local_gravar"
        Me.lb_local_gravar.Size = New System.Drawing.Size(165, 17)
        Me.lb_local_gravar.TabIndex = 6
        Me.lb_local_gravar.Text = "Caminho de gravação"
        '
        'txt_gravar
        '
        Me.txt_gravar.Location = New System.Drawing.Point(12, 328)
        Me.txt_gravar.Name = "txt_gravar"
        Me.txt_gravar.Size = New System.Drawing.Size(256, 20)
        Me.txt_gravar.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 422)
        Me.Controls.Add(Me.txt_gravar)
        Me.Controls.Add(Me.lb_local_gravar)
        Me.Controls.Add(Me.txt_extensao)
        Me.Controls.Add(Me.lb_extensao)
        Me.Controls.Add(Me.txt_binario)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lb_binario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_binario As Label
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents txt_binario As TextBox
    Friend WithEvents lb_extensao As Label
    Friend WithEvents txt_extensao As TextBox
    Friend WithEvents lb_local_gravar As Label
    Friend WithEvents txt_gravar As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
