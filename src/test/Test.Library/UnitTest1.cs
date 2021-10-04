using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        public SpellsBook book = new SpellsBook();

        public IMagicCharacter Gandalf = new Wizard("Gandalf", "Hero");
        public ICharacter Gimli = new Dwarf("Gimli", "Hero");
        public ICharacter Zelda = new Archer("Zelda", "Hero");
        public ICharacter Saga = new Knight("Saga", "Hero");

        public IMagicCharacter Overlord = new UnDead("Overlord","Villian");
        public IMagicCharacter BabaYaga = new Witch("BabaYaga", "Villian");
        public ICharacter MaskedMan = new Assassin("MaskedMan", "Villian");
        public ICharacter WhiteBeard = new Pirate("WhiteBeard", "Villian");

        public Characters characters = new Characters();


        [Test]
        public CureTest
        {
            int expected = 100;
            Overlord.ReceiveAttack(30);
            Overlord.Cure();
            int actual = Overlord.health;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public TestReceiveAttack
        {
            int expected = 70;
            Overlord.ReceiveAttack(30)
            int actual = Overlord.health;
            Assert.AreEqual(expected, actual);
        }
    }
}