using System;
using Model;

namespace Laba6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = 3, year = 0, month = 0, day = 0;
            Struct[] music = new Struct[3];
            Struct[] musicTmp = new Struct[2];
            Struct d = new Struct();
            Helper helper = new Helper();
            Console.WriteLine("Меню");
            int t = 0;
            do
            {
                Console.WriteLine("1.Показать музыкальные произведения");
                Console.WriteLine("2.Записать в файл");
                Console.WriteLine("3.Отсортировать по исполнителю");
                Console.WriteLine("4.Отсортировать по музыкальному произведению");
                Console.WriteLine("5.Отсортировать по дате");
                Console.WriteLine("6.Отсортировать по рейтингу");
                Console.WriteLine("7.Двадцатка лучших");
                Console.WriteLine("8.Удаление элемента");
                Console.WriteLine("9.Выход");
                t = Int32.Parse(Console.ReadLine());
                switch (t)
                {
                    case 1:
                        helper.CreateArray(music);
                        helper.OutArray(music, n);
                        break;
                    case 2:
                        helper.WriteArray(musicTmp, n);
                        break;
                    case 3:
                        helper.SortNameSinger(music, d);
                        helper.OutArray(music, n);
                        break;
                    case 4:
                        helper.SortNameSong(music, d);
                        helper.OutArray(music, n);
                        break;
                    case 5:
                        helper.SortDay(music, d);
                        helper.SortMonth(music, d);
                        helper.SortYear(music, d);
                        helper.OutArray(music, n);
                        break;
                    case 6:
                        helper.SortRating(music, d);
                        helper.OutArray(music, n);
                        break;
                    case 7:
                        Console.WriteLine("Введите день");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите месяц");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите год");
                        year = Convert.ToInt32(Console.ReadLine());
                        helper.Top3Month(music, n, day, month, year);
                        break;
                    case 8:
                        Console.WriteLine("Какой элемент удалить?");
                        int a = Int32.Parse(Console.ReadLine());
                        helper.DeleteArray(music, musicTmp, a);
                        n = n - 1;
                        helper.OutArray(musicTmp, n);
                        break;
                    case 9:
                        t = 0;
                        break;
                }
            } while (t != 0);
        }
    }
}
