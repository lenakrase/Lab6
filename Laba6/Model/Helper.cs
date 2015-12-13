using System;
using System.IO;

namespace Model
{
    public class Helper
    {
        public void CreateArray(Struct[] music)
        {
            FileStream file = new FileStream("C:\\file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            for (int i = 0; i < 3; i++)
            {
                music[i].NameSinger = reader.ReadLine();
                music[i].NameSong = reader.ReadLine();
                music[i].DateDay = Convert.ToInt32(reader.ReadLine());
                music[i].DateMonth = Convert.ToInt32(reader.ReadLine());
                music[i].DateYear = Convert.ToInt32(reader.ReadLine());
                music[i].Rating = Convert.ToInt32(reader.ReadLine());
            }
            reader.Close();
        }

        public void OutArray(Struct[] music, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(music[i].NameSinger);
                Console.WriteLine(music[i].NameSong);
                Console.WriteLine("{0}.{1}.{2}", music[i].DateDay, music[i].DateMonth, music[i].DateYear);
                Console.WriteLine(music[i].Rating);
            }
        }
        public void DeleteArray(Struct[] music, Struct[] musicTmp, int a)
        {
            for (int i = 0, c = 0; i < 3 && c < 2; i++, c++)
            {
                if (a == i)
                {
                    i++;
                }
                musicTmp[c] = music[i];
            }
        }

        public void WriteArray(Struct[] music, int n)
        {
            FileStream file1 = new FileStream("C:\\file1.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(file1);
            for (int i = 0; i < n; i++)
            {
                writer.WriteLine(music[i].NameSinger);
                writer.WriteLine(music[i].NameSong);
                writer.WriteLine(music[i].DateDay);
                writer.WriteLine(music[i].DateMonth);
                writer.WriteLine(music[i].DateYear);
                writer.WriteLine(music[i].Rating);
            }
            writer.Close();
        }

        public void SortNameSinger(Struct[] music, Struct d)
        {
            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (string.Compare(music[i].NameSinger, music[i + 1].NameSinger) == 1)
                {

                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }
        public void SortNameSong(Struct[] music, Struct d)
        {

            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (string.Compare(music[i].NameSong, music[i + 1].NameSong) == 1)
                {
                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }

        public void SortDay(Struct[] music, Struct d)
        {
            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (music[i].DateDay > music[i + 1].DateDay)
                {
                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }
        public void SortMonth(Struct[] music, Struct d)
        {

            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (music[i].DateMonth > music[i + 1].DateMonth)
                {
                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }
        public void SortYear(Struct[] music, Struct d)
        {

            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (music[i].DateYear > music[i + 1].DateYear)
                {
                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }
        public void SortRating(Struct[] music, Struct d)
        {
            for (int i = 0; i < 2; i++)
            {
                int flag = 0;
                if (music[i].Rating > music[i + 1].Rating)
                {
                    d = music[i];
                    music[i] = music[i + 1];
                    music[i + 1] = d;
                    flag = 1;
                }
                if (flag == 1)
                {
                    i = -1;
                }
            }
        }
        public void Top3Month(Struct[] music, int n, int day, int month, int year)
        {
            int days = 0, month1 = 0;
            month1 = month - 3;
            if (month1 < 0)
            {
                month1 += 12;
                year -= 1;
            }
            for (int i = 0; i < n; i++)
            {
                if ((music[i].DateMonth < month1) && (music[i].DateDay < day) && (music[i].DateYear <= year) && (music[i].Rating < 20))
                {
                    Console.WriteLine(music[i].NameSinger);
                    Console.WriteLine(music[i].NameSong);
                    Console.WriteLine("{0}.{1}.{2}", music[i].DateDay, music[i].DateMonth, music[i].DateYear);
                    Console.WriteLine(music[i].Rating);
                }
            }
        }
    }
}
