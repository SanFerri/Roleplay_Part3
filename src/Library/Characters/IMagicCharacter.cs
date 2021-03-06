using System.Collections.Generic;
namespace RoleplayGame
{
    /// <summary>
    /// Clase sucesora de Character, pero a su vez base de todas las clases de magos, como wizard, witch y UnDead.
    /// Agregamos los override para asi poder sobre escribir los metodos de attackvalue y defensevalue de Character
    /// ya que se calculan de distinta forma en los personajes magicos.
    /// </summary>
    public class IMagicCharacter: ICharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalItem)
                    {
                        value += (item as IMagicalItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalItem)
                    {
                        value += (item as IMagicalItem).DefenseValue;
                    }
                }
                return value;
            }
        }
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
