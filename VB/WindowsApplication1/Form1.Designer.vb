Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.timer1 = New System.Timers.Timer()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.tabControl1 = New System.Windows.Forms.TabControl()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.label3 = New System.Windows.Forms.Label()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.timer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' timer1
            ' 
            Me.timer1.Enabled = True
            Me.timer1.SynchronizingObject = Me
            AddHandler Me.timer1.Elapsed, New System.Timers.ElapsedEventHandler(AddressOf Me.timer1_Elapsed)
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Red
            Me.label1.Location = New System.Drawing.Point(288, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(10, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = " "
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Red
            Me.label2.Location = New System.Drawing.Point(288, 46)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(10, 13)
            Me.label2.TabIndex = 4
            Me.label2.Text = " "
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.labelControl1)
            Me.panel1.Controls.Add(Me.tabControl1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(436, 279)
            Me.panel1.TabIndex = 8
            ' 
            ' tabControl1
            ' 
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.tabControl1.Location = New System.Drawing.Point(0, 94)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(436, 185)
            Me.tabControl1.TabIndex = 12
            ' 
            ' tabPage1
            ' 
            Me.tabPage1.Controls.Add(Me.textBox1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(428, 159)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "tabPage1"
            Me.tabPage1.UseVisualStyleBackColor = True
            ' 
            ' tabPage2
            ' 
            Me.tabPage2.Controls.Add(Me.textBox2)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(280, 74)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "tabPage2"
            Me.tabPage2.UseVisualStyleBackColor = True
            ' 
            ' textBox2
            ' 
            Me.textBox2.Location = New System.Drawing.Point(16, 28)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(157, 20)
            Me.textBox2.TabIndex = 3
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(8, 27)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(270, 20)
            Me.textBox1.TabIndex = 12
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Location = New System.Drawing.Point(12, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(86, 23)
            Me.labelControl1.TabIndex = 13
            Me.labelControl1.Text = "Standard"
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.simpleButton1)
            Me.panel2.Controls.Add(Me.labelControl2)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(436, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(368, 279)
            Me.panel2.TabIndex = 9
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.Location = New System.Drawing.Point(12, 12)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(110, 23)
            Me.labelControl2.TabIndex = 13
            Me.labelControl2.Text = "DevExpress"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Red
            Me.label3.Location = New System.Drawing.Point(19, 46)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(10, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = " "
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(263, 12)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 14
            Me.simpleButton1.Text = "Show"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(804, 279)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.timer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private timer1 As System.Timers.Timer

        Private label2 As System.Windows.Forms.Label

        Private label1 As System.Windows.Forms.Label

        Private panel1 As System.Windows.Forms.Panel

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private tabControl1 As System.Windows.Forms.TabControl

        Private tabPage1 As System.Windows.Forms.TabPage

        Private textBox1 As System.Windows.Forms.TextBox

        Private tabPage2 As System.Windows.Forms.TabPage

        Private textBox2 As System.Windows.Forms.TextBox

        Private panel2 As System.Windows.Forms.Panel

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private label3 As System.Windows.Forms.Label

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
