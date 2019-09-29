using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Oldest_Family_Member
{
    public class Program
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var personName = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var newPerson = new Person(personName,age);
                family.AddOlderThan30(newPerson);
            }

            family.ToString();
            


            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

        }
    }
}
