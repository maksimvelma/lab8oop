using System;
using System.IO;
using System.Text;

namespace lab8
{

    class Program
    {
        static void Main(string[] args)
        {
        l1:


            Console.WriteLine("Нажмiть на клавiшу ENTER щоб почати процес.");
            Console.ReadLine();
            DirectoryInfo DIR = new DirectoryInfo(@"D:\OOP_lab08");
            string mainpath = @"D:\OOP_lab08";
            

                if (DIR.Exists)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Папка вже iснує");


                    goto l1;


                }
                else
                {
                    // 1)
                    DIR.Create();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1) Папка : " + "OOP_lab08" + " була створена в - " + DIR + "\n");
                    //2)
                    DirectoryInfo DIR1 = new DirectoryInfo(DIR + "/KN1-B20");
                    DirectoryInfo DIR2 = new DirectoryInfo(DIR + "/Reports");
                    DirectoryInfo DIR3 = new DirectoryInfo(DIR + "/Sources");
                    DirectoryInfo DIR4 = new DirectoryInfo(DIR + "/Texts");
                    DirectoryInfo DIR5 = new DirectoryInfo(DIR + "/Velma");

                    DIR1.Create();
                    DIR2.Create();
                    DIR3.Create();
                    DIR4.Create();
                    DIR5.Create();
                    Console.WriteLine("2) Були створенi 5 папок в папцi : " + DIR + "\n" + DIR1 + "\n" + DIR2 + "\n" + DIR3 + "\n" + DIR4 + "\n" + DIR5 + "\n");

                    //3)
                    string filepaths = @"D:\OOP_lab08\Velma\Reports";
                    string filepaths1 = @"D:\OOP_lab08\Velma\Sources";
                    string filepaths2 = @"D:\OOP_lab08\Velma\Texts";
                    System.IO.Directory.CreateDirectory(filepaths);
                    System.IO.Directory.CreateDirectory(filepaths1);
                    System.IO.Directory.CreateDirectory(filepaths2);
                    Console.WriteLine("3) Каталоги : Reports, Sources, Texts були скопiйованш в каталог : Velma \n");
                    //4)
                    string filepaths3 = @"D:\OOP_lab08\KN1-B20\Velma";
                    DIR5.MoveTo(filepaths3);
                    Console.WriteLine("4) Каталог : Velma був перенесений в каталог KN1-B20. \n");
                    //5) 
                    string txtfile = filepaths3 + "/Texts/dirinfo.txt";
                    var fileinfo = new FileInfo(filepaths3 + "/Texts");
                    using (StreamWriter sw = new StreamWriter(txtfile))
                    {

                        sw.WriteLine(fileinfo);

                    }
                    Console.WriteLine("5) В каталозi Texts був створений файл dirinfo.txt, який має iнформацiю про каталог Texts\n");
                    Console.ReadLine();
                }

            }
    }
    }
