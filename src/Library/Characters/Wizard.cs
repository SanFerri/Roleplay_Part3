using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: IMagicCharacter
    {
        public string side{ get; set; }
        public Wizard(string name, string side)
        {
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Staff());
        }
    }
}