using System.Collections.Generic;
namespace RoleplayGame
{
    public class UnDead: IMagicCharacter
    {
        public string side{ get; set; }
        public UnDead(string name, string side)
        {
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Staff());
        }
    }
}