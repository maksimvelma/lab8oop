using System;
using System.IO;
using System.Text;

namespace project
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
            try
            {
                if (DIR.Exists)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Папка OOP_lab08 вже iснує на диску D \n Видалiть ii пiсля чoго нажмiть ENTER.");
                    
                    
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
                    Console.WriteLine("3) Каталоги : Reports, Sources, Texts були скопiйованi в каталозi : Velma \n");
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
                    string pathX = @"D:\OOP_lab08\f.file";
                    int currentDigit = 0,
                    numberDigitsSum = 0,
                    numberDigitsProduct = 1;
                    string numberInStringRepresentation = String.Empty;
                    int sum = 0;
                    using (StreamWriter sw1 =  new StreamWriter(pathX))
                    {
                        var rand = new Random();
                        for (int ctr = 0; ctr <= 19; ctr++)
                        {
                            sw1.WriteLine(rand.Next(101));
                            sum += rand.Next(101);
                            
                        }

                    }

                        numberInStringRepresentation = sum.ToString();
                   
                        for (int i = 0; i < numberInStringRepresentation.Length; i++)
                        {
                            currentDigit = (int)Char.GetNumericValue(numberInStringRepresentation[i]);
                            numberDigitsSum += currentDigit;
                            numberDigitsProduct *= currentDigit;
                        }
                        double snumber = Math.Sqrt(sum);
                        var nums = File.ReadAllText(@"D:\OOP_lab08\f.file").Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x.Replace(",", ".")));
                        var sumAbs = Math.Abs(nums.Sum());
                        var squareProduct = Math.Pow(nums.Aggregate((a, b) => a * b), 2);
                        var lastnumber = nums.Last();
                        Console.WriteLine("1.2) Файл f.file був створений в : " + pathX + "\n");
                        Console.WriteLine("1) сума компонентiв файла f : " + sum);
                        Console.WriteLine("1) Сума цифр числа "  + sum + " : "  + numberDigitsSum);
                        Console.WriteLine("2) добуток компонентiв числа:" + numberDigitsProduct);
                        Console.WriteLine("3) сума квадратів компонентiв файла f : " + snumber);
                        Console.WriteLine("4) модуль суми i квадрат добутку компоненту файла f : " + squareProduct);
                        Console.WriteLine("5) останнiй компонент файла f : " + lastnumber);
                        
                        Console.ReadKey(true);

                       
                   // File.Create(pathX);
               
                }
            }
            catch (Exception e) { 
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Знайдена помилка => \n");
                Console.WriteLine(e.ToString());
            }
        }

    }
}