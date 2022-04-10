using System;

namespace ConsoleApp80
{
    internal class Program
    {
        static void Main(string[] args, Menultem menultem)
        {
            string menu;
            do
            {
                Console.WriteLine("Secim edin!");
                Console.WriteLine("1.Menu uzerinde emeliyyatlar.");
                Console.WriteLine("2.Sifarisler uzerinde emeliyyatlar.");
                Console.WriteLine("0.Sistemden cixmaq.");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":

                    default:
                        break;
                }
            } while (true);



        }

        private static void EditMenu()
        {
            String mainMenu;
            do
            {
                Console.WriteLine("1.1.Yeni item elave et");
                Console.WriteLine("1.2.Item uzerinde duzelis et");
                Console.WriteLine("1.3.Item sil");
                Console.WriteLine("1.4.Butun Item-lari goster");
                Console.WriteLine("1.5.Categoriyasina gore menu item-lari goster");
                Console.WriteLine("1.6.Qiymet araligina gore menu item-lar goster");
                Console.WriteLine("1.7. Menu item-lar arasinda ada gore axtaris et");
                Console.WriteLine("0.Evvelki menuya qayit");
                mainMenu = Console.ReadLine();
                switch (mainMenu)
                {
                    case "1.1":
                        string editName;
                        int editNo;
                        double editPrice;
                        string editCategory;
                        do
                        {
                            Console.WriteLine("Yeni item adini daxil edin.");
                            editName = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(editName) || editName.Length > 3 || editName.Length < 100);

                        do
                        {
                            Console.WriteLine("Yeni item No elave edin.");
                            editNo = Convert.ToInt32(Console.ReadLine());
                        } while (int.TryParse(editNo) || editNo > 1);
                        do
                        {
                            Console.WriteLine("Yeni item price deyerini daxil edin.");
                            editPrice = Convert.ToDouble(Console.ReadLine());
                        } while (Menultem());
                        break;
                    case "1.2":
                        Console.WriteLine("Duzelis etmek isdediyiniz menu nomresini daxil edin.");
                        int menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Duzelis edilecek item adini daxil edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Duzelis edilecek item qiymetini daxil edin");
                        double price = Convert.ToDouble(Console.ReadLine());
                        if (string.IsNullOrWhiteSpace ||)
                        {
                            
                        }
                        break;

                    default:
                        break;
                }
            } while (true);
        }

        private static bool Menultem()
        {
            throw new NotImplementedException();
        }
    }
}
