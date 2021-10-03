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

            IMagicCharacter Gandalf = new Wizard("Gandalf", "Hero");
            Gandalf.AddItem(book);
            ICharacter Gimli = new Dwarf("Gimli", "Hero");
            ICharacter Zelda = new Archer("Zelda", "Hero");
            ICharacter Saga = new Knight("Saga", "Hero");

            IMagicCharacter Overlord = new UnDead("Overlord","Villian");
            IMagicCharacter BabaYaga = new Witch("BabaYaga", "Villian");
            ICharacter MaskedMan = new Assassin("MaskedMan", "Villian");
            ICharacter WhiteBeard = new Pirate("WhiteBeard", "Villian");

            Characters characters = new Characters();

            characters.AddCharacter(Gimli);
            characters.AddCharacter(Gandalf);
            characters.AddCharacter(Zelda);
            characters.AddCharacter(Saga);

            characters.AddCharacter(Overlord);
            characters.AddCharacter(BabaYaga);
            characters.AddCharacter(MaskedMan);
            characters.AddCharacter(WhiteBeard);

            characters.VilliansHeroes();

            Encounter.DoEncounter(characters);
        }
    }
}
