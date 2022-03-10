namespace tetris.interfaces
{
    public interface ILocations
    {
        int X {get; set;}
        int Y {get; set;}
    }

    public interface ISize
    {
        int SizeX {get; set;}
        int SizeY {get; set;}
    }

    public interface IPrint
    {
        void Print();
    }

    public interface IPrintCell
    {
        void PrintCell(char characther, int xLocation, int yLocation, Grid grid);
    }

    public interface IObjectForm
    {
        char[,] FormObject {get; set;}
    }

    public interface IStartObject
    {
        void Start();
    }

    public interface IUpdateObject
    {
        void Update();
    }

    public interface IClearCells
    {
        void Clear();
    }
}