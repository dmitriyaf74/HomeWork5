namespace HomeWork5
{
    internal class Program
    {
        private static string userName = "";
        private const string commonCommands = "/start, /help, /info, /exit";
        private const string allCommands = "/start, /help, /info, /echo, /exit";



        static void ShowSelect()
        {
            if (userName == "")
                Console.WriteLine($"Выберите меню: {commonCommands}");
            else
                Console.WriteLine($"Выберите меню: {allCommands}");
        }

        static void ShowWelcome()
        {
            if (userName == "")
                Console.WriteLine("Добро пожаловать");
            else
                Console.WriteLine($"{userName}, добро пожаловать");
        }

        static void FakeSelect()
        {
            if (userName == "")
                Console.WriteLine("Вы ошиблись при наборе команды.");
            else
                Console.WriteLine($"{userName}, вы ошиблись при наборе команды.");
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
            if (userName != "")
                Console.WriteLine("/echo  - повторялка");
            Console.WriteLine("/exit  - завершение программы");
        }


        static void WaitReadLine()
        {
            string userCommand = "";
            string[] userCommandArr = { };

            do
            {
                userCommand = Console.ReadLine();
                userCommandArr = userCommand.Split(' ');

                switch (userCommandArr[0]) 
                {
                    case "/exit":
                        return;

                    case "/start":
                        userName = "";
                        while (userName == "") 
                            {
                                Console.WriteLine("Введите свое имя:");
                                userName = Console.ReadLine();
                                if (userName == "")
                                    Console.WriteLine("Имя не может быть пустым");
                        };
                        ShowWelcome();
                        ShowSelect();
                        break;
                    case "/help":
                        ShowVerHelp();
                        break;
                    case "/info":
                        ShowVerInfo();
                        break;
                    case "/echo":
                        if (userName == "")
                            goto default;
                        if (userCommandArr.Length > 1)
                            Console.WriteLine(userCommand.Substring(6, userCommand.Length-6));
                        else
                            Console.WriteLine("");
                        break;
                    default:
                        FakeSelect();
                        ShowVerHelp();
                        break;
                }

                } while (true);

        }

        static void Main(string[] args)
        {
            ShowWelcome();
            ShowSelect();
            WaitReadLine();
        }


    }
}
