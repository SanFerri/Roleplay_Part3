namespace RoleplayGame
{
    public abstract class IMagicalItem
    {
        public virtual int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public virtual int DefenseValue
        {
            get
            {
                return 100;
            }
        } 
    }
}