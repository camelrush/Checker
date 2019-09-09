<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckRunner
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.prgAll = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.prgX = New System.Windows.Forms.ProgressBar()
        Me.prgY = New System.Windows.Forms.ProgressBar()
        Me.prgZ = New System.Windows.Forms.ProgressBar()
        Me.lblPrgAll = New System.Windows.Forms.Label()
        Me.lblPrgX = New System.Windows.Forms.Label()
        Me.lblPrgY = New System.Windows.Forms.Label()
        Me.lblPrgZ = New System.Windows.Forms.Label()
        Me.cmdInit = New System.Windows.Forms.Button()
        Me.timProgress = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(325, 175)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(94, 43)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "開始"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(425, 175)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(94, 43)
        Me.cmdEnd.TabIndex = 1
        Me.cmdEnd.Text = "終了"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'prgAll
        '
        Me.prgAll.Location = New System.Drawing.Point(163, 12)
        Me.prgAll.Name = "prgAll"
        Me.prgAll.Size = New System.Drawing.Size(356, 24)
        Me.prgAll.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(52, 139)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(467, 24)
        Me.lblStatus.TabIndex = 3
        '
        'prgX
        '
        Me.prgX.Location = New System.Drawing.Point(163, 42)
        Me.prgX.Name = "prgX"
        Me.prgX.Size = New System.Drawing.Size(356, 24)
        Me.prgX.TabIndex = 4
        '
        'prgY
        '
        Me.prgY.Location = New System.Drawing.Point(163, 72)
        Me.prgY.Name = "prgY"
        Me.prgY.Size = New System.Drawing.Size(356, 24)
        Me.prgY.TabIndex = 5
        '
        'prgZ
        '
        Me.prgZ.Location = New System.Drawing.Point(163, 102)
        Me.prgZ.Name = "prgZ"
        Me.prgZ.Size = New System.Drawing.Size(356, 24)
        Me.prgZ.TabIndex = 6
        '
        'lblPrgAll
        '
        Me.lblPrgAll.AutoSize = True
        Me.lblPrgAll.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPrgAll.Location = New System.Drawing.Point(49, 12)
        Me.lblPrgAll.Name = "lblPrgAll"
        Me.lblPrgAll.Size = New System.Drawing.Size(56, 15)
        Me.lblPrgAll.TabIndex = 7
        Me.lblPrgAll.Text = "AllCheck"
        '
        'lblPrgX
        '
        Me.lblPrgX.AutoSize = True
        Me.lblPrgX.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPrgX.Location = New System.Drawing.Point(49, 42)
        Me.lblPrgX.Name = "lblPrgX"
        Me.lblPrgX.Size = New System.Drawing.Size(50, 15)
        Me.lblPrgX.TabIndex = 8
        Me.lblPrgX.Text = "CheckX"
        '
        'lblPrgY
        '
        Me.lblPrgY.AutoSize = True
        Me.lblPrgY.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPrgY.Location = New System.Drawing.Point(49, 72)
        Me.lblPrgY.Name = "lblPrgY"
        Me.lblPrgY.Size = New System.Drawing.Size(50, 15)
        Me.lblPrgY.TabIndex = 9
        Me.lblPrgY.Text = "CheckY"
        '
        'lblPrgZ
        '
        Me.lblPrgZ.AutoSize = True
        Me.lblPrgZ.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPrgZ.Location = New System.Drawing.Point(49, 102)
        Me.lblPrgZ.Name = "lblPrgZ"
        Me.lblPrgZ.Size = New System.Drawing.Size(50, 15)
        Me.lblPrgZ.TabIndex = 10
        Me.lblPrgZ.Text = "CheckZ"
        '
        'cmdInit
        '
        Me.cmdInit.Location = New System.Drawing.Point(52, 175)
        Me.cmdInit.Name = "cmdInit"
        Me.cmdInit.Size = New System.Drawing.Size(94, 43)
        Me.cmdInit.TabIndex = 11
        Me.cmdInit.Text = "内容初期化"
        Me.cmdInit.UseVisualStyleBackColor = True
        '
        'timProgress
        '
        '
        'frmCheckRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdInit)
        Me.Controls.Add(Me.lblPrgZ)
        Me.Controls.Add(Me.lblPrgY)
        Me.Controls.Add(Me.lblPrgX)
        Me.Controls.Add(Me.lblPrgAll)
        Me.Controls.Add(Me.prgZ)
        Me.Controls.Add(Me.prgY)
        Me.Controls.Add(Me.prgX)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.prgAll)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdStart)
        Me.Name = "frmCheckRunner"
        Me.Text = "CheckRunner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdEnd As Button
    Friend WithEvents prgAll As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents prgX As ProgressBar
    Friend WithEvents prgY As ProgressBar
    Friend WithEvents prgZ As ProgressBar
    Friend WithEvents lblPrgAll As Label
    Friend WithEvents lblPrgX As Label
    Friend WithEvents lblPrgY As Label
    Friend WithEvents lblPrgZ As Label
    Friend WithEvents cmdInit As Button
    Friend WithEvents timProgress As Timer
End Class
