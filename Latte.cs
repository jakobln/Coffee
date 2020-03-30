namespace Coffee
{
    public class Latte : Coffee
    {
        public override int Price()
        {
            return 40;
        }

        public override string Strenght()
        {
            return "Weak";
        }

        public override string ToString()
        {
            return Strenght();
        }

        public int mlMilk(int ml)
        {
            return 200;
        }
    }
}