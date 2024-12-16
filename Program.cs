namespace HomeWork5
{
    internal class Program
    {
        private static string UserName = "";
        private const string CommonCommands = "/start, /help, /info, /exit";
        private const string AllCommands = "/start, /help, /info, /echo, /exit";



        static void ShowWelcome()
        {
            if (UserName == "")
            {
                Console.WriteLine("Добро пожаловать");
                Console.WriteLine(CommonCommands);
            }
            else
            {
                Console.WriteLine(UserName + ", добро пожаловать");
                Console.WriteLine(AllCommands);
            }
        }

        static void FakeSelect()
        {
            if (UserName == "")
                Console.WriteLine("Вы ошиблись при наборе команды.");
            else
                Console.WriteLine(UserName + ", вы ошиблись при наборе команды.");
        }

        static void ShowVerInfo()
        {
            Console.WriteLine("Дата создания 16.12.2024");
            Console.WriteLine("Версия 1");
        }

        static void ShowVerHelp()
        {
            Console.WriteLine("/start - знакомство");
            Console.WriteLine("/help  - текущее сообщение");
            Console.WriteLine("/info  - о программе");
            Console.WriteLine("/echo  - повторялка");
            Console.WriteLine("/exit  - завершение программы");
        }


        static void WhiteReadLide()
        {
            string UserCommand = "";
            string[] UserCommandArr = { };

            do
            {
                UserCommand = Console.ReadLine();
                UserCommandArr = UserCommand.Split(' ');

                switch (UserCommandArr[0]) 
                {
                    case "/exit":
                        return;

                    case "/start":
                        Console.WriteLine("Введите свое имя:");
                        UserName = Console.ReadLine();
                        ShowWelcome();
                        break;
                    case "/help":
                        ShowVerHelp();
                        break;
                    case "/info":
                        ShowVerInfo();
                        break;
                    case "/echo":
                        if (UserCommandArr.Length > 1)
                            Console.WriteLine(UserCommandArr[1]);
                        else
                            Console.WriteLine("");
                        break;
                    default:
                        FakeSelect();
                        break;
                }

                } while (true);

        }

        static void Main(string[] args)
        {
            ShowWelcome();
            
            WhiteReadLide();
        }

    }
}
