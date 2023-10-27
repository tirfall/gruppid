using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp
{
    public class Menufunc
    {
        public List<string> groups { get; } = new List<string>();
        public static void Creup()
        {
            Console.WriteLine("Gruppi suures:");
            int grusize = Int32.Parse(Console.ReadLine());
            Group gruname = new Group(grusize);
        }
        public static void Viup() 
        { 
            
        }
        public static void Delup() 
        { 
            
        }
        public static void Addname() 
        { 
        
        }
        public static void delname() 
        { 
        
        }
    }
}
