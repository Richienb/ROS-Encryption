﻿Imports MaterialSkin
Imports System.Security.Cryptography

Public Class Form1

    Dim mode As Integer = 1
    Dim lastboxtext As String = Nothing
    Dim showpassword As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Red200, TextShade.WHITE)
    End Sub

    Private Sub encryptbtn_Click(sender As Object, e As EventArgs) Handles encryptbtn.Click
        mode = 1
        UpdateMode()
    End Sub

    Private Sub decryptbtn_Click(sender As Object, e As EventArgs) Handles decryptbtn.Click
        mode = 2
        UpdateMode()
    End Sub

    Private Sub UpdateMode()
        If mode = 1 Then
            txtbox1.Hint = "Text"
            txtbox3.Hint = "Cipher"
        Else
            txtbox3.Hint = "Text"
            txtbox1.Hint = "Cipher"
        End If
        txtbox1.Text = Nothing
        txtbox2.Text = Nothing
        lastboxtext = Nothing
        txtbox3.Text = lastboxtext
    End Sub

    Private Sub txtbox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox1.TextChanged
        UpdateLastBox()
    End Sub

    Private Sub UpdateLastBox()
        If txtbox1.Text = Nothing Then
            txtbox3.Text = Nothing
            Exit Sub
        End If
        If mode = 1 Then
            Dim wrapper As New Simple3Des(txtbox2.Text)
            Dim cipherText As String = wrapper.EncryptData(txtbox1.Text)
            lastboxtext = cipherText
            txtbox3.Text = lastboxtext
        Else
            Dim cipherText As String = txtbox1.Text
            Dim password As String = txtbox2.Text
            Dim wrapper As New Simple3Des(password)
            ' DecryptData throws if the wrong password is used.
            Try
                Dim plainText As String = wrapper.DecryptData(cipherText)
                lastboxtext = plainText
                txtbox3.Text = lastboxtext
            Catch ex As System.Security.Cryptography.CryptographicException
                lastboxtext = Nothing
                txtbox3.Text = lastboxtext
            End Try
        End If
    End Sub

    Private Sub txtbox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox2.TextChanged
        UpdateLastBox()
    End Sub

    Private Sub txtbox3_TextChanged(sender As Object, e As EventArgs) Handles txtbox3.TextChanged
        txtbox3.Text = lastboxtext
    End Sub

    Private Sub passwordshowhidebt_Click(sender As Object, e As EventArgs) Handles passwordshowhidebtn.Click
        If showpassword = False Then
            txtbox2.UseSystemPasswordChar = False
            passwordshowhidebtn.Icon = My.Resources.hide_password
            showpassword = True
        Else
            txtbox2.UseSystemPasswordChar = True
            passwordshowhidebtn.Icon = My.Resources.show_password
            showpassword = False
        End If
    End Sub

    Private Sub copytoclipboardbtn_Click(sender As Object, e As EventArgs) Handles copytoclipboardbtn.Click
        If Not txtbox3.Text = Nothing Then
            Clipboard.SetText(txtbox3.Text)
        End If
    End Sub
End Class

Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function EncryptData(
    ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class