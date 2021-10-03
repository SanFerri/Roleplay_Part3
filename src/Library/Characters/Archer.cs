using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: ICharacter
    {
        public Archer(string name, string side)
        {
            this.vp = 0;
            this.Name = name;
            this.side = side;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}