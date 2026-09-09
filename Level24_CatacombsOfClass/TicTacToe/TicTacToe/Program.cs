TicTacToe Game = new TicTacToe();
Game.run();

// main setup
public class TicTacToe
{
    Board board = new Board();
    DrawBoard dBoard = new DrawBoard();
    Player player1 = new Player();
    Player player2 = new Player();
    

    public void run()
    {
        int turnCount = 0;
        Player currentPlayer = player1;
        Cell currentSymbol = Cell.X;

        while (turnCount < 9)
        {
            // Draw/Update the board
            dBoard.Draw(board);
            // Inform which player's turn
            Console.WriteLine($"{currentSymbol} turn");
            // Player input their choices
            currentPlayer.Choice(board, currentSymbol);
            turnCount++;

            // Check if any player won
            if (WinCon(board, currentSymbol) == true)
            {
                Console.WriteLine($"{currentSymbol} Won");
                break;
            }
            else if (turnCount == 9)
            {
                Console.WriteLine("Draw");
                break;
            }

            // if the current player is player1 change it to player2, 
            // if the current player is not player1 change to player1
            currentPlayer = (currentPlayer == player1) ? player2 : player1;
            currentSymbol = (currentSymbol == Cell.X) ? Cell.O : Cell.X;
        }
        // Show the board result when the game ends
        dBoard.Draw(board);
    }

    bool WinCon(Board board, Cell state)
    {
        // Check for rows match
        // Check for Top row on numpad (7, 8, 9)
        if (board.Contents(0, 0) == state && board.Contents(0, 1) == state && board.Contents(0, 2) == state) return true;
        if (board.Contents(1, 0) == state && board.Contents(1, 1) == state && board.Contents(1, 2) == state) return true;
        if (board.Contents(2, 0) == state && board.Contents(2, 1) == state && board.Contents(2, 2) == state) return true;

        // Check for column match
        if (board.Contents(0, 0) == state && board.Contents(1, 0) == state && board.Contents(2, 0) == state) return true;
        if (board.Contents(0, 1) == state && board.Contents(1, 1) == state && board.Contents(2, 1) == state) return true;
        if (board.Contents(0, 2) == state && board.Contents(1, 2) == state && board.Contents(2, 2) == state) return true;

        // Check for diagonal
        if (board.Contents(0, 0) == state && board.Contents(1, 1) == state && board.Contents(2, 2) == state) return true;
        if (board.Contents(0, 2) == state && board.Contents(1, 1) == state && board.Contents(2, 0) == state) return true;

        return false;
    }
}

// Player
public class Player
{
    int row;
    int col;
    // player picks a spot on the board 
    public void Choice(Board board, Cell state)
    {
        bool ValidMove = false;

        // Loop until a valid choice is made
        while (!ValidMove)
        {
            Console.WriteLine("Pick a number following the numpad grid");
            int key = Convert.ToInt32(Console.ReadLine());

            // Set the cell state based on the user input and current symbol
            switch (key)
            {
                case 1:
                    row = 2;col = 0;
                    break;
                case 2:
                    row = 2;col = 1;
                    break;
                case 3:
                    row = 2;col = 2;
                    break;
                case 4:
                    row = 1;col = 0;
                    break;
                case 5:
                    row = 1;col = 1;
                    break;
                case 6:
                    row = 1;col = 2;
                    break;
                case 7:
                    row = 0;col = 0;
                    break;
                case 8:
                    row = 0;col = 1;
                    break;
                case 9:
                    row = 0;col = 2;
                    break;
                default:
                    Console.WriteLine("Input a valid number");
                    continue;
            }
            // check with the board if its empty
            // if empty send it to draw the output
            if (board.IsEmpty(row, col) == true)
            {
                board.Place(row, col, state);
                ValidMove = true;
            }
            else
            {
                Console.WriteLine("The square is occupied. Try again.");
            }
        }
    }
}

// Board, basically empty needs to be called to have something
public class Board
{
    // Set a 3x3 grid
    Cell[,] cell = new Cell[3,3];
    
    // Set the said cell to said cell state
    public void Place(int row, int col, Cell state) => cell[row, col] = state;

    // Check the contents of the cell (Empty, O, X)
    public Cell Contents(int row, int col) => cell[row, col];
    
    public bool IsEmpty(int row, int col)
    {
        if (Contents(row, col) == Cell.Empty)
        {
            return true;
        }
        else  
        {
            return false;
        }
    }
    
}


class DrawBoard
{
    char[,] symbol = new char[3, 3];

    // Convert the contents to displayable characters
    char Symbols(Cell state)
    {
        switch (state)
        {
            case Cell.Empty:
                return ' ';
            case Cell.O:
                return 'O';
            case Cell.X:
                return 'X';
            default:
                return 'E';
        }
    }

    // Draw the board when it is called
    public void Draw(Board boardcopy)
    {
        symbol[0, 0] = Symbols(boardcopy.Contents(0, 0));
        symbol[0, 1] = Symbols(boardcopy.Contents(0, 1));
        symbol[0, 2] = Symbols(boardcopy.Contents(0, 2));
        symbol[1, 0] = Symbols(boardcopy.Contents(1, 0));
        symbol[1, 1] = Symbols(boardcopy.Contents(1, 1));
        symbol[1, 2] = Symbols(boardcopy.Contents(1, 2));
        symbol[2, 0] = Symbols(boardcopy.Contents(2, 0));
        symbol[2, 1] = Symbols(boardcopy.Contents(2, 1));
        symbol[2, 2] = Symbols(boardcopy.Contents(2, 2));

        Console.WriteLine($" {symbol[0, 0]} | {symbol[0, 1]} | {symbol[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {symbol[1, 0]} | {symbol[1, 1]} | {symbol[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {symbol[2, 0]} | {symbol[2, 1]} | {symbol[2, 2]} ");
    }
}

public enum Cell { Empty, X, O}