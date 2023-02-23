
namespace interface_sample{

    public class Renault : ICar
    {
        public int CountWheel()
        {
            return 4;    
        }

        public string TellBrandName()
        {
            return Brand.Renault.ToString();
        }

        public string TellColor()
        {
            return Color.Gray.ToString();

        }
    }
}