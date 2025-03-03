using System.Text.RegularExpressions;
using Sana08.Helpers;

namespace Sana09;


class Program
{
    static void Main(string[] args)
    {
        // 1 Method
       string email = "testEmail@gmail.com";
       RegexHelper.ValidateEmail(email);
       
       // 2 Method 
       string number = "+380912345678";
       RegexHelper.ValidatePhone(number);
       
       // 3 Method
       string originalString = "Hello   World!  Hello           World Hello   World";
       RegexHelper.RemoveWhiteSpaceCharacters(originalString);
       
       // 4 Method 
       string password = "Test_password20?21";
       RegexHelper.ValidatePassword(password);

       // 5 Method
       string textWithDate =
           "Сьогодні 03.03.2025 ми починаємо новий проєкт.  \nПопередня зустріч була 15.02.2024, а наступна запланована на 10.04.2025.  \nТакож варто згадати, що дедлайн — 30.06.2025.  \nМинулий звіт був зданий 05.09.2023.  \nА ось невірний формат дати: 2025-03-03, 12/12/2022.  \nЩе одна дата для перевірки: 01.01.2000.";
       RegexHelper.finsDates(textWithDate);
    }
}