using System;
using System.Collections.Generic;
using System.Text;

namespace Choixfiliere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t Les Options de filière informatique");

            eleves etudiant = new eleves();
            etudiant.TraitementOption();

        }
    }
}
