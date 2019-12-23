<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_tmp_Agenda
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgLIGACOES = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLOCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TROCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETIRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pgTAREFAS = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TAREFA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.pgLIGACOES.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgTAREFAS.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgLIGACOES)
        Me.TabControl1.Controls.Add(Me.pgTAREFAS)
        Me.TabControl1.Location = New System.Drawing.Point(257, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(861, 511)
        Me.TabControl1.TabIndex = 3
        '
        'pgLIGACOES
        '
        Me.pgLIGACOES.Controls.Add(Me.DataGridView1)
        Me.pgLIGACOES.Location = New System.Drawing.Point(4, 22)
        Me.pgLIGACOES.Name = "pgLIGACOES"
        Me.pgLIGACOES.Padding = New System.Windows.Forms.Padding(3)
        Me.pgLIGACOES.Size = New System.Drawing.Size(853, 485)
        Me.pgLIGACOES.TabIndex = 0
        Me.pgLIGACOES.Text = "LIGAÇÕES"
        Me.pgLIGACOES.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.OBRA, Me.COLOCA, Me.TROCA, Me.RETIRA, Me.STATUS})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(841, 428)
        Me.DataGridView1.TabIndex = 2
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        '
        'OBRA
        '
        Me.OBRA.HeaderText = "OBRA"
        Me.OBRA.Name = "OBRA"
        '
        'COLOCA
        '
        Me.COLOCA.HeaderText = "COLOCA"
        Me.COLOCA.Name = "COLOCA"
        '
        'TROCA
        '
        Me.TROCA.HeaderText = "TROCA"
        Me.TROCA.Name = "TROCA"
        '
        'RETIRA
        '
        Me.RETIRA.HeaderText = "RETIRA"
        Me.RETIRA.Name = "RETIRA"
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        '
        'pgTAREFAS
        '
        Me.pgTAREFAS.Controls.Add(Me.DataGridView2)
        Me.pgTAREFAS.Location = New System.Drawing.Point(4, 22)
        Me.pgTAREFAS.Name = "pgTAREFAS"
        Me.pgTAREFAS.Padding = New System.Windows.Forms.Padding(3)
        Me.pgTAREFAS.Size = New System.Drawing.Size(853, 485)
        Me.pgTAREFAS.TabIndex = 1
        Me.pgTAREFAS.Text = "TAREFAS"
        Me.pgTAREFAS.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TAREFA})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(841, 428)
        Me.DataGridView2.TabIndex = 3
        '
        'TAREFA
        '
        Me.TAREFA.HeaderText = "TAREFA"
        Me.TAREFA.Name = "TAREFA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'FAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 533)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "FAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDA"
        Me.TabControl1.ResumeLayout(False)
        Me.pgLIGACOES.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgTAREFAS.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents pgLIGACOES As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLOCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TROCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RETIRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pgTAREFAS As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TAREFA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
