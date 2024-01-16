using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riddles.Models;

namespace Riddles.Tests
{
  [TestClass]
  public class RiddleTests
  {
    
    [TestMethod]
    public void RiddleConstructor_CreateInstanceOfRiddle_Riddle()
    { 
      Riddle newRiddle = new("What has a trunk but no key?", "an elephant");
      Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
    }
    [TestMethod]
    public void RiddleConstructor_GetQuestion_String()
    {
      string question = "What has a trunk but no key?";
      Riddle newRiddle = new(question, "an elephant");
      Assert.AreEqual(question, newRiddle.Question);
    }
    [TestMethod]
    public void RiddleConstructor_SetQuestion_Void()
    {
      string question = "What has a trunk but no key?";
      Riddle newRiddle = new(question, "an elephant");
      string newQuestion = "What is a key but no trunk?";
      newRiddle.Question = newQuestion;
      Assert.AreEqual(newQuestion, newRiddle.Question);
    }
    

    [TestMethod]
    public void RiddleConstructor_GetAnswer_String()
    {
      string question = "What has a trunk but no key?";
      string answer = "an elephant";
      Riddle newRiddle = new(question, answer);
      Assert.AreEqual(question, newRiddle.Question);
    }

    [TestMethod]
    public void RiddleConstruction_SetAnswer_String()
    {
      Riddle newRiddle = new("what's black and white and red all over?", "A newspaper");
      string newAnswer = "A zebra after a tiger attack";
      newRiddle.Answer = newAnswer;
      Assert.AreEqual(newAnswer, newRiddle.Answer);
    }

    [TestMethod]
    public void RiddleConstructor_GetAll_ListRiddle()
    {
      Riddle first = new("What has a trunk but no key?", "elephant");
      Riddle second = new("second riddle question", "second riddle solution");
      Riddle third = new("third riddle question", "third riddle solution");

    }
  }

}