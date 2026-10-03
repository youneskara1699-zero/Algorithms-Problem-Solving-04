using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Policy_Enforcement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray PasswordPolicy = new BitArray(4, false);

            string password = "Password123!";

            PasswordPolicy[0] = password.Any(char.IsUpper);
            PasswordPolicy[1] = password.Any(char.IsLower);
            PasswordPolicy[2] = password.Any(char.IsDigit);
            PasswordPolicy[3] = password.Any (ch => "!@#$%^&*".Contains(ch));

            bool IsValid = password.Cast<bool>().All(bit => bit);

            Console.WriteLine($"Password Valid: {IsValid}");
        }
    }
}
