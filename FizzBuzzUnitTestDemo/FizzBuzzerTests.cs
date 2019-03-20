using FizzBuzz.Lib;
using NUnit.Framework;

namespace FizzBuzzUnitTestDemo
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnInt([Values(1,2,4,7,8,11,13,14,16,17,19)]int input) {
            //Action
            string output = FizzBuzzer.getValue(input);
            Assert.AreEqual(input.ToString(), output);
            }

        [Test]
        public void Buzzer_WhenMultiply3_ReturnFizz([Values(3,6,9,12,18)]int input) {
            //Action
            string output = FizzBuzzer.getValue(input);
            Assert.AreEqual(input.ToString(), output);
            }

        [Test]
        public void Buzzer_WhenMultiply5_ReturnBuzz([Values(5,10,20)]int input) {
            //Action
            string output = FizzBuzzer.getValue(input);
            Assert.AreEqual(input.ToString(), output);
            }
        }
}
