using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BoardManager boardManager; // Reference to the BoardManager

    private int currentPlayer; // 0 for Player 1, 1 for Player 2
    private bool isGameActive;

    void Start()
    {
        currentPlayer = 0; // Player 1 starts
        isGameActive = true;
        // Initialize the BoardManager
        boardManager.InitializeBoard();
    }

    // Call this method to handle a player's turn
    public void PlayerTurn(int pitIndex)
    {
        if (!isGameActive) return;

        // Check if the selected pit belongs to the current player
        if (!IsValidPitSelection(pitIndex)) return;

        // Code to handle the player's selection and move seeds
        // This will involve calling the BoardManager's SelectPit method and any additional game logic

        // Check if the game has ended after the move
        if (CheckGameOver())
        {
            isGameActive = false;
            EndGame();
            return;
        }

        // Switch to the next player
        SwitchPlayer();
    }

    private bool IsValidPitSelection(int pitIndex)
    {
        // Logic to determine if the selected pit is valid for the current player
        // For example, players can only select pits on their side of the board
        return true; // Placeholder, implement proper validation
    }

    private bool CheckGameOver()
    {
        // Implement logic to determine if the game has ended
        // Typically, this could be when one side of the board is empty
        return false; // Placeholder
    }

    private void EndGame()
    {
        // Code to handle the end of the game, like calculating scores and declaring a winner
    }

    private void SwitchPlayer()
    {
        currentPlayer = 1 - currentPlayer; // Toggles between 0 and 1
    }
}
