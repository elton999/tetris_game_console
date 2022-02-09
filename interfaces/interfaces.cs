namespace tetris.interfaces
{
    public interface ILocations
    {
        int X {get; set;}
        int Y {get; set;}
    }

    public interface IPrint
    {
        void Print();
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
}