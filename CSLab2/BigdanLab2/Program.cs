using System;

namespace BigdanLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeFrame time1 = TimeFrame.Year;
            Paper[] arr1 = new Paper[15];
            for (int i1 = 0; i1 < arr1.Length; i1++)
                arr1[i1] = new Paper();
            ResearchTeam ob1 = new ResearchTeam("Мат. анализ", "Наука", 291, time1, arr1);
            Console.WriteLine(ob1.ToShortString());
            Console.WriteLine();

            ResearchTeam ob2;
            TimeFrame time2 = TimeFrame.TwoYears;
            Paper[] arr2 = new Paper[10];
            for (int i2 = 0; i2 < arr2.Length; i2++)
                arr2[i2] = new Paper();
            ob2 = new ResearchTeam("Грамматика", "Вече", 504, time2, arr2);
            Console.WriteLine(ob2.ToString());
            Console.WriteLine();

            Paper[] addArr = new Paper[20];
            for (int add = 0; add < addArr.Length; add++)
                addArr[add] = new Paper();
            addArr[5].publicationDate = new DateTime(2015, 1, 3);
            addArr[8].publicationDate = new DateTime(2015, 9, 10);
            addArr[9].publicationDate = new DateTime(2014, 10, 12);
            addArr[10].publicationDate = new DateTime(2015, 1, 28);

            ob1.AddPapers(addArr);

            Paper rezLast;
            rezLast = ob1.last();
            Console.WriteLine("Самая позняя дата: " + Convert.ToString(rezLast.publicationDate));

            int nrow = 1, ncolumn = 1;
            Console.WriteLine("Введите количество строк и столбцов");
            Console.Write("(как разделитель используйте ' ', ',', '.','/'):");
            string variable = Console.ReadLine();
            string[] split = variable.Split(new Char[] { ' ', ',', '.', '/' });
            nrow = Convert.ToInt32(split[0]);
            ncolumn = Convert.ToInt32(split[1]);

            Paper[] oneArr = new Paper[nrow * ncolumn];
            for (int one = 0; one < oneArr.Length; one++)
            { oneArr[one] = new Paper(); }

            Paper[,] twoArr = new Paper[nrow, ncolumn];
            for (int twoR = 0; twoR < nrow; twoR++)
            {
                for (int twoC = 0; twoC < ncolumn; twoC++)
                    twoArr[twoR, twoC] = new Paper();
            }

            Paper[][] stepArr = new Paper[nrow][];
            for (int stepR = 0; stepR < nrow; stepR = stepR + 2)
            {
                stepArr[stepR] = new Paper[ncolumn - 1];
                if (stepR + 1 < nrow)
                    stepArr[stepR + 1] = new Paper[ncolumn + 1];
            }
            if (nrow % 2 == 1)
                Array.Resize(ref stepArr[nrow - 1], ncolumn);

            for (int stepR = 0; stepR < nrow; stepR = stepR + 2)
            {
                int stepC;
                for (stepC = 0; stepC < ncolumn - 1; stepC++)
                    stepArr[stepR][stepC] = new Paper();
                if (stepR + 1 < nrow)
                    for (stepC = 0; stepC < ncolumn + 1; stepC++)
                        stepArr[stepR + 1][stepC] = new Paper();
            }
            if (nrow % 2 == 1)
                stepArr[nrow - 1][ncolumn - 1] = new Paper();

            DateTime a = new DateTime(2016, 11, 28);

            int start1 = Environment.TickCount;
            foreach (Paper i in oneArr)
            { i.publicationDate = a; }
            int duration1 = Environment.TickCount - start1;
            Console.WriteLine("Одномерный: " + duration1 + " ms");
            Console.WriteLine();

            int start2 = Environment.TickCount;
            foreach (Paper element in twoArr)
            {
                element.publicationDate = a;
            }
            int duration2 = Environment.TickCount - start2;
            Console.WriteLine("Двумерный:  " + duration2 + " ms");
            Console.WriteLine();

            int start3 = Environment.TickCount;
            foreach (Paper[] row in stepArr)
            {
                foreach (Paper element in row)
                {
                    element.publicationDate = a;
                }
            }
            int duration3 = Environment.TickCount - start3;
            Console.WriteLine("Ступенчатый:  " + duration3 + " ms");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
