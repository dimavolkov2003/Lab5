using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Сharacter _character = null;

        public Caretaker(Сharacter character)
        {
            this._character = character;
        }

        public void Backup()
        {
            this._mementos.Add(this._character.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetDate());

            this._character.Restore(memento);

        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetDate());
            }
        }
    }
}
