namespace Assignment
{
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

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Season season;
            object O1;
            bool Flag;
            do
            {
                Console.Write("Enter the season (Spring, Summer, Autumn, Winter): ");
                Flag = Enum.TryParse(typeof(Season), Console.ReadLine(), true,out  O1);
              
            }

            while (!Flag);
            season = (Season)O1;
            if (season == Season.Spring)
            {
                Console.WriteLine("spring march to may");
            }
            else if (season == Season.Summer)
            {
                Console.WriteLine("summer june to august");

            }
            else if (season == Season.Autumn)
            {
                Console.WriteLine("autumn September to November");

            }
            else
            {
                Console.WriteLine("winter December to February");
            }
            #endregion


            #endregion
        }
    }
}
