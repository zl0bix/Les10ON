using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
//Выделяем область и жмем Ctrl+K, а затем Ctrl+C.
//Обратное раскомментирование - Ctrl-K, а затем Ctrl-U.
namespace Les10ON
{

    internal class Program
    {

        class God
        {
           public class Piple
            {
               public string FIO;
               public string work;
               public Piple(string FIO , string work )
                {
                    this.FIO = FIO;
                    this.work = work;
                }
               public Piple()
                {
                    this.FIO = "Ivanov";
                    this.work = "Pirat";
                }
                public Piple(Piple pip)
                {
                    this.FIO = pip.FIO;     
                    this.work = pip.work;
                }

            };
            /*public God(Piple  pl) 
            {
            this._list.Add( pl );
            }*/
            List<Piple> _list = new List<Piple>();
            //void SetFIO(int index)                        
            //void SetWork(int index)
            public void AddPiple(string FIO,string work)
            {  
                this._list.Add(new Piple (FIO, work));              
            }
            string GetFIO(int index)
            {
                return _list[index].FIO;
            }
            string GetWork(int index)
            {
                return _list[index].work;
            }
            public void ShowData()
            {
                for(int i = 0; i < _list.Count; i++) 
                {                   
                    Console.WriteLine("\n\tАнкета номер " + (i + 1) + "\nЗвать - " + _list[i].FIO + "\nДолжность - " + _list[i].work + "\n");
                }
            }
            public void ShowSingle(int num)
            {               
                    Console.WriteLine("\n\tФамилия: " + _list[num].FIO + " должность: " + _list[num].work);                             
            }


            public int SearchFIO(string FIO)
            {
                for (int i = 0; i < _list.Count; i++)
                {
                    if (FIO == _list[i].FIO)
                        return i;
                }
                Console.WriteLine("\n\tError!");
                return -1;
                
            }
            public int SearchWorc(string work)
            {
                for(int i = 0; i < _list.Count;i++)
                {
                    if(work == _list[i].work)
                        return i;
                }
                Console.WriteLine("\n\tError!");
                return -1;               
            }

            public void DelPiple(int num)
            {
                for(int i = 0; i < _list.Count; ++i)
                {
                    if(i == num)
                    {
                        _list.RemoveAt(i);
                    }
                   // else Console.WriteLine("\n\tПлохой выбор");
                }
            }
        }

        static void Main(string[] args)
        {
            //const uint rows = 8;
            //const uint cols = 5;
            //int[,] matrix = new int[rows, cols];
            //int[] arr = new int[rows * cols];

            //matrix.Initialize();

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //string str = "The vector is extended by inserting new elements before the element at the specified position, effectively increasing the container size by" +
            //    " the number of elements inserted.\r\n\r\nThis causes an automatic " +
            //    "reallocation of the allocated storage space if -and only if- the new vector size surpasses the current vector capacity.\r\n\r\n" +
            //    "Because vectors use an array as their underlying storage, inserting elements in positions " +
            //    "other than the vector end causes the container to relocate all the elements that were after position to their new positions." +
            //    " This is generally an inefficient operation compared to the one performed for the same operation " +
            //    "by other kinds of sequence containers (such as list or forward_list).";

            //string[] lineArr = str.Split(' ');

            //foreach (string line in lineArr)
            //{
            //    Console.Write(line + "\t");
            //}
            //Написать конвертер валют(3 валюты).У пользователя есть баланс в каждой из представленных валют. Он может попросить сконвертировать часть 
            //баланса с одной валюты в другую.Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.Курс конвертации должен 
            //быть просто прописан в программе. По имени переменной курса конвертации должно быть понятно, из какой валюты в какую валюту конвертируется. 
            //Программа должна завершиться тогда, когда это решит пользователь.

            //int n1= 100000;
            //int n2 = 0;
            //int n3 =0;
            //Console.WriteLine("Enter action -> ");


            //     uint Dol;
            //     uint Eur;
            //     uint Exit;
            //int num = 0;
            //num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        {
            //            Console.Write("Цена за 1 $ = 100 рубликов\nУ вас " + n1/100 + " рублей  " + n1%100 + " копеек \nСколь ко баксов хотите купить -> ");

            //            int tmp = Convert.ToInt32(Console.ReadLine());

            //            if ((n1 - tmp * 1000) < 0)
            //            {
            //                Console.WriteLine("Много хочешь)");
            //                break;
            //            }

            //            n1 = n1 - tmp * 10000;
            //            n2 = n2 + tmp;
            //            Console.WriteLine("\nУ вас "+ n1 / 100 + " рублей  " + n1 % 100 + " копеек\nу вас "+ n2 +" долларов\nу вас "+ n3+" евро");
            //            break;
            //        }

            //}
            const int addPiple = 1, showPiples = 2, searchPiple =3 ,  delPiple = 4, logOut = 5;
            string FIO, work;
            God human = new God();                        
            int num = 0;
            while (num!=logOut)
            {
                Console.Write("\n\n\n\t1:Добавить данные\n\t2:Показать список\n\t3:Пойск\n\t4:Удалить сотрудника\n\t5:Выход из программы\n\tВыбери действие: ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case addPiple:
                    {
                            Console.Write("\n\tВведите ФИО сотрудника -> ");
                            FIO = Console.ReadLine();
                            Console.Write("\tВведите должность сотрудника -> ");
                            work = Console.ReadLine();
                            human.AddPiple(FIO,work);
                            Console.Clear();
                            break;
                    }
                        case showPiples:
                        {
                            Console.WriteLine();
                            human.ShowData();
                            Console.ReadKey();
                            Console.Clear();
                            break;                          
                        }
                        case searchPiple:
                        {
                            Console.Write("\t1:Пойск по ФИО:\n\t2:Пойск по должности:\n\tВыбери действие: ");
                            int numTmp = Convert.ToInt32(Console.ReadLine());
                            string strTmp = "";
                            if (numTmp == 1) 
                            {
                                Console.Write("\tВведите ФИО для пойска -> ");
                                strTmp = Console.ReadLine();
                                human.ShowSingle(human.SearchFIO(strTmp));
                            }
                            else if (numTmp == 2)
                            {
                                Console.Write("\tВведите должность для пойска -> ");
                                strTmp = Console.ReadLine();
                                human.ShowSingle(human.SearchWorc(strTmp));
                            }
                            else { Console.WriteLine("\tError enter!!!"); }
                            break;
                        }
                    case logOut:
                        break;

                    case delPiple:
                        Console.WriteLine();
                        human.ShowData();                      
                        Console.Write("Выбери номер сотрудника для удаления -> ");
                        num = Convert.ToInt32(Console.ReadLine());
                        human.DelPiple(num - 1);
                        Console.WriteLine();
                        human.ShowData();
                        Console.ReadKey();
                        num = 0;
                        break;

                       
                }
            }

           



        }
    }
}
