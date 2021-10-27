namespace FuncOperationsApplication
{
    public class Mounth
    {
        public int Number { get { return Weather.Mounth; } } 
        public float Weight { get;set; } 
        public Weather Weather {get;set;}
        public Mounth(float weight, Weather weather)
        {
            Weight = weight;
            Weather = weather;
        }

    }
}