using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            IMagicCharacter gandalf = new Wizard("Gandalf", "Hero");
            gandalf.AddItem(book);

            ICharacter gimli = new Dwarf("Gimli", "Hero");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");
        }
    }
}
