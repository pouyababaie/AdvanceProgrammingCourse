namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Eneter a Number \n");
            string input1 = Console.ReadLine();

            Console.WriteLine("Eneter a Number \n");
            string input2 = Console.ReadLine();

            int input1Number = int.Parse(input1);

            int input2Number = int.Parse(input2);


            Console.WriteLine("Wich Operator are you using ?");
            Console.WriteLine("1) Change Variable With Temporary Variable");
            Console.WriteLine("2) Change Variable With XOR");
            Console.WriteLine("3) Change Variable With Arithmetic");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ChangeVariableWithTempVariable(input1Number, input2Number);
                    break;

                case "2":
                    ChangeVariableWithXOR(input1Number, input2Number);

                    break;

                case "3":
                    ChangeVariableWithArithmetic(input1Number, input2Number);
                    break;
            }
        }



        public static void ChangeVariableWithTempVariable(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Value of the A : {a} \n");
            Console.WriteLine($"Value of the B : {b}");
        }

        public static void ChangeVariableWithXOR(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Value of the A : {a} \n");
            Console.WriteLine($"Value of the B : {b}");
        }

        public static void ChangeVariableWithArithmetic(int a, int b)
        {

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"Value of the A : {a} \n");
            Console.WriteLine($"Value of the B : {b}");
        }

    }
}
