namespace Physics
{
    public class Energy
    {
        public double v; // скорость может быть меньше нуля
        private double m;

        public double M // а вот для массы следует добавить валидацию, т. к. её минимальное значение - 0
        {
            get { return m; }
            set 
            {
                if(value >= 0)
                { 
                    m = value;
                }
            }
        }

        public Energy(double v, double m)
        {
            this.v = v;
            M = m;
        }

        public double CalcEnergy()
        {
            var e = (m * Math.Pow(v, 2)) / 2;
            return e;
        }
    }
}