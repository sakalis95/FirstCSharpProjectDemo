using System;
using System.Linq;

namespace Functions
{
    class Program
    {

        ////00. INTRODUCTION
        //static void Main(string[] args)
        //{
        //    PrintSth();
        //    int result = Add(1, 2);
        //    Console.WriteLine(Add(1));
        //    Console.WriteLine(result);
        //    Add(new int[]{ 1, 2, 3, 4});

        //}



        //// void - kazka turi returnint
        //// char - turi returninti char
        ////byte - skaiciukas
        //static char PrintSth() //signature / header
        //{

        //    //funkcija turi kazka grazinti
        //    Console.WriteLine("Hello World!");
        //    return 'a';
        //    int result = Add(1, 2);
        //    Console.WriteLine(result);
        //    return '5';
        //}



        //static int Add(int i, int j)
        //{
        //    return i + j;

        //}

        ////overloadinta f-ja - tas pats pavadinimas, bet kazkas vidjue skiriasi
        //static int Add(int i)
        //{
        //    return i;
        //}

        //static int Add(int[] arr)
        //{
        //    return arr[0];
        //}




        // 1. Reference vs value types


        // int, doiuuble, struct

        //static void Main(string[] args)
        //{
        //    int age = 15;
        //    Console.WriteLine($"Before the method: {age}");
        //    MyMethod(age);
        //    Console.WriteLine($"After the method: {age}");
        //}

        //static void MyMethod(int age)
        //{
        //    Console.WriteLine($"Inside the method: {age}");
        //    age++;
        //    Console.WriteLine($"Inside the method: {age}");
        //}


        //static void Main(string[] args)
        //{
        //    string name = "Jonas";
        //    Console.WriteLine($"Before the method: { name }");
        //    MyMethod(name);
        //    Console.WriteLine($"After the method: { name }");
        //}

        //static void MyMethod(string name)
        //{
        //    Console.WriteLine($"Inside the method: { name }");
        //    name += 5;
        //    Console.WriteLine($"Inside the method: { name }");
        //}



        ////naudojame ref (passing by refference)

        //static void Main(string[] args)
        //{
        //    int age = 15;
        //    Console.WriteLine($"Before the method: {age}");
        //    int ret = MyMethod(ref age);
        //    Console.WriteLine($"After the method: {ret} : {age} ");
        //}

        //static int MyMethod(ref int age)
        //{
        //    Console.WriteLine($"Inside the method: {age}");
        //    age++;
        //    Console.WriteLine($"Inside the method: {age}");
        //    return age + 5;
        //}




        //static void Main(string[] args)
        //{
        //    string name = "Jonas";
        //    Console.WriteLine($"Before the method: { name }");
        //    MyMethod(ref name);
        //    Console.WriteLine($"After the method: { name }");
        //}

        //static void MyMethod(ref string name)
        //{
        //    Console.WriteLine($"Inside the method: { name }");
        //    name += 5;
        //    Console.WriteLine($"Inside the method: { name }");
        //}


        //varargs/params - variable args

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Add(1, 2));
        //}

        //static int Add(int[] arr)
        //{
        //    return arr[0];
        //}

        // params galima ivesti tik viena, tik paskutini
        //static int Add(params int[] arr)
        //{
        //    return arr.Sum();
        //}




        //// C# optional parameters
        //// You can use that in order to put default value
        //static void Main(string[] args)
        // default parametras turi buti gale funcijos aprasyme
        //{

        //    SayHi("Mantas");
        //    SayHi();
        //}

        //static void SayHi (string name = "Jonas")
        //{
        //    Console.WriteLine($"Hi {name}!");
        //}







        ////named arguments

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Subtract(1, 2));
        //    //named arguments:
        //    Console.WriteLine(Subtract(j : 1, i : 2));
        //    // unrecomended
        //    Console.WriteLine(Subtract(i: 2, 2));
        //    // Console.WriteLine(Subtract(j: 2, 2)); //negalime, pozicija ne ta
        //    // Console.WriteLine(Subtract(2, i: 2)); //negalime,  pozicija ne ta
        //}

        //static int Subtract(int i, int j)
        //{
        //   return i - j;
        //}






        ////expression body syntax
        //// kaip arrow f-jos, tik single line

        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine(Add(1, 2));
        //        Console.WriteLine(Add(1.0, 2.0));

        //    }

        //    static int Add(int i, int j)
        //    {
        //        return i + j;
        //    }

        //    static double Add(double d1, double d2) => d1 + d2;

        //}


        public static void Main(string[] args)
        {
            //IllustrateForEach();
            IllustarteBinarySearch();
        }

        static void IllustrateForEach()
        {
            string[] myArr1 = { "Big", "brown", "Fox", "Ace" };
            Array.ForEach(myArr1, word =>
            { Console.Write(word.ToUpper() + ", ");
            }); 
            Console.WriteLine(string.Join(", ", myArr1)); 
        }
    
        static void IllustarteBinarySearch ()
        {
            string[] myArr1 = { "The", "brown", "Fox", "Ace" };

            Console.WriteLine("Before sorting: " + string.Join(", ", myArr1));
            Array.Sort(myArr1);
            Console.WriteLine("After sorting: " + string.Join(", ", myArr1));

            int idx = Array.BinarySearch(myArr1, "Brown"); //case sensitive!
            Console.WriteLine(idx > 0 ? myArr1[idx] : "sorry, not found");
        }

    } }
