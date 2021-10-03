using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: IMagicCharacter
    {

        public Wizard(string name, string side)
        {
            this.vp = 3;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Staff());
        }
    }
}