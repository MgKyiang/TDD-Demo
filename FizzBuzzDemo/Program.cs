using FizzBuzz.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDemo {
    class Program {
        static void Main(string[] args) {
            //looping through from 1 to 100 .
            for(int i = 1; i <= 100; i++) {
                //for the multiples of three print "Fizz" instead of the number 
                //for the multiples of five print "Buzz". 
                //for numbers which are multiples of both three and five print "FizzBuzz".
                Console.WriteLine(FizzBuzzer.getValue(i));
                }
            Console.ReadLine();
            }
        }
    }
