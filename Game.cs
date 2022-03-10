namespace tetris
{
    public class Game
    {
        public Grid Grid;
        public GridEfx GridEfx;
        public PieceManager PieceManager;
        public PieceMovement PieceMovement;
        public UI UI;

        public void Start()
        {
            Grid = new Grid(10, 20);
            Grid.Print();
            GridEfx = new GridEfx(Grid);

            UI = new UI(Grid);
            
            PieceMovement = new PieceMovement(Grid);
            PieceManager = new PieceManager(Grid, UI);
        }

        public void Update()
        {
            Grid.Lines.CheckLinesComplete(UI);

            Input.Instance.Update();
            
            PieceManager.CurrentPiece.PieceMovement = PieceMovement;
            PieceManager.Update();
            GridEfx.Update();
        }

        public void Print()
        {
            Grid.Print();
            GridEfx.Print();
            PieceManager.Print();
            UI.Print();
        }
    }
}