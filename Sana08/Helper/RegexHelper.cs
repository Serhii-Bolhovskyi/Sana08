using System;
using System.Text.RegularExpressions;

namespace Sana08.Helpers
{
    public static class RegexHelper
    {
        // 1. Перевірка email адреси
        public static bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9+._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool isValidEmail = Regex.IsMatch(email, emailPattern);
            Console.WriteLine($"{email} {(isValidEmail ? "is" : "is not")} a valid email address");
            return isValidEmail;
        }
        
        // 2. Перевірка номера телефону
        public static bool ValidatePhone(string phone)
        {
            string phonePattern = @"^(\+380)(\d{9})$";
            bool isValidPhone = Regex.IsMatch(phone, phonePattern);
            Console.WriteLine($"{phone} {(isValidPhone ? "is" : "is not")} a valid ukranian phone number");
            return isValidPhone;
        }
        
        // 3. Видалення зайвих пробілів
        public static string RemoveWhiteSpaceCharacters(string str)
        {
            string whiteSpacePattern = @"\s+";
            string replacedString = Regex.Replace(str, whiteSpacePattern, " ");
            Console.WriteLine(replacedString);
            return replacedString;
        }
        
        // 4. Перевірка пароля
        public static bool ValidatePassword(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?_&])[A-Za-z\d@$!%*?_&]{8,}$";
            bool isValidPassword = Regex.IsMatch(password, passwordPattern);
            Console.WriteLine($"{password} {(isValidPassword ? "is" : "is not")} a valid password");
            return isValidPassword;
        }
        
        // 5. витягнення дат з тексту 
        public static void finsDates(string date)
        {
            string datePattern = @"(0[1-9]|[12]\d|3[01])\.(0[1-9]|1[0-2])\.\d{4}";
            Console.WriteLine("Correct Dates: ");
            foreach (Match match in Regex.Matches(date, datePattern))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

