
namespace interface_sample{

    public class Volvo : ICar
    {
        public int CountWheel()
        {
            return 4;    
        }

        public string TellBrandName()
        {
            return Brand.Volvo.ToString();
        }

        public string TellColor()
        {
            return Color.White.ToString();

        }
    }
}