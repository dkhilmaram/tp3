<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ComboBox1.ForeColor = SystemColors.ActiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(210, 33)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(387, 36)
        ComboBox1.TabIndex = 0
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        RadioButton1.ForeColor = SystemColors.ActiveCaption
        RadioButton1.Location = New Point(356, 84)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(169, 32)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "croute epaisse"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        RadioButton2.ForeColor = SystemColors.ActiveCaption
        RadioButton2.Location = New Point(549, 84)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(186, 32)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "croute classique"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        RadioButton3.ForeColor = SystemColors.ActiveCaption
        RadioButton3.Location = New Point(201, 84)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(137, 32)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "croute fine"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CheckBox1.ForeColor = SystemColors.ActiveCaption
        CheckBox1.Location = New Point(199, 134)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(160, 32)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "champignons"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CheckBox2.ForeColor = SystemColors.ActiveCaption
        CheckBox2.Location = New Point(199, 164)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(89, 32)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "olives"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CheckBox3.ForeColor = SystemColors.ActiveCaption
        CheckBox3.Location = New Point(199, 194)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(116, 32)
        CheckBox3.TabIndex = 6
        CheckBox3.Text = "poivrons"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CheckBox4.ForeColor = SystemColors.ActiveCaption
        CheckBox4.Location = New Point(199, 224)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(267, 32)
        CheckBox4.TabIndex = 7
        CheckBox4.Text = "fromage supplementaire"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ActiveCaption
        Button1.Location = New Point(397, 145)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 69)
        Button1.TabIndex = 8
        Button1.Text = "afficher la commande"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Button1 As Button

End Class
