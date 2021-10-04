using System.Collections.Generic;
namespace RoleplayGame
{
    /// <summary>
    /// Creamos una clase base Character que tendra como clase sucesora todas aquellas clases que no sean MagicCharacters
    /// de esta forma podemos hacer uso de la reutilizacion, asi no debemos escribir estos metodos o propiedades en cada
    /// una de dichas clases sucesoras. Es una clase abstracta ya que el calculo de los valores de ataque y defensa
    /// cambian en la clase sucesora MagicCharacter.
    /// </summary>
    public abstract class ICharacter 
    {
        public string side { get; set; }
        public int vp {get; set;}
        protected int health = 100;

        protected List<IItem> items = new List<IItem>();
        public string Name { get; set; }
        
        public virtual int AttackValue
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
                return value;
            }
        }

        public virtual int DefenseValue
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
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public virtual void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public virtual void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}