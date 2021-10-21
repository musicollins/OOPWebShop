using System;

namespace OOPWebShop.Konsol
{
    public class Airplane
    {
        public string Name { get; set; }
        public int Height { get; private set; }
        public int Angle { get; private set; }
        public int Speed { get; private set; }

        public void UpdateTracker()
        {
            GetNewValues();
            
        }
        private void GetNewValues()
        {
            Random r = new Random();
            Height = r.Next(20, 50);
            Angle = r.Next(220, 350);
            Speed = r.Next(120, 350);
        }


        public override string ToString()
        {
            return $"{Name} | {Height} | {Angle} | {Speed}";
        }

    }
}
