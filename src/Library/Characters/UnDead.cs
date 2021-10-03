using System.Collections.Generic;
namespace RoleplayGame
{
    public class UnDead: IMagicCharacter
    {

        public UnDead(string name, string side)
        {
            this.vp = 3;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Staff());
        }
    }
}