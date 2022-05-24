using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Person
    {

        public Person (string name,string surname,int age)
        {
            IsAdult = true;
            Name = name;
            SurName = surname;
            Age = age;

            if (Age < 18)
            {
                Console.WriteLine(IsAdult = false);
            }
            else
            {
                Console.WriteLine(IsAdult);
            }
        }
        
        public string Name;
        public string SurName;
        public int  Age;
        public bool IsAdult;
    
    
    
      
    }

    





}




