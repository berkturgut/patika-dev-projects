namespace inheritance;
public class Plants:Creatures
{

    protected void  Photosynthesis(){
    Console.WriteLine("Plants photosynthesize.");
}


//We run this virtual method once. And after that we can modify.
//This is a override method.
//This is a sub class : creatures.
    public override void ReactionBehaviour()
    {
        //base.ReactionBehaviour();
        Console.WriteLine("Plants reaction to the sun.");
    }


}

public class PlantWithSeeds:Plants
{
    public PlantWithSeeds()
    {
        base.Photosynthesis(); // from plants
        base.Feed(); // from creatures. Double level inherit.
    }

      public void  Seeded(){
      Console.WriteLine("plants reproduce by seeds.");
} 
      
}

public class PlantWithoutSeeds:Plants
{
    public void  Seeded(){
    Console.WriteLine("plants reproduce without seeds.");
} 
}