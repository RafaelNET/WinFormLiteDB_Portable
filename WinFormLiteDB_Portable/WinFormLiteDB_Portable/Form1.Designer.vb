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
        Me.btnCriarBanco = New System.Windows.Forms.Button()
        Me.btnNovaTabela = New System.Windows.Forms.Button()
        Me.btnLerRegistros = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCriarBanco
        '
        Me.btnCriarBanco.Location = New System.Drawing.Point(13, 13)
        Me.btnCriarBanco.Name = "btnCriarBanco"
        Me.btnCriarBanco.Size = New System.Drawing.Size(173, 23)
        Me.btnCriarBanco.TabIndex = 0
        Me.btnCriarBanco.Text = "Criar banco de dados"
        Me.btnCriarBanco.UseVisualStyleBackColor = True
        '
        'btnNovaTabela
        '
        Me.btnNovaTabela.Location = New System.Drawing.Point(12, 42)
        Me.btnNovaTabela.Name = "btnNovaTabela"
        Me.btnNovaTabela.Size = New System.Drawing.Size(174, 23)
        Me.btnNovaTabela.TabIndex = 0
        Me.btnNovaTabela.Text = "Criar tabela com registros"
        Me.btnNovaTabela.UseVisualStyleBackColor = True
        '
        'btnLerRegistros
        '
        Me.btnLerRegistros.Location = New System.Drawing.Point(12, 71)
        Me.btnLerRegistros.Name = "btnLerRegistros"
        Me.btnLerRegistros.Size = New System.Drawing.Size(174, 23)
        Me.btnLerRegistros.TabIndex = 0
        Me.btnLerRegistros.Text = "Ler Registros"
        Me.btnLerRegistros.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(12, 100)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(174, 23)
        Me.btnAtualizar.TabIndex = 0
        Me.btnAtualizar.Text = "Atualizar Registros"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(13, 129)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(174, 23)
        Me.btnExcluir.TabIndex = 0
        Me.btnExcluir.Text = "Excluir Registros"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 171)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnLerRegistros)
        Me.Controls.Add(Me.btnNovaTabela)
        Me.Controls.Add(Me.btnCriarBanco)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCriarBanco As Button
    Friend WithEvents btnNovaTabela As Button
    Friend WithEvents btnLerRegistros As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnExcluir As Button
End Class
