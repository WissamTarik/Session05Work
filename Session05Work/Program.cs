namespace Session05Work
{
    internal class Program
    {
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

        }
    }
}
