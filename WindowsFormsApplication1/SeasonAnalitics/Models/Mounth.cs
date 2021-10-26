namespace FuncOperationsApplication
{
    public class Mounth
    {
        public int Number { get; set; } 
        public float Weight { get;set; } 
        public Weather Weather {get;set;}
        public Mounth( float weight, Weather weather)
        {
            Number = weather.Mounth;
            Weight = weight;
            Weather = weather;
        }

    }
}