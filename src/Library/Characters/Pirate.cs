using System.Collections.Generic;
namespace RoleplayGame
{
    public class Pirate: ICharacter
    {

        public string side { get; set; }
        public Pirate(string name, string side)
        {
            this.vp = 3;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Hook());
            this.AddItem(new Sword());
            this.AddItem(new Cloak());
        }
    }
}