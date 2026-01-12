namespace knightmoves;
public class Counter
{

    
    public void Visitors(){
        int visitors = 100;

        Display("visitors", visitors);
        Display("++visitors", ++visitors);
        Display("visitors", visitors);
        Display("visitors++", visitors++);
        Display("visitors", visitors);
        Display("--visitors", --visitors);
        Display("visitors", visitors);
        Display("visitors--", visitors--);
        Display("visitors", visitors);
    }
    
}
