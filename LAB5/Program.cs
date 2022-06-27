
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Artifact> artifacts = new List<Artifact> { new Gun("AK-47", 100) };

            Сharacter character = new Сharacter(100, (0,0), artifacts);
            Caretaker caretaker = new Caretaker(character);

            caretaker.Backup();
            character.Regeneration();

            caretaker.Backup();
            character.Regeneration();

            caretaker.Backup();
            character.Regeneration();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
        }
    
    }
}
