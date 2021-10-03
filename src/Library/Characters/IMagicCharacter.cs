using System.Collections.Generic;
namespace RoleplayGame
{
    public class IMagicCharacter: ICharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        public void AddItem(IMagicalItem magicitem)
        {
            this.magicalItems.Add(magicitem);
        }

        public void RemoveItem(IMagicalItem magicitem)
        {
            this.magicalItems.Remove(magicitem);
        }
    }
}
