using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: ICharacter
    {

        public string side { get; set; }
        public Knight(string name, string side)
        {
            this.vp = 0;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}