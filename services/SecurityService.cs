using System.Security.Cryptography;
using System.Text;

public static string Hash(string s)
{
    using var sha = SHA256.Create();
    return Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(s)));
}
