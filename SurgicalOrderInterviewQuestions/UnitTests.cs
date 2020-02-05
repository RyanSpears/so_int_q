using NUnit.Framework;

namespace SurgicalOrderInterviewQuestions
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void GetOrderedUniqueNames_ReturnsCorrectNames_InAlphabeticalOrder()
        {
            // Arrange
            var teamOne = new string[] { "Jenny", "Marcus", "Myah", "Yasmeen", "Donny", "Esther" };
            var teamTwo = new string[] { "Donny", "Laurence", "Myrtis", "Eula", "Rubye", "Myah" };

            // Act
            var uniqueOrderedNames = UserNameService.GetOrderedUniqueNames(teamOne, teamTwo);

            // Assert
            Assert.IsNotNull(uniqueOrderedNames);
            Assert.IsAssignableFrom<string[]>(uniqueOrderedNames);
            Assert.That(uniqueOrderedNames.Length, Is.EqualTo(10));
            var answer = new string[] { "Donny", "Esther", "Eula", "Jenny", "Marcus", "Laurence", "Myah", "Myrtis", "Rubye", "Yasmeen" };
            Assert.That(uniqueOrderedNames, Is.EquivalentTo(answer));
        }

        [Test]
        public void GetNthFibonacci_ReturnsCorrectValue_For76thValue()
        {
            // Arrange


            // Act

            // Assert
            Assert.That(MathService.GetNthFibonacci(75), Is.EqualTo(2111485077978050));
        }
    }
}
