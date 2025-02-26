# Turkish Playfair Cipher with .NET MAUI
Alphabet : A B C Ç D E F G Ğ H I İ J K L M N O Ö P R S Ş T U Ü V Y Z X W Q ( ) . ,

## 🔐 What is Playfair Cipher and How Does It Work?
Playfair Cipher is an encryption algorithm developed by Charles Wheatstone in the 19th century. It uses a Digraph (pair of letters) encryption technique to ensure secure communication. Unlike simpler encryption methods like the Caesar Cipher, Playfair encrypts text in pairs and applies specific rules to encrypt those pairs, offering a stronger encryption.

### 🚀 How Does Playfair Cipher Work?
1. Creating the Key Matrix:
To begin with Playfair cipher, a key matrix is generated. This matrix is typically a 5x5 grid, but in this project, a 6x6 matrix is used. The key matrix is constructed by following these steps:
* Remove repeating letters from the key.
* If the number of unique letters is less than 25 (for a 5x5 matrix), the remaining spaces are filled alphabetically. Since this project uses a 6x6 matrix, more characters (such as Turkish characters and special symbols like ., ,, (), etc.) are accommodated.

2. Preparing the Text:
* The text is written in uppercase with spaces removed.
* If the length of the text is odd, an "X" (or another character, depending on implementation) is added to make it even.

3. Dividing the Text into Pairs:
The text is divided into pairs of letters for encryption. If the text is "HELLO", it would become:
```
"HE", "LL", "OX"
```
> If the same letter appears twice consecutively, it is replaced by a different letter (like "X").

4. Encryption Rules:
The encryption works according to three main rules:
* Same Row: If the two letters are in the same row of the matrix, each letter is replaced by the letter to its immediate right. If it's the last letter of the row, it wraps around to the first letter of that row.
* Same Column: If the two letters are in the same column, each letter is replaced by the letter immediately below it. If it's the last letter in the column, it wraps around to the top.
* Different Row and Column: If the letters are neither in the same row nor column, they are replaced with the letters at the opposite corners of the rectangle formed by the two letters.

5. Decryption:
The decryption process is essentially the reverse of encryption:
* Same row: Letters are shifted left.
* Same column: Letters are shifted up.
* Different row and column: The letters are swapped back to their original positions.

### 📝 Example:
Let's say the text to encrypt is "HELLO" and the key word is "KEY".
```
Step 1: Generate the 6x6 Playfair matrix from the keyword "KEY".

Step 2: Split the text into pairs:
"HE", "LL", "OX"

Step 3: Apply the encryption rules for each pair.

Step 4: The final encrypted text is obtained.
```

### 🔄 Decryption:
The same rules are applied in reverse to decrypt the message.

### 💡 Why Playfair Cipher?
Playfair Cipher is a classic encryption method that provides a stronger alternative to simpler techniques like Caesar Cipher. Although it’s no longer widely used today due to the development of more advanced encryption algorithms, it serves as an excellent tool for learning the fundamentals of cryptography.

This project is designed to demonstrate the basic encryption principles of the Playfair Cipher using the .NET MAUI framework, with support for Turkish characters and special symbols.

