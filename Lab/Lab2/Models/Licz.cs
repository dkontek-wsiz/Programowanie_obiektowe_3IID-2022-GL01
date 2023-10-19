namespace Lab2.Models
{
    public class Licz
    {
        public int Value;

        public void Dodaj(int add)
        {
            Value += add;
        }

        public void Oddejmnij(int sub)
        {
            Value -= sub;
        }
    }
}
