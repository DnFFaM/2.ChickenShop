using NUnit.Framework;
namespace MyProject4_NUnitTestProject1
{
    public class FootballTests
    {
        MyLogic_Class1 _football;
        [SetUp]
        public void Setup()
        {
            //Arrange – Arranger.
            _football = new MyLogic_FootBall_Class1();
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIsZero_Shh_Test()
        {
            //Act – Handling.
            var result = _football.HowHappyAreWeAboutThePasses(0);
            //Assert – Påstand.
            Assert.AreEqual("Shh", result);
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIstree_HuhHuhHuh_Test()
        {
            //Act
            var result = _football.HowHappyAreWeAboutThePasses(3);
            //Assert
            Assert.AreEqual("Huh! Huh! Huh!", result);
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassesIsTin_HighFiveJubel_Test()
        {
            var result = _football.HowHappyAreWeAboutThePasses(10);
            Assert.AreEqual("High Five – Jubel!!!", result);
        }
        [Test]
        public void WeCheerIfGoal_GoalIsMåL_OleOleOle_Test()
        {
            var result = _football.WeCheerIfGoal("MåL");
            Assert.AreEqual("Olé olé olé", result);
        }
        [Test]
        public void WeCheerGoalOrPasses_GoalIsmÅl_OleOleOle_Test()
        {
            var result = _football.WeCheerGoalOrPasses("mÅl", 4);
            Assert.AreEqual("Olé olé olé", result);
        }
    }
}