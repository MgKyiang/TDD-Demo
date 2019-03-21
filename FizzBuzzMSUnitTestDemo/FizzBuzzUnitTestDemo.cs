using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Lib;
using System.Collections.Generic;

namespace FizzBuzzMSUnitTestDemo {
    [TestClass]
    public class FizzBuzzUnitTestDemo {

        [TestMethod]
        public void Buzzer_WhenDefault_ReturnInt() {
            //Arrange
            List<int> mydata = new List<int>();
            mydata.Add(1);
            mydata.Add(2);
            mydata.Add(4);
            mydata.Add(7);
            mydata.Add(8);
            mydata.Add(11);
            mydata.Add(13);
            mydata.Add(14);
            mydata.Add(16);
            mydata.Add(17);
            mydata.Add(19);
            foreach(int input in mydata) {
                //Action
                string output = FizzBuzzer.getValue(input);
                //Assert
                Assert.AreEqual(input.ToString(), output);
                }           
            }

        [TestMethod]
        public void Buzzer_WhenMultiply3_ReturnFizz() {
            //Arrange
            List<int> mydata = new List<int>();
            mydata.Add(3);
            mydata.Add(6);
            mydata.Add(9);
            mydata.Add(12);
            mydata.Add(18);
            foreach (int input in mydata) {
                //Action
                string output = FizzBuzzer.getValue(input);
                //Assert
                Assert.AreEqual(input.ToString(), output);
                }
            }

        [TestMethod]
        public void Buzzer_WhenMultiply5_ReturnBuzz() {
            //Arrange
            List<int> mydata = new List<int>();
            mydata.Add(5);
            mydata.Add(10);
            mydata.Add(20);
          
            foreach (int input in mydata) {
                //Action
                string output = FizzBuzzer.getValue(input);
                //Assert
                Assert.AreEqual(input.ToString(), output);
                }
            }
        }
    }
