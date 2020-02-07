using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.NET, DATAADAPTER

using System.Collections; // List of Object
using System.Collections.Generic; // List<int> 

namespace LoopsAssignment
{
    class UserInfo
    {
        public string name;
        public string userId;
    }
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrMyInfo = new ArrayList();
            List<int> myNumbers = new List<int>();
            Random myRandom = new Random();

            for (int i = 0; i < 100; i++)
            {
                int newNbr = myRandom.Next(0,100);
                arrMyInfo.Add(newNbr);
                myNumbers.Add(newNbr);
            }

            Console.WriteLine("ArrayList contains " + arrMyInfo.Count + " items");
            Console.WriteLine("List<int> contains " + myNumbers.Count + " items");


            int lowerLimit = 70;
            int upperLimit = 100;

            // find all elements between 70 and 100
            var query = from nbr in myNumbers
                        where nbr > lowerLimit && nbr < upperLimit
                        select nbr;

            int count = 0;
            Console.WriteLine("Printing results from query");
            // print all values that where returned
            foreach (int element in query)
            {
                Console.Write(element.ToString() + " ");
                if (count == 10)
                {
                    count = 0;
                    Console.Write("\n");
                }
                else
                    count++;
            }

            Console.Write("\n");
            Console.ReadKey();

            List<string> myNames = new List<string>();
            myNames.Add("Ryan");
            myNames.Add("Kenn");
            myNames.Add("Harry");
            myNames.Add("Mark");

           // get names which contain a letter 'a'
            var query1 = from name in myNames
                        where name.IndexOf('a') > -1
                        select name;

            foreach (string name in query1)
                Console.WriteLine(name);

            Console.ReadKey();

            // get names that start with K
            var query2 = from name in myNames
                         where name.StartsWith("K")
                         select name;

            foreach (string name in query2)
                Console.WriteLine(name);

            Console.ReadKey();

            // REAL USAGE
            List < UserInfo > myUsers = new List<UserInfo>();
            // Loading data into my list
            UserInfo felipe = new UserInfo();
            felipe.name = "Felipe";
            felipe.userId = "213213";

            myUsers.Add(felipe);

            Console.ReadKey();
        }
    }
}
