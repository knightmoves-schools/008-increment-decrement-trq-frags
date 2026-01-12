namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    public int PrefixIncrement { get; private set; }
    public int PostfixIncrement { get; private set; }
    public int PrefixDecrement { get; private set; }
    public int PostfixDecrement { get; private set; }

    public Counter()
    {
        PrefixIncrement = ++Visitors;
        PostfixIncrement = Visitors++;
        PrefixDecrement = --Visitors;
        PostfixDecrement = Visitors--;
    }
}
