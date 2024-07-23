// See https://aka.ms/new-console-template for more information
/*
                -   Main.js    -
function main() {
  for(let n=1; n<=100; n++) {
    if (n % 15 === 0) {
      console.log("fizzbuzz");
    } else if (n % 3 === 0) {
      console.log("fizz");
    } else if (n % 5 === 0) {
      console.log("buzz");
    } else {
      console.log(n);
    }
  }
}

main();
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int n = 1; n <= 100; n++)
        {
            if (n % 15 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else 
            {
                Console.WriteLine(n);
            }
        }
    }
}