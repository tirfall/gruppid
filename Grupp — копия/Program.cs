using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grupp
{
    public class Program
    {
        public static void Main()
        {


            Console.WriteLine("1.Create group\n2.View group\n3.Delete group\n4.Add name\n5.Delete name");
            int ans = Int32.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    Menufunc.Creup();
                    break;
                case 2:
                    Menufunc.Viup();
                    break;
                case 3:
                    Menufunc.Delup();
                    break;
                case 4:
                    Menufunc.Creup();
                    break;
                case 5:
                    Menufunc.Creup();
                    break;
                case 6:
                    break;
            }
            //Group group = new Group(3);
            
            //group.Name();
            
            //Console.WriteLine(string.Join(", ", group.Members));  
            //Console.WriteLine(group.GetMembersCount());  // 3

            //Group bookClub = new Group(4);
           
            //bookClub.Name();

            //Console.WriteLine(string.Join(", ", bookClub.Members));  

            //Console.WriteLine(bookClub.HasMember("John"));  
        }

    }
}
