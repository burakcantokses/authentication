using System;

namespace Delta_Authenticaton
{
    class Program
    {
        static void Main(string[] args)
        {
            string id,username,pass,finished;
            System.Console.WriteLine("ID'nizi Girin.");
            id = Console.ReadLine();

            System.Console.WriteLine("Kullanıcı Adınızı Girin.");
            username = Console.ReadLine();

            System.Console.WriteLine("Şifrenizi Girin.");
            pass = Console.ReadLine();
            
            finished = username+":"+pass;

            string webpageData;
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            webpageData = webClient.DownloadString("https://raw.githubusercontent.com/burakcantokses/authentication/main/user"+id);
            var webpage = webpageData;
            if (webpage.Contains(finished)) {
                System.Console.WriteLine("Başarılı!");
            }else {
                System.Console.WriteLine("başarısız");
            }
            System.Console.WriteLine(finished);
            System.Console.WriteLine(webpage);

        }
    }
}
