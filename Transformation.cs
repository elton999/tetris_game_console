namespace tetris
{
    public class Transformation
    {
        public static char[,] Rotation(char[,] cells, int sizeX, int sizeY)
        {
            char[,] cellsRotated = new char[sizeX, sizeY];
            for(int column = 0; column < sizeX; column++)
            {
                for(int line = 0; line < sizeY; line++)
                {
                    cellsRotated[column, line] = cells[sizeX - 1 - line, column];
                }
            }
            cellsRotated = RemoveVerticalSpaces(cellsRotated, sizeX, sizeY);
            return cellsRotated;
        }

        public static char[,] RemoveVerticalSpaces(char[,] cells, int sizeX, int sizeY)
        {
            char[,] cellsCleaned = new char[sizeX, sizeY];
            int numberOfClear = GetNumberOfClearLinesVertical(cells, sizeX, sizeY);

            for(int column = 0; column < sizeY; column++)
            {
                for(int line = 0; line < sizeY; line++)
                {
                    int lineCurrent = line + numberOfClear;
                    if(line < sizeX - numberOfClear)
                        cellsCleaned[column, line] =  cells[column, lineCurrent];
                    else
                        cellsCleaned[column, line] = '-';
                }
            }

            return cellsCleaned;
        }

        private static int GetNumberOfClearLinesVertical(char[,] cells, int sizeX, int sizeY)
        {
            int numberOfClear = 0;
            for (int line = 0; line < sizeY; line++)
            {
                int cleanCells = 0;
                for (int column = 0; column < sizeX; column++)
                {
                    if (cells[column, line] == '-') cleanCells++;
                }
                if (sizeY == cleanCells) numberOfClear++;
            }
            return numberOfClear;
        }
    }
}