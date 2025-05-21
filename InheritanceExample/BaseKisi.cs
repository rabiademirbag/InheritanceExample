using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class BaseKisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void DisplayNameSurname()
        {
            Console.WriteLine("Ad Soyad: " + Name + " " + Surname);
        }

    }
    public class Ogrenci : BaseKisi
    {
        public string OgrenciNumarasi { get; set; }
 
        public void DisplayOgrenci()
        {
          
            DisplayNameSurname();
            Console.WriteLine("Ogrenci no : " + OgrenciNumarasi);
        }
    }
    public class Ogretmen : BaseKisi
    {
        public decimal Salary { get; set; }

        public void DisplayOgretmen()
        {
            DisplayNameSurname();
            Console.WriteLine("Maas : " + Salary);

        }
    }
}
