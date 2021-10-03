using System.Collections.Generic;
namespace RoleplayGame
{
    public class Assassin: ICharacter
    {

        public Assassin(string name, string side)
        {
            this.vp = 3;
            this.Name = name;
            this.side = side;
            
            this.AddItem(new DaggerL());
            this.AddItem(new DaggerR());
        }
    }
}