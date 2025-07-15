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
        }
    }
}
