namespace Coffee
{
    public class BlackCoffee : Coffee
    {
        public override int Price()
        {
            return 20;
        }

        public override string Strenght()
        {
            return "Strong";
        }

        public override string ToString()
        {
            return Strenght();
        }
    }
}