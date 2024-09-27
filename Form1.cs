using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool isXTurn = true;  // True if it's X's turn, false for O's turn
        string[,] board = new string[3, 3];  // 3x3 grid representing the board
        bool gameActive = true;  // Check if the game still active
        int playerXWins = 0;
        int playerOWins = 0;

        public Form1()
        {
            InitializeComponent();

            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            lblStatus.Text = "";
            lblPlayerXScore.Text = "";
            lblPlayerOScore.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (!gameActive) return;

            Button clickedButton = sender as Button;
            int row = clickedButton.Name[3] - '0';  // Extract row index from button name
            int col = clickedButton.Name[4] - '0';  // Extract column index from button name

            // Check the cell if already filled
            if (board[row, col] != null) return;

            // Place X or O in the grid
            board[row, col] = isXTurn ? "X" : "O";
            clickedButton.Text = board[row, col];  // Display X or O on the button

            if (isXTurn)
            {
                clickedButton.ForeColor = Color.Red;  // X is red
            }
            else
            {
                clickedButton.ForeColor = Color.Blue;  // O is blue
            }

            // Check for a win or draw
            if (CheckWin())
            {
                if (isXTurn)
                {
                    lblStatus.Text = "Player X Wins!";
                    playerXWins++;  // Increment Player X's score
                    lblPlayerXScore.Text = $"{playerXWins}";  // Update the label
                }
                else
                {
                    lblStatus.Text = "Player O Wins!";
                    playerOWins++;  // Increment Player O's score
                    lblPlayerOScore.Text = $"{playerOWins}";  // Update the label
                }

                gameActive = false;
            }
            else if (IsBoardFull())
            {
                lblStatus.Text = "Game is a Draw!";
                gameActive = false;
            }
            else
            {
                // Switch turns
                isXTurn = !isXTurn;
                lblStatus.Text = $"Player {(isXTurn ? "X" : "O")}'s Turn";
            }
        }

        // Check if a player has won
        private bool CheckWin()
        {
            // Check rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != null && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] != null && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            if (board[0, 0] != null && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] != null && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }

        // Check if the board is full then it's a draw
        private bool IsBoardFull()
        {
            foreach (var cell in board)
            {
                if (cell == null) return false;
            }
            return true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Clear the board
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = null;
                    Controls[$"btn{row}{col}"].Text = "";
                }
            }

            // Reset game state
            isXTurn = true;
            gameActive = true;
            lblStatus.Text = "Player X's Turn";
        }
    }
}
