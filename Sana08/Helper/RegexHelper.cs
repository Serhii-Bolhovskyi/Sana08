using System;
using System.Text;
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
        
        // 6. Фільтрація слів
        public static void filterWords(string text)
        {
            string wordPatter = @"\b[AaАа]\w{5,}";
            Console.WriteLine("Correct words: ");
            foreach(Match match in Regex.Matches(text, wordPatter))
            {
                Console.WriteLine(match.Value);
            }
        }
        
        // 7. Перевірка формату IP-адреси
        public static bool ValidateIPv4(string ip)
        {
            string IPpattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            bool isValidIP = Regex.IsMatch(ip, IPpattern);
            Console.WriteLine($"{ip} {(isValidIP ? "is" : "is not")} a valid IP address");
            return isValidIP;
        }
        
        // 8. Пошук HTML tag
        public static void FindHtmlTag(string html)
        {
            string tagPattern = @"<\/?[a-zA-Z]+[^>]*>";
            Console.WriteLine("HTML tags: ");
            foreach (Match match in Regex.Matches(html, tagPattern))
            {
                Console.WriteLine(match.Value);
            }
            
        }
        
        // 9. Знайти Url
        public static void FindUrl(string url)
        {
            string urlPattern = @"\b(?:https?|ftp):\/\/[^\s/$.?#].[^\s]*\b"; 
            Console.WriteLine("URL: ");
            foreach (Match match in Regex.Matches(url, urlPattern))
            {
                Console.WriteLine(match.Value);
            }
        }
        
        // 10. Заміна формотування номеру телефону
        public static void FindAndReplaceNumber(string text)
        {
            string numberPattern = @"\(\d{3}\)\s?\d{3}-\d{4}";  
            Console.WriteLine("Replaced Numbers: ");
            
            foreach (Match match in Regex.Matches(text, numberPattern))
            {
                string replacedNumber = match.Value.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                replacedNumber = replacedNumber.Insert(3, "-").Insert(7, "-");
                
                Console.WriteLine(replacedNumber);
            }
        }
    }
}

