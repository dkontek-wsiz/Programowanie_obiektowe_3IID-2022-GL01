namespace Lab2.Models
{
    public class Licz
    {
        private int _value;

        public Licz(int value)
        {
            _value = value;
        }

        public void Dodaj(int add)
        {
            _value += add;
        }

        public void Oddejmnij(int sub)
        {
            _value -= sub;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
