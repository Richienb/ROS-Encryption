<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.encryptbtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.decryptbtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtbox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtbox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtbox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.copytoclipboardbtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.passwordshowhidebtn = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'encryptbtn
        '
        Me.encryptbtn.AutoSize = True
        Me.encryptbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.encryptbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.encryptbtn.Depth = 0
        Me.encryptbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.encryptbtn.Icon = Nothing
        Me.encryptbtn.Location = New System.Drawing.Point(0, 0)
        Me.encryptbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.encryptbtn.Name = "encryptbtn"
        Me.encryptbtn.Primary = True
        Me.encryptbtn.Size = New System.Drawing.Size(130, 50)
        Me.encryptbtn.TabIndex = 1
        Me.encryptbtn.Text = "Encrypt"
        Me.encryptbtn.UseVisualStyleBackColor = True
        '
        'decryptbtn
        '
        Me.decryptbtn.AutoSize = True
        Me.decryptbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.decryptbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.decryptbtn.Depth = 0
        Me.decryptbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.decryptbtn.Icon = Nothing
        Me.decryptbtn.Location = New System.Drawing.Point(0, 0)
        Me.decryptbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.decryptbtn.Name = "decryptbtn"
        Me.decryptbtn.Primary = True
        Me.decryptbtn.Size = New System.Drawing.Size(126, 50)
        Me.decryptbtn.TabIndex = 2
        Me.decryptbtn.Text = "Decrypt"
        Me.decryptbtn.UseVisualStyleBackColor = True
        '
        'txtbox1
        '
        Me.txtbox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbox1.Depth = 0
        Me.txtbox1.Hint = "Text"
        Me.txtbox1.Location = New System.Drawing.Point(13, 63)
        Me.txtbox1.MaxLength = 32767
        Me.txtbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox1.SelectedText = ""
        Me.txtbox1.SelectionLength = 0
        Me.txtbox1.SelectionStart = 0
        Me.txtbox1.Size = New System.Drawing.Size(261, 23)
        Me.txtbox1.TabIndex = 3
        Me.txtbox1.UseSystemPasswordChar = False
        '
        'txtbox2
        '
        Me.txtbox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbox2.Depth = 0
        Me.txtbox2.Hint = "Password"
        Me.txtbox2.Location = New System.Drawing.Point(15, 99)
        Me.txtbox2.MaxLength = 32767
        Me.txtbox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox2.SelectedText = ""
        Me.txtbox2.SelectionLength = 0
        Me.txtbox2.SelectionStart = 0
        Me.txtbox2.Size = New System.Drawing.Size(212, 23)
        Me.txtbox2.TabIndex = 4
        Me.txtbox2.UseSystemPasswordChar = True
        '
        'txtbox3
        '
        Me.txtbox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbox3.Depth = 0
        Me.txtbox3.Hint = "Cipher"
        Me.txtbox3.Location = New System.Drawing.Point(15, 137)
        Me.txtbox3.MaxLength = 32767
        Me.txtbox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox3.SelectedText = ""
        Me.txtbox3.SelectionLength = 0
        Me.txtbox3.SelectionStart = 0
        Me.txtbox3.Size = New System.Drawing.Size(212, 23)
        Me.txtbox3.TabIndex = 5
        Me.txtbox3.UseSystemPasswordChar = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Location = New System.Drawing.Point(13, 7)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.encryptbtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.decryptbtn)
        Me.SplitContainer1.Size = New System.Drawing.Size(260, 50)
        Me.SplitContainer1.SplitterDistance = 130
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'copytoclipboardbtn
        '
        Me.copytoclipboardbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copytoclipboardbtn.AutoSize = True
        Me.copytoclipboardbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.copytoclipboardbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.copytoclipboardbtn.Depth = 0
        Me.copytoclipboardbtn.Icon = Global.ROS_Encryption.My.Resources.Resources.copy_to_clipboard
        Me.copytoclipboardbtn.Location = New System.Drawing.Point(230, 132)
        Me.copytoclipboardbtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.copytoclipboardbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.copytoclipboardbtn.Name = "copytoclipboardbtn"
        Me.copytoclipboardbtn.Primary = False
        Me.copytoclipboardbtn.Size = New System.Drawing.Size(44, 36)
        Me.copytoclipboardbtn.TabIndex = 7
        Me.copytoclipboardbtn.UseVisualStyleBackColor = True
        '
        'passwordshowhidebtn
        '
        Me.passwordshowhidebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordshowhidebtn.AutoSize = True
        Me.passwordshowhidebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.passwordshowhidebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passwordshowhidebtn.Depth = 0
        Me.passwordshowhidebtn.Icon = Global.ROS_Encryption.My.Resources.Resources.show_password
        Me.passwordshowhidebtn.Location = New System.Drawing.Point(230, 91)
        Me.passwordshowhidebtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.passwordshowhidebtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.passwordshowhidebtn.Name = "passwordshowhidebtn"
        Me.passwordshowhidebtn.Primary = False
        Me.passwordshowhidebtn.Size = New System.Drawing.Size(44, 36)
        Me.passwordshowhidebtn.TabIndex = 6
        Me.passwordshowhidebtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.Controls.Add(Me.copytoclipboardbtn)
        Me.Controls.Add(Me.passwordshowhidebtn)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(178, 212)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROS Encryption"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents encryptbtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents decryptbtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtbox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtbox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtbox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents passwordshowhidebtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents copytoclipboardbtn As MaterialSkin.Controls.MaterialFlatButton
End Class
