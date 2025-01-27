	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
            //Numeric data type
            int age = -23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000000F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            
            Console.ReadLine(); 

            //Text based data type            
            string name = "Deepak Sharma";
			char letter = 'a';

			Console.Write("My Name is ");
			Console.write(name);
			Console.WriteLine();
			Console.WriteLine(letter);  

			Console.ReadLine();   

			//Covertig string to number
			string textAge = "-23";
			int age = Convert.ToInt32(textAge);
			Console.WriteLine(age);

			string textBigNumber = "-900000000";
			long bigNumber = Convert.ToInt64(textBigNumber);
			Console.WriteLine(bigNumber);

			string textNegative = "-55.3";
			double negative = Convert.ToDouble(textNegative);
			Console.WriteLine(negative);

			string textPrecision = "5.000001";
			float precision=Convert.ToSingle(textPrecision);
			Console.WriteLine(precision);

			string textMoney = "14.99";
			decimal money = Convert.ToDecimal(textMoney);
			Console.WriteLine(money);

			Console.ReadLine();

			// Boolean data type
			bool value= true;

			bool isMale= true;
			Console.WriteLine(isMale);

			isMale= false;
			Console.WriteLine(isMale);

			Console.ReadLine();
        	
        	//Operators = - * /
			double age = 23;
			age /= 10;
			Console.WriteLine(age);

			string name = "Deepak";
			name += " is programming!";

			char ch = 'a';
			ch += 'b';
			Console.WriteLine(ch);
			Console.WriteLine(name);

			int i = 0;
			Console.WriteLine(++i);
			Console.WriteLine(i);
			Console.ReadLine();

        	//Remainder
			int firstNum = 11;
			int secondNum = 2;
			Console.WriteLine(firstNum % secondNum);
			Console.WriteLine(1000 % 90);
			Console.WriteLine(100 % 90);
			Console.WriteLine(71 % 10);
			Console.ReadLine();
        	
        	//var keyward
			//int age = -23;
			var age = 23;
			Console.WriteLine(age);

			//long bigNumber = -900000000L;
			var bigNumber = 90000000000000000L;
			Console.WriteLine(bigNumber);

			//double negative = -55.2D;
			var negative = -55.2D;
			Console.WriteLine(negative);

			//float precision = 5.000000F;
			var precision = 5.000000F;
			Console.WriteLine(precision);

			//decimal money = 14.99M;
			var money = 14.99M;
			Console.WriteLine(money); 

			Console.ReadLine();

			//const keyward
			const int vat = 20;
			const double percentVAT = vat / 100D;
			int balance = 1000;

			Console.WriteLine(balance * (vat / 100D));
			Console.WriteLine(balance * percentVAT);

			const string version = "v1.0";
			Console.WriteLine(vat);
			         
			Console.ReadLine();
        }
    }
}
