using System;
using System.Collections.Generic;
using System.Linq;

namespace Mokykla
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            //List<List<String>> mokiniai = new List<List<string>>();
            //List<String> vardai = new List<String>();
            //List<String> pavardes = new List<String>();
            //List<String> amzius = new List<String>();
            //vardai.Add("Jonas");
            //pavardes.Add("Klausutis");
            //amzius.Add("penkiolika");
            //vardai.Add("Ona");
            //pavardes.Add("Neklausk");
            //amzius.Add("keturiolika");
            //vardai.Add("Albinas");
            //pavardes.Add("Giedorius");
            //amzius.Add("dvylika");

            //mokiniai.Add(vardai);
            //mokiniai.Add(pavardes);
            //mokiniai.Add(amzius);

            List<Students> students = new List<Students>();
            //Students st = new Students();
            //Students st2 = new Students("sd", "sd", 7, new int[] { 5, 2, 8, 6 });

            //students.Add(st);
            //students.Add(st2);

            string[] names = { "Adomas", "Vycka", "Ona", "Joana", "Petras", "Julija" };
            string[] surnames = { "Jonaitis", "Sabaliauskas", "Petraitiene", "Jonaitiene", "Vytautaitis", "Sodininke", "Sabatauskas" };

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Students(names[random.Next(0, names.Length - 1)], surnames[random.Next(0, surnames.Length - 1)], random.Next(18, 60), numArr(3, 14, 1, 10)));
            }
            //Console.WriteLine(students.Count);

            //int[] grades = new int[random.Next(3, 14)];
            //for (int a = 0; a < random.Next(3, 14); a++)
            //    {
            //       grades[a] = random.Next(1, 10);

            //    }

            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i].ToString());
            //}

            //students[5].SetName("Algirdas");
            //students[5].SetSurname("Poleninas");
            //students[5].SetGrades(new int[] { });

            for (int i = 0; i < students.Count; i++)
            {
                for (int a = i + 1; a < students.Count; a++)
                {
                    if (students[a].avg() > students[i].avg())
                    {
                    Students tmp = students[a];
                    students[a] = students[i];
                    students[i] = tmp;
                    }
                }

            }


            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }

        public static int[] numArr(int arrMin, int arrMax, int valMin, int valMax)
        {
            int[] numArr = new int[random.Next(arrMin, arrMax)];
            for (int a = 0; a < numArr.Length; a++)
            {
                numArr[a] = random.Next(valMin, valMax + 1);

            }
            return numArr;
        }

        public static string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }





        //for (int i = 0; i < mokiniai[0].Count; i++)
        //{
        //    for (int z = 0; z < mokiniai.Count; z++)
        //    {
        //        Console.WriteLine(mokiniai[z][i]);
        //        Console.WriteLine("---------");
        //    }
        //}

        //mokiniai[2][1] = "dvidešimt penki";

        //for (int i = 0; i < mokiniai[0].Count; i++)
        //{
        //    for (int z = 0; z < mokiniai.Count; z++)
        //    {
        //        Console.WriteLine(mokiniai[z][i]);
        //        Console.WriteLine("---------");
        //    }
        //}

        //List<int> skaiciai = new List<int> { 1, 5, 6, 10, 9, 14, 52, 87, 14, 3, 7, 114, 4, 2158, 547, 41, 9, 547 };

        //for (int i = 0; i < skaiciai.Count; i++)
        //{
        //    Console.Write(skaiciai[i] + ",");
        //}
        //Console.WriteLine("");
        // paprastas rusiavimas
        //for (int a = 0; a < skaiciai.Count; a++)
        //{

        //    for (int i = 1; i < skaiciai.Count - 1; i++)
        //    {
        //        if (skaiciai[i] > skaiciai[i + 1])
        //        {
        //            int tmp = skaiciai[i];
        //            skaiciai[a] = skaiciai[i + 1];
        //            skaiciai[i + 1] = tmp;
        //        }

        //    }
        //}
        //for (int i = 0; i < skaiciai.Count; i++)
        //{
        //    Console.Write(skaiciai[i] + ",");
        //}

        // bubble rusiavimas

        //int count = 0;
        //for (int a = 0; a < skaiciai.Count; a++)
        //{

        //    for (int i = a + 1; i < skaiciai.Count; i++)
        //    {
        //        count++;
        //        if (skaiciai[a] > skaiciai[i])
        //        {
        //            int tmp = skaiciai[a];
        //            skaiciai[a] = skaiciai[i];
        //            skaiciai[i] = tmp;
        //        }

        //    }
        //}
        //Console.WriteLine(count);
        //string[] tmpArr = vardai.ToArray();


        //Array.Sort(tmpArr, StringComparer.Ordinal);


        //for (int i = 0; i < vardai.Count; i++)
        //{
        //    Console.Write(vardai[i] + ",");
        //}
        //Console.WriteLine("");
    }
        
}
