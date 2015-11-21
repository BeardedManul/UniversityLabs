using System;
using System.IO;

namespace BigdanLab1Architect
{
    class Program
    {
        static int Main(string[] args)

        {
            string rep = "Continue";
            string delfolder = "";
            string delcfile = "";
            string argf = "/F";
            string helpst = "help";
            string argp = "/P";
            string arga = "/S";
            string argc = "/C";
            char[] delimiterChars = { ' ', ',' };

            string help = "Это системная утилита для удаления файлов и папок. \n При запуске из терминала Windows: \n путь к программе" + @"\" + "FileDel.exe [help |искомая папка | удаляемый файл [/F | /P | /S | /C]] \n Где: \n /F - удаление файла \n /P - удаление папки (пустой) \n /S - удаление папки и всего ее содержимого \n /C - поиск в папке и ее подпапках указанного файла \n help - справка \n При запуске из Проводника Windows:\n [help| папка для поиска |удаляемый файл [/F | /P | /S | /C]] \n Где: \n /F - удаление файла \n /P - удаление папки (пустой) \n /S - удаление папки и всего ее содержимого \n /C - поиск в папке и ее подпапках указанного файла \n help - справка \n В случае запуска через терминал с указанным атрибутом удаления, \n диалоговый режим не будет доступен.";

            if (args.Length == 0)
            {
                while (rep == "Continue")
                {
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать в системную утилиту, предназначенную для удаления файлов.");
                    Console.WriteLine("Эта утилита была написана Бигданом Ростиславом, гр. ПЗ-14-1.");
                    Console.WriteLine("Если вам нужна помощь в использовании этой утилиты, введите help в строке терминала.");

                    string line = Console.ReadLine();

                    if (line.Contains("help"))
                    {
                        Console.WriteLine(help);
                        Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                        rep = Console.ReadLine();
                        if (rep == "Continue")
                        {
                            Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                            Console.ReadKey();
                        }
                        if (rep == "Exit") return 0;
                    }
                    else
                    {
                        if (line.Contains("/F"))
                        {
                            string TrimF = line.TrimEnd(new Char[] { '/', 'F', ' '});
                            string[] words = TrimF.Split(delimiterChars);

                            for (int i = 0; i < words.Length; i++)
                            {
                                if (File.Exists(words[i]))
                                {
                                    File.Delete(words[i]);
                                    Console.WriteLine("Удаление успешно");
                                }

                                else
                                {
                                    Console.WriteLine("Файл не существует, или путь к файлу указан неверно");
                                    Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                    rep = Console.ReadLine();
                                    if (rep == "Continue")
                                    {
                                        Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                        Console.ReadKey();
                                    }
                                    if (rep == "Exit") return -1;
                                }
                            }
                            Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                            rep = Console.ReadLine();
                            if (rep == "Continue")
                            {
                                Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                Console.ReadKey();
                            }
                            if (rep == "Exit") return 0;
                        }
                        else
                        {
                            if (line.Contains("/P"))
                            {
                                string TrimP = delfolder.TrimEnd(new Char[] { '/', 'P', ' '});
                                string[] words = TrimP.Split(delimiterChars);

                                for (int i = 0; i < words.Length; i++)
                                {
                                    if (Directory.Exists(words[i]))
                                    {
                                        Directory.Delete(words[i]);
                                        Console.WriteLine("Удаление успешно");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Директория не существует, либо указана неверно");
                                        Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                        rep = Console.ReadLine();
                                        if (rep == "Continue")
                                        {
                                            Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                            Console.ReadKey();
                                        }
                                        if (rep == "Exit") return -1;
                                    }
                                }
                                Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                rep = Console.ReadLine();
                                if (rep == "Continue")
                                {
                                    Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                    Console.ReadKey();
                                }
                                if (rep == "Exit") return 0;
                            }
                            else
                            {
                                if (line.Contains("/S"))
                                {
                                    string TrimS = delfolder.TrimEnd(new Char[] { '/', 'S', ' '});
                                    string[] words = TrimS.Split(delimiterChars);

                                    for (int i = 0; i < words.Length; i++)
                                    {
                                        if (Directory.Exists(words[i]))
                                        {
                                            Directory.Delete(words[i], true);
                                            Console.WriteLine("Удаление успешно");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Директория не существует, либо указана неверно");
                                            Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                            rep = Console.ReadLine();
                                            if (rep == "Continue")
                                            {
                                                Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                                Console.ReadKey();
                                            }
                                            if (rep == "Exit") return -1;
                                        }
                                    }
                                    Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                    rep = Console.ReadLine();
                                    if (rep == "Continue")
                                    {
                                        Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                        Console.ReadKey();
                                    }
                                    if (rep == "Exit") return 0;
                                }
                                else
                                {
                                    if (line.Contains("/C"))
                                    {
                                        string TrimC = line.TrimEnd(new Char[] { '/', 'C', ' '});
                                        string[] words = TrimC.Split(delimiterChars);
                                        string[] allFoundFiles = Directory.GetFiles(words[0], words[1], SearchOption.AllDirectories);

                                        Console.WriteLine("Список файлов: ");

                                        foreach (string file in allFoundFiles)
                                        {
                                            Console.WriteLine(file);
                                        }

                                        Console.WriteLine("Удалить файлы?");
                                        Console.WriteLine("Если да - введите Y");
                                        Console.WriteLine("Если нет введите N");

                                        string option = Console.ReadLine();

                                        if (option == "Y")
                                        {
                                            foreach (string file1 in allFoundFiles)
                                            {
                                                File.Delete(file1);
                                                Console.WriteLine("Удаление успешно");
                                            }
                                        }
                                        if (option == "N")
                                        {
                                            Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                            rep = Console.ReadLine();
                                            if (rep == "Continue")
                                            {
                                                Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                                Console.ReadKey();
                                            }
                                            if (rep == "Exit") return 0;
                                        }
                                        Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                        rep = Console.ReadLine();
                                        if (rep == "Continue")
                                        {
                                            Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                            Console.ReadKey();
                                        }
                                        if (rep == "Exit") return 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введенное вами выражение не соответствует требованиям");
                                        Console.WriteLine("Для продолжения работы с программой введите Continue, для выхода Exit");
                                        rep = Console.ReadLine();
                                        if (rep == "Continue")
                                        {
                                            Console.WriteLine("Вы выбрали продолжение работы. Нажмите любую кнопку, чтобы продолжить.");
                                            Console.ReadKey();
                                        }
                                        if (rep == "Exit") return -1;
                                    }
                                }
                            }
                        }
                    } 
                }
            }
            if (args.Length > 0)
            {
                if (helpst == args[0])
                {
                    Console.WriteLine(help);
                    Console.ReadKey();
                    return 0;
                }

                else
                {
                    if (argf == args[1])
                    {
                        delcfile = args[0];
                        string TrimDelcon = delcfile.TrimEnd(new Char[] { '/', 'F' });
                        if (File.Exists(TrimDelcon))
                        {
                            File.Delete(TrimDelcon);
                            Console.WriteLine("Удаление успешно");
                            Console.ReadKey();
                            return 0;
                        }

                        else
                        {
                            Console.WriteLine("Файл не существует, или путь к файлу указан неверно");
                            Console.ReadKey();
                            return -1;
                        }
                    }
                    else
                    {
                        if (argp == args[1])
                        {
                            delcfile = args[0];
                            string TrimDelcon = delcfile.TrimEnd(new Char[] { '/', 'P' });
                            if (Directory.Exists(delcfile))
                            {
                                Directory.Delete(delcfile);
                                Console.WriteLine("Удаление успешно");
                                Console.ReadKey();
                                return 0;
                            }
                            else
                            {
                                Console.WriteLine("Файл не существует, или путь к файлу указан неверно");
                                Console.ReadKey();
                                return -1;
                            }
                        }
                        else
                        {
                            if (arga == args[1])
                            {
                                delcfile = args[0];
                                string TrimDelcon = delcfile.TrimEnd(new Char[] { '/', 'S' });
                                if (Directory.Exists(delcfile))
                                {
                                    Directory.Delete(delcfile, true);
                                    Console.WriteLine("Удаление успешно");
                                    Console.ReadKey();
                                    return 0;
                                }
                                {
                                    Console.WriteLine("Директория не существует, либо указана неверно");
                                    Console.ReadKey();
                                    return -1;
                                }
                            }

                            else
                            {
                                if (argc == args[2])
                                {
                                    if (Directory.Exists(args[0]))
                                    {
                                        string[] allFoundFiles = Directory.GetFiles(args[0], args[1], SearchOption.AllDirectories);

                                        Console.WriteLine("Список файлов: ");

                                        foreach (string file in allFoundFiles)
                                        {
                                            Console.WriteLine(file);
                                        }

                                        Console.WriteLine("Удалить файлы?");
                                        Console.WriteLine("Если да - введите Y");
                                        Console.WriteLine("Если нет введите N");

                                        string option = Console.ReadLine();

                                        if (option == "Y")
                                        {
                                            foreach (string file1 in allFoundFiles)
                                            {
                                                File.Delete(file1);
                                                Console.WriteLine("Удаление успешно");
                                                Console.ReadKey();
                                                return 0;
                                            }
                                        }
                                        if (option == "N")
                                        {
                                            Console.WriteLine("Вы не захотели удалять файлы. Нажмите кнопку чтобы выйти.");
                                            Console.ReadKey();
                                            return 0;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Директория не существует, либо указана неверно");
                                        Console.ReadKey();
                                        return -1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Введенное вами выражение не соответствует требованиям \n Для дополнительной информации введите help как аргумент");
                                    Console.ReadKey();
                                    return -1;
                                }
                            }
                        }
                    }
                }

            }
            return 0;
        }
    }
}

