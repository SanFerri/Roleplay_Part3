using System.Collections.Generic;

namespace RoleplayGame
{
    /// <summary>
    /// Esta clase se usa como un structurer que contiene los personajes, y luego como es la experta en conocer a los
    /// personajes tambien va a asignarlos a cada uno a su grupo de indicado.
    /// Los metodos VilliansHeroes y RemoveDeadCharacters estan en esta clase para cumplir con expert.
    /// </summary>
    public class Characters
    {
        public List<ICharacter> characters = new List<ICharacter>();
        public List<ICharacter> villians = new List<ICharacter>();
        public List<ICharacter> heroes = new List<ICharacter>();

        public void AddCharacter(ICharacter character)
        {
            this.characters.Add(character);
        }
        
        public void RemoveCharacter(ICharacter character)
        {
            this.characters.Remove(character);
        }

        public void VilliansHeroes()
        {
            foreach(ICharacter character in characters)
            {
                if(character.side == "Hero")
                {
                    this.heroes.Add(character);
                }
                else
                {
                    this.villians.Add(character);
                }
            }
        }

        public void RemoveDeadCharacters()
        {
            List<ICharacter> list = new List<ICharacter>();
            List<ICharacter> list2 = new List<ICharacter>();

            foreach(ICharacter hero in this.heroes)
            {
                if(hero.Health > 0)
                {
                    list.Add(hero);
                }
            }

            foreach(ICharacter villian in this.villians)
            {
                if(villian.Health > 0)
                {
                    list2.Add(villian);
                }
            }
            this.heroes = list;
            this.villians = list2;
        }
    }
}