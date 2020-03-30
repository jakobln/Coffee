namespace Coffee
{
    public class Cortado : Coffee
    {
        public override int Price()
        {
            return 25;
        }

        public override string Strenght()
        {
            return "Medium";
        }

        public override string ToString()
        {
            return Strenght();
        }


        /*public override IMilk
        {

        }*/
    }
}