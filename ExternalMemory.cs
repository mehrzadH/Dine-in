public class ExternalMemory{

    static int size;
    public static Cell[] Cells;
    public ExternalMemory(int size)
    {
        this.size=size;
        Cells=new Cell[size];
    }

}