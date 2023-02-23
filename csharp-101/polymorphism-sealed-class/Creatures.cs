namespace inheritance;
//public sealed class Creatures : you can't use inheritance anymore with sealed.

public class Creatures
{

protected void Feed(){
    Console.WriteLine("Creatures feed.");
}

public void aspiration(){
    Console.WriteLine("Creatures aspirate.");
}

public void excretion(){
    Console.WriteLine("Creatures excrete.");
}

//This is a virtual method and we can use sub class with override method. Also we can change the content.
public virtual void ReactionBehaviour()
{
    Console.WriteLine("Creatures reaction to the event.");
}

}