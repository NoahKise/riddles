namespace Riddles.Models
{
    public class Riddle
    {
      public string Question {get; set; }
      public string Answer {get; set; }

      private static List<Riddle> _instances = new List<Riddle>{};

      public Riddle(string question, string answer) 
      {
        Question = question;
        Answer = answer;
        _instances.Add(this);
      }
      public static List<Riddle> GetAll()
      {
        return _instances;
      }
    }
}