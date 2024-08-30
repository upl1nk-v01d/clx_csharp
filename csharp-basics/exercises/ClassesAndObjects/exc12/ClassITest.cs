using Testpaper;

namespace Testpaper
{

    public interface ITestpaper 
    {
        string Subject { get; set; }
        string[] MarkScheme { get; set; }
        string PassMark { get; set; }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; set; }

        void TakeTest(ITestpaper paper, string[] answers)
        {
            this.TestsTaken[TestsTaken.Length-1] = {paper, answers};
        }
    }
    
    class Student : IStudent
    {
        public string[] TestsTaken { get; set; }

        public Student()
        {
            if(this.TestsTaken == null)
            {
                Console.WriteLine("No tests taken");
            }
            else
            {

            }
        }
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
}
