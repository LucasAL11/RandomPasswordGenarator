using System.Security.Cryptography;
using System.Text;

public static class Randomizers
{
    public static string GetRandomPassword(int length)
    {
        const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var substring = new StringBuilder();
        var random = new Random();

        for (var i = 0; i < length; i++)
        {
            var index = random.Next(chars.Length);
            substring.Append(chars[index]);
        }

        return substring.ToString();
    }

    public static string RngSecurityRandomizer(int length)
    {
        var rgb = new byte[length];
        var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
        rngCryptoServiceProvider.GetBytes(rgb);
        return Convert.ToBase64String(rgb);
    }

}