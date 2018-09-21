function update_encrypt() {
    if (document.getElementById("encrypt_text").value !== "") {
        document.getElementById("encrypt_cipher").parentElement.MaterialTextfield.change(
            CryptoJS.AES.encrypt(
                document.getElementById("encrypt_text").value,
                document.getElementById("encrypt_password").value
            )
        );
    } else {
        document.getElementById("encrypt_cipher").value = "";
        document.getElementById("encrypt_cipher_div").classList.remove("is-dirty");
    }
}

function update_decrypt() {
    if (document.getElementById("decrypt_cipher").value !== "") {
        document.getElementById("decrypt_text").parentElement.MaterialTextfield.change(
            CryptoJS.AES.decrypt(
                document.getElementById("decrypt_cipher").value,
                document.getElementById("decrypt_password").value
            ).toString(CryptoJS.enc.Utf8)
        );
    } else {
        document.getElementById("decrypt_text").value = "";
        document.getElementById("decrypt_text_div").classList.remove("is-dirty");
    }
}
