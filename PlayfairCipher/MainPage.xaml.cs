using System;
using System.Linq;
using Microsoft.Maui.Controls;

namespace PlayfairCipher;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Encrypt_Clicked(object sender, EventArgs e)
    {
        string text = InputText.Text.ToUpper();
        string key = KeyText.Text.ToUpper();
        ResultLabel.Text = PlayfairEncrypt(text, key);
    }

    private void Decrypt_Clicked(object sender, EventArgs e)
    {
        string text = InputText.Text.ToUpper();
        string key = KeyText.Text.ToUpper();
        ResultLabel.Text = PlayfairDecrypt(text, key);
    }

    private static char[,] GeneratePlayfairMatrix(string key)
    {
        string alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZXWQ().,";
        string newKey = new string(key.Distinct().ToArray()) + alphabet;
        newKey = new string(newKey.Distinct().ToArray());

        char[,] matrix = new char[6, 6];
        int index = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                matrix[i, j] = newKey[index++];
            }
        }
        return matrix;
    }

    private static (int, int) FindPosition(char[,] matrix, char letter)
	{
		for (int i = 0; i < 6; i++)
		{
			for (int j = 0; j < 6; j++)
			{
				if (matrix[i, j] == letter)
					return (i, j);
			}
		}

		
		throw new ArgumentOutOfRangeException($"Character '{letter}' not found in matrix.");
	}


    private static string PlayfairEncrypt(string text, string key)
    {
        char[,] matrix = GeneratePlayfairMatrix(key);
        text = text.Replace(" ", "");
        if (text.Length % 2 != 0)
            text += 'X';

        string result = "";
        for (int i = 0; i < text.Length; i += 2)
        {
            (int x1, int y1) = FindPosition(matrix, text[i]);
            (int x2, int y2) = FindPosition(matrix, text[i + 1]);

            if (x1 == x2)
            {
                result += matrix[x1, (y1 + 1) % 6];
                result += matrix[x2, (y2 + 1) % 6];
            }
            else if (y1 == y2)
            {
                result += matrix[(x1 + 1) % 6, y1];
                result += matrix[(x2 + 1) % 6, y2];
            }
            else
            {
                result += matrix[x1, y2];
                result += matrix[x2, y1];
            }
        }
        return result;
    }

    private static string PlayfairDecrypt(string text, string key)
	{
		char[,] matrix = GeneratePlayfairMatrix(key);
		string result = "";

		
		if (text.Length % 2 != 0)
			text += 'X';

		for (int i = 0; i < text.Length; i += 2)
		{
			(int x1, int y1) = FindPosition(matrix, text[i]);
			(int x2, int y2) = FindPosition(matrix, text[i + 1]);

			if (x1 == x2)
			{
				result += matrix[x1, (y1 + 5) % 6];
				result += matrix[x2, (y2 + 5) % 6];
			}
			else if (y1 == y2)
			{
				result += matrix[(x1 + 5) % 6, y1];
				result += matrix[(x2 + 5) % 6, y2];
			}
			else
			{
				result += matrix[x1, y2];
				result += matrix[x2, y1];
			}
		}
		return result;
	}
}
