using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: ICharacter
    {
        public string side{ get; set; }
        public Archer(string name, string side)
        {
            this.Name = name;
            this.side = side;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}