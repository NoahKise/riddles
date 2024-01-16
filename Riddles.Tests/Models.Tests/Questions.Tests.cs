using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riddles.Models;

namespace Riddles.Tests
{
  [TestClass]
  public class QuestionTests
  {
    [TestMethod]
    public void QuestionConstructor_CreateInstanceOfQuestion_Question()
    { 
      QuestionAndAnswer newQuestionAndAnswer = new QuestionAndAnswer();
      Assert.AreEqual(typeof(QuestionAndAnswer), newQuestionAndAnswer.GetType());
    }
  }

}