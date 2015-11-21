using System;

namespace BigdanLab2
{
    class ResearchTeam
    {
        
        private string theme;
        private string organization;
        private int number;
        private TimeFrame duration;
        private Paper[] paper;

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public TimeFrame Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public Paper[] Paper
        {
            get { return paper; }
            set { paper = value; }
        }

        public ResearchTeam(string myTheme, string myOrganization, int myNumber, TimeFrame myDuration)
        {
            theme = myTheme;
            organization = myOrganization;
            number = myNumber;
            duration = myDuration;
            paper = new Paper[0];
        }

        public ResearchTeam(string myTheme, string myOrganization, int myNumber, TimeFrame myDuration, Paper[] myPaper)
        {
            theme = myTheme;
            organization = myOrganization;
            number = myNumber;
            duration = myDuration;
            paper = myPaper;
        }

        public Paper last()
        {
            if (paper.Length == 0)
            {
                return null;
            }
            else
            {
                int a = 0;
                DateTime last = paper[0].publicationDate;
                for (int i = 0; i < paper.Length; i++)
                {
                    if (last < paper[i].publicationDate)
                    {
                        last = paper[i].publicationDate;
                        a = i;
                    }
                }

                return paper[a];
            }
        }

        public void AddPapers(params Paper[] arr)
        {
            int L = paper.Length;
            Array.Resize(ref paper, paper.Length + arr.Length);

            for (int i = L; i < paper.Length; i++)
            {
                int j = 0;
                paper[i] = arr[j];
                j++;
            }
        }

        public override string ToString()
        {
            return theme + "\n " + organization + "\n " + number + "\n " + duration + "\n " + String.Join(" ", paper[paper.Length - 1]);
        }

        public virtual string ToShortString()
        {
            return theme + "\n " + organization + "\n " + number + "\n " + duration;
        }
    }
}
