using System.Collections.Generic;
namespace RoleplayGame
{
    public class Witch: IMagicCharacter
    {

        public string side { get; set; }
        public Witch(string name, string side)
        {
            this.vp = 3;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new DestructionOrb());
        }
    }
}