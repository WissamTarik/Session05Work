namespace Assignment
{

    #region Part01


    #region Video07 Enum Ex:01
    enum SeasonDemo : byte
    {
        Winter = 10,
        Spring = 9,
        Summer = 11,
        Autumn
    }
    enum Weekday
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    enum Gender
    {
        Male = 0,
        Female = 1,
        M = 0,
        F = 1,
    }
    #endregion

    #region  Video08 Enum Ex:02
    //Read,write,execute,delete

    [Flags]
    enum PermissionsDemo
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }
    #endregion
    #endregion
    #region Part02
    #region Q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    #endregion


    #region Q2
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter,
    }
    #endregion

    #region Q3
     enum Permissions
    {
        Read,
        Write,
        Delete,
        Execute
    }
    #endregion

    #region Q4
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    #endregion
    internal class Program
    {

        #region Q1 Part01 Video05 Exception Handling and protective code

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

            #region Part01
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
            #region Video07 Enum EX:01
            //Enum:Value types
            //Stored in STACK 
            //used with constant values
            //SeasonDemo season = SeasonDemo.Summer;
            // Console.WriteLine(season);
            //STACK
            //CLR Represent enum as Integer value  in memory
            //Gender G = (Gender)1;
            //Gender G = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);
            //Gender G01;
            //bool Flag = Enum.TryParse(typeof(Gender), Console.ReadLine(),true,out object O1);
            //G01 = (Gender)O1;
            //Console.WriteLine(G01);
            #endregion

            #region Video08 Enum Ex:02
            //PermissionsDemo P01 = PermissionsDemo.Read;
            ////P01 ^= PermissionsDemo.Delete;//toggle
            //P01 |= PermissionsDemo.Delete;

            //Console.WriteLine(P01);
            //Console.WriteLine((int)P01);
            //P01 &= ~(PermissionsDemo.Delete);//Remove permission
            //~ not of bit wise 
            //&->check permission

            //Console.WriteLine(P01);
            //if ((P01 & PermissionsDemo.Delete) == PermissionsDemo.Delete)
            //{
            //    Console.WriteLine("Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Not exist");
            //}
            #endregion
            #endregion
            #region Part02
            #region Q1
            /*
             
            1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday)
            as its members. Then, write a C# program that prints
             out all the days of the week using this enum.

             */

            //foreach (string item in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2

            /*
             2.	Create an enum called "Season" with the four seasons 
            (Spring, Summer, Autumn, Winter) as its members. Write a
            C# program that takes a season name as input from the user
            and displays the corresponding month range for that season.
            Note range for seasons ( spring march to may , summer june to august ,
            autumn September to November , winter December to February)
             */
            //Season season;
            //object O1;
            //bool Flag;
            //do
            //{
            //    Console.Write("Enter the season (Spring, Summer, Autumn, Winter): ");
            //    Flag = Enum.TryParse(typeof(Season), Console.ReadLine(), true,out  O1);

            //}

            //while (!Flag);
            //season = (Season)O1;
            //if (season == Season.Spring)
            //{
            //    Console.WriteLine("spring march to may");
            //}
            //else if (season == Season.Summer)
            //{
            //    Console.WriteLine("summer june to august");

            //}
            //else if (season == Season.Autumn)
            //{
            //    Console.WriteLine("autumn September to November");

            //}
            //else
            //{
            //    Console.WriteLine("winter December to February");
            //}
            #endregion
            #region Q3
            /*
            3- Assign the following Permissions (Read, write, Delete, Execute) 
            in a form of Enum.Create Variable from previous Enum to Add
            and Remove Permission from variable, check if specific Permission
            is existed inside variable

             */
            //Permissions P01 = Permissions.Read;
            //P01 ^= Permissions.Write;
            //Console.WriteLine("Toggle write permission");
            //Console.WriteLine(P01);
            //P01 ^= Permissions.Write;
            //Console.WriteLine(P01);
            //Console.WriteLine("============================");
            //Console.WriteLine("Add permission Delete");
            //P01 |= Permissions.Delete;
            //Console.WriteLine(P01);
            //Console.WriteLine("============================");
            //Console.WriteLine("Remove permission Delete");
            //P01 &= ~(Permissions.Delete);
            //Console.WriteLine(P01);
            //Console.WriteLine("=================================");
            //Console.WriteLine($"Available permissions: {P01}");
            //if ((P01 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Permission delete exist");
            //}
            //else
            //{
            //    Console.WriteLine("Permission delete isn't exist");
            //}
            //P01 |= Permissions.Delete;

            //Console.WriteLine($"Available permissions: {P01}");
            //if ((P01 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Permission delete exist");
            //}
            //else
            //{
            //    Console.WriteLine("Permission delete isn't exist");
            //}
            #endregion

            #region Q4
            /*
             5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            Write a C# program that takes a color name as input from the user and 
            displays a message indicating whether the input color is a primary color or not.
             */
            //Console.Write("Enter your color: ");
            //bool Flag = Enum.TryParse(typeof(Colors), Console.ReadLine(),true, out object O1);
            //if (Flag)
            //{
            //    Console.WriteLine("Yes its Primary color:)");
            //}
            //else
            //{
            //    Console.WriteLine("No it isn't primary color ):");
            //}

            #endregion
            #endregion
        }
    }
}
