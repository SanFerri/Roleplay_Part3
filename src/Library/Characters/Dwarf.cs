using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: ICharacter
    {

        public Dwarf(string name, string side)
        {
            this.vp = 0;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}