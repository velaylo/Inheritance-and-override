using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text value: ");
            string text = Console.ReadLine();
            FirstClass firstClass = new FirstClass(text);
            firstClass.ShowClassName();

            Console.WriteLine();

            Console.Write("Enter integer value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            SecondClass secondClass = new SecondClass(text, number);
            secondClass.ShowClassName();

            Console.WriteLine();
           
            Console.Write("Enter character value: ");
            char symbol = Convert.ToChar(Console.ReadLine()); 
            ThirdClass thirdClass = new ThirdClass(text, symbol);
            thirdClass.ShowClassName();

            Console.WriteLine();

            firstClass = secondClass;
            firstClass.ShowClassName();
            firstClass = thirdClass;
            firstClass.ShowClassName();
            
            Console.ReadKey();
        }
    }

    class FirstClass
    {
        protected string text = " ";

        public FirstClass(string text)
        {
            this.text = text;
        }

        public virtual void ShowClassName()
        {
            Console.WriteLine($"Name class is FirstClass and its fields: {text}");
        }
    }

    class SecondClass : FirstClass
    {
        protected int number = 0;

        public override void ShowClassName()
        {
            Console.WriteLine($"Name class is SecondClass and its fields: {text},{number}");
        }

        public SecondClass(string text,int number) : base(text)
        {
            this.number = number;
        }
    }

    class ThirdClass: FirstClass
    {
        protected char symbol = ' ';

        public override void ShowClassName()
        {
            Console.WriteLine($"Name class is ThirdClass and its fields: {text}, {symbol}");
        }        

        public ThirdClass(string text, char symbol) : base(text)
        {
            this.symbol = symbol;
        }

    }
}
