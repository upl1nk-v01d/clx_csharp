namespace Testpaper
{
    public interface ITestpaper 
    {
        string Subject { get; set; }

        string[] MarkScheme { get; set; }
        
        string PassMark { get; set; }
    }

    class Testpaper : ITestpaper
    {
        public string Subject { get; set; }

        public string[] MarkScheme { get; set; }

        public string PassMark { get; set; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; set; }

        //what's the point of method below in this interface?
        void TakeTest(ITestpaper paper, string[] answers) 
        {
            this.TestsTaken = answers ;
        }
    }
    
    class Student : IStudent
    {
        public string[] TestsTaken { get; set; }

        public string[] GetTakenTests(string[] array)
        {
            if(this.TestsTaken == null)
            {
                Console.WriteLine("No tests taken");
            }
            else
            {
                foreach(var test in this.TestsTaken)
                {
                    Console.WriteLine(test);
                }
            }

            return this.TestsTaken;
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int correctAnswers = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == paper.MarkScheme[i])
                {
                    correctAnswers++;
                }
            }

            double score = Convert.ToDouble(correctAnswers) / 
                           Convert.ToDouble(paper.MarkScheme.Length) * 100;

            int markToPass = Convert.ToInt32(paper.PassMark.Replace('%', ' '));

            List<string> list = new List<string>();
            
            if(this.TestsTaken != null)
            {
                foreach(string item in this.TestsTaken)
                {
                    list.Add(item);
                }
            }

            if (score >= markToPass)
            {
                list.Add(paper.Subject + ": Passed! " + score.ToString("0") + "%");
            }
            else
            {
                list.Add(paper.Subject + ": Failed! " + score.ToString("0") + "%");
            }

            this.TestsTaken = list.ToArray();
        }
    }
}
