using System;
namespace RoleplayGame
{
    public static class Encounter
    {
        public static void DoEncounter(Characters characters)
        {
            while(characters.villians.Count > 0 && characters.heroes.Count > 0)
            {
                characters.RemoveDeadCharacters();
                int order = characters.heroes.Count - 1;
                foreach(ICharacter villian in characters.villians)
                {
                    if(order > 0)
                    {
                        characters.heroes[characters.heroes.Count - order].ReceiveAttack(villian.AttackValue);
                        order -= 1;
                    }
                    else if(order == 0)
                    {
                        characters.heroes[order].ReceiveAttack(villian.AttackValue);
                        order -= 1;
                    }
                    else
                    {
                        order += 1;
                        characters.heroes[order].ReceiveAttack(villian.AttackValue);
                    }
                }

                characters.RemoveDeadCharacters();
                foreach(ICharacter hero in characters.heroes)
                {
                    for(order = 0; order < characters.villians.Count; order++)
                    {
                        characters.villians[order].ReceiveAttack(hero.AttackValue);
                        if(characters.villians[order].Health <= 0)
                        {
                            hero.vp += characters.villians[order].vp;
                        }
                    }
                    if(hero.vp >= 5 && hero.Health > 0)
                    {
                        hero.Cure();
                    }
                }
            }
            if(characters.heroes.Count > 0)
            {
                Console.WriteLine("The heroes won!");
            }
            else
            {
                Console.WriteLine("The villians won!");
            }
        }
    }
}