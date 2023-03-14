using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Country
    {
        public string name { get; set; }
        public string form { get; set; }
        public float square { get; set; }
        public Country(string name, string form, float square)
        {
            name = name;
            form = form;
            square = square;
        }
        public Country()
        {
            name = "Беларусь";
            form = "Любая";
            square = 2222;
        }
        public override string ToString()
        {
            return $"Название: {name} \nФорма: {form} \nПлощадь : {square}";
        }

    }
}