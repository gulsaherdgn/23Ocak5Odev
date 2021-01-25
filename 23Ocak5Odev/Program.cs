using System;
using System.Collections.Generic;

namespace OyuncuOdev
{
    class Program
    {
        static void Main(string[] args)
        {

 
            Player person = new Player();

            person.FirstName = "Yusuf";
            person.LastName = "Açmacı";
            person.NationalityId = "1234567890";
            person.YearOfBirth = 2005;
            person.UserName = "yusty";
            person.Password = "şifre";
            person.Balance = 12.48;


            


            IVerificationService verificationService = new MernisVerificationService();

            if (verificationService.Verificate(person))
            {
                IPlayerService playerService = new PlayerService();
                playerService.Add(person);

                List<ILoggerService> loggerServiceList = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };
                foreach (var logger in loggerServiceList)
                {
                    logger.Add(person);
                }

                IGame game = new Game();
                game.Name = "GTA V";
                game.Publisher = "Rockstar Games";
                game.UnitPrice = 180;

                ISales sales = new SummerSales();
                sales.Discount(game);

            }
            else
            {
                Console.WriteLine("Girdiğiniz bilgilerde hata var tekrar deneyiniz");
            }



            


        }
    }
}
