using System;
namespace RoleplayGame
{
    public static class Encounter
    {
        public static void DoEncounter(Characters characters)
        {
            while(characters.villians.Count > 0 && characters.heroes.Count > 0) // No sale del loop hasta que al menos uno de los dos lados quede vacio.
            {
                characters.RemoveDeadCharacters();
                int order = characters.heroes.Count;
                foreach(ICharacter villian in characters.villians) // Recorremos la lista de villanos.
                {
                    if(order > 0) // Verificamos atacar en el orden previsto.
                    {
                        characters.heroes[characters.heroes.Count - order].ReceiveAttack(villian.AttackValue);
                        order -= 1;
                    }
                    else if(order == 0) // Para evitar errores de fuera de index.
                    {
                        characters.heroes[characters.heroes.Count].ReceiveAttack(villian.AttackValue);
                        order -= 1;
                    }
                    else // Cuando ya se halla pasado por toda la lista, si siguen habiendo villanos se atacara devuelta a los primeros en orden.
                    {
                        order = characters.heroes.Count;
                    }
                }

                characters.RemoveDeadCharacters();
                foreach(ICharacter hero in characters.heroes)
                {
                    for(order = 0; order < characters.villians.Count; order++) // Los heroes atacan a todos los enemigos una vez.
                    {
                        characters.villians[order].ReceiveAttack(hero.AttackValue);
                        if(characters.villians[order].Health <= 0)
                        {
                            hero.vp += characters.villians[order].vp;
                        }
                    }
                    if(hero.vp >= 5 && hero.Health > 0) // Si los VP son mayores o iguales a 5 entonces el heroe se cura.
                    {
                        hero.Cure();
                    }
                }
            }
            
            if(characters.heroes.Count > 0) // Dependiendo de que equipo halla perdido se declarara al vencedor como a los heroes o villanos.
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