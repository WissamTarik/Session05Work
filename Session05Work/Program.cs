namespace Session05Work
{
    internal class Program
    {
        #region Video05 Exception Handling and protective code
        //   static void DoSomeCode()
        //{
        //    int X, Y, Z;
        //     X = int.Parse(Console.ReadLine());
        //     Y = int.Parse(Console.ReadLine());
        //    Z = X / Y;
        //    int[] Arr = { 1, 2, 3 };
        //    Arr[99] = 10;
        //}
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Arr = { 1, 2, 3 };
                Arr[99] = 10;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                //Disconnect |Dispose unmanaged resource
            }

        }
        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;
            try
            {
                do
                {
                    Console.Write("Enter first number: ");
                    Flag = int.TryParse(Console.ReadLine(), out X);
                }
                while (!Flag);
                do
                {
                    Console.Write("Enter second number: ");
                    Flag = int.TryParse(Console.ReadLine(), out Y);
                }
                while (!Flag || Y == 0);
                Z = X / Y;
                int[] Arr = { 1, 2, 3 };
                if (99 < Arr?.Length)
                {
                    Arr[99] = 10;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Video01 Boxing And UnBoxing
            //Boxing and unBoxing
            //Boxing:Is casting from VALUE TYPE to REFERENCE TYPE
            //Unboxing:Is casting from REFERENCE TYPE to VALUE TYPE

            //object O1;
            //O1=>can refer to instance of type "Object" or any instance of any datatype

            //O1 = 1;
            //O1 = "Ahmed";
            //O1 = 3;// cast from VALUE TYPE [int] to REFERENCE TYPE[object]=>Boxing
            //O1 = 1.5;//cast from VALUE TYPE [double] to REFERENCE TYPE[object]=>Boxing
            //O1 = 'A'; //cast from VALUE TYPE[char] to REFERNCE TYPE[object]=>Boxing
            //O1 = true;//cast from VALUE TYPE [Bool] to REFERNCE TYPE[Object]=>Boxing
            //O1 = new DateTime();// cast from VALUE TYPE [DateTime] to Reference Type[Object]=>Boxing


            //int X = 5;
            //O1 = /*(object)*/X; //cast from VALUE TYPE[int] to REFERENCE TYPE [object]=>Boxing

            //implicit casting
            //Safe casting
            //Boxing
            //Parent=child=>child is a Parent
            //Animal=Dog=>Dog is an Animal

            //object O1 = 3;
            //int X = (int)O1;// cast from REFERENCE TYPE [object] to VALUE TYPE [int]=>Unboxing

            //Explicit casting
            //Unsafe Casting[May throw exception]
            //Unboxing
            //Dog=(dog)Animal=>Animal is Dog

            #endregion

            #region Video02 NullableValue Type
            //Types of Variables
            //Reference type
            //Value type

            //int X = 10;
            //X = null;//INVALID

            //Nullable value types=> Value types that allow nulls as a valid value
            //Nullable <int>:Allow int Value or null as a valid value
            //int? Age = 20;
            //Age = null;

            //Nullable<double>:Allow double value or null as Valid value
            //double? Salary = 4000.5;
            //Salary = null;

            //int X = 5;

            //Y is Nullable <int>:Allows int or null as a valid value
            //int? Y =/*(int?)*/ X;
            ////Implicit casting
            ////Safe casting
            //Console.WriteLine(Y);


            //X is a nullable <int>:Allows null and int values as a valid values
            //int? X = 5;
            //X = null;
            //Y Allow only to store int values
            //int Y = (int)X;
            //int Y;
            //Explicit casting
            //May  throw exception=> Nullable object must have a value.

            //Defensive code
            //if (X != null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //=======================
            //if (X is not null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //=====================
            //if (X.HasValue)
            //{
            //    Y = X.Value;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //===========================
            //Y = X.HasValue ? X.Value : 0;
            //=============================
            //Y = X is not null ? X.Value : 0;
            //==================================
            //Null coalescing operator??
            //Y = X ?? 0;//Syntax sugar
            //Console.WriteLine(Y);


            #endregion
            #region Video03 Nullable Reference Type
            ////Nullable reference type
            //string Message01 = null;//Required
            //string? Message02 = null;//Optional(Nullable)

            //Console.WriteLine(Message01.Length);//NullReferenceException
            //Console.WriteLine(Message02.Length);//NullReferenceException
            #endregion

            #region Video04 Null Propagation Operator
            //Null propagation operator
            //double X = default;//0
            //Console.WriteLine(X);

            //int[] Arr = default;
            //int[] Arr = { 1, 2, 3 };
            //if (Arr is not null)//Best practice 
            //{
            //    for (int i = 0; i < Arr.Length; i++)//NullReferenceException
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //for (int i = 0;(Arr is not null)&&  i < Arr.Length; i++)//NullReferenceException
            //{
            //    Console.WriteLine(Arr[i]);
            //}


            //for (int i = 0; i < Arr?.Length; i++)//NullReferenceException
            //{
            //    ///ANY Value is greater then null
            //    Console.WriteLine(Arr[i]);
            //}
            //int ?Len = Arr?.Length;
            //int Len = Arr?.Length ?? 0;
            //int Len = Arr?.Length is not null ? Arr.Length : 0;
            //Console.WriteLine(Len);
            #endregion
            #region Video05 Exception Handling and protective code
            //DoSomeCode();
            //DoSomeProtectiveCode();
            //Console.WriteLine("Hello after exception");

            //Exeception
            //1.SystemException
            /*
             1.1 FormatException
             1.2 IndexOutOfRangeException
             1.3 NullReferenceException
             1.4 ArithmeticException
                 1.4.1 OverflowException
                 1.4.2 DivideByZeroException
             */
            //2.ApplicationException
            #endregion

            #region Video06 Access Modifiers
            //Common.TypeA? typeA = new TypeA();//Invalid TypeA is Internal
            //Common.TypeB typeB = new Common.TypeB();//Public TypeB is accessable everywhere
            //typeB.X = 10;//Invalid:Private
            //typeB.Y = 20;//Invalid:internal
            //typeB.Z = 5;//Valid:public
            #endregion

        }
    }
}
