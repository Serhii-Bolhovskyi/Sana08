using System.Net;
using System.Text;
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
       
        // 6 Method
        string textForFiltration = "Андрій активний автор аналізує архітектуру. Але аркуш і антонім аномальний. \nАпельсин ароматний, але алгебра абстрактна. Автомобіль акуратно аеродинамічний.";
        RegexHelper.filterWords(textForFiltration);
        
        // 7 Method
        string Ip = "127.0.0.1";
        RegexHelper.ValidateIPv4(Ip);
        
        // 8 Method
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString("https://greenspaces.netlify.app/");
        RegexHelper.FindHtmlTag(html);
        
        // 9 Method 
        string textWithUrl =
            "Правильні URL:\n1. https://google.com\n2. ftp://ftp.example.com/file.txt\n\nНеправильні URL:\n3. example_com/invalid (пропущена крапка між example і com)\n4. htttp://wrong-url.com (зайва літера 't' у \"http\")";
        RegexHelper.FindUrl(textWithUrl);
        
        // 10 Method 
        string text = "(123) 456-7890, (987) 654-3210, (123-456-7890.";
        RegexHelper.FindAndReplaceNumber(text);
            
    }
}