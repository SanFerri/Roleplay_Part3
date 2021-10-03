using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
        public SpellsBook book = new SpellsBook();
        public book.Spells = new Spell[]{ new Spell() };

        public Wizard gandalf = new Wizard("Gandalf");
        public gandalf.Staff = new Staff();
        public gandalf.SpellsBook = book;

        public Dwarf gimli = new Dwarf("Gimli");
        public gimli.Axe = new Axe();
        public gimli.Helmet = new Helmet();
        }
    }
}