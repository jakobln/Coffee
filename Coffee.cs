namespace Coffee
{
    public abstract class Coffee
    {
        public virtual int Price()
        {
            return 20;
        }

        public abstract string Strenght();
        
        public interface IMilk
        {
            int mlMilk { get; }
        }
    }
}