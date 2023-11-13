using UnityEngine;

public class BoardManager : MonoBehaviour
{
    // Assuming a standard Congklak board with 7 pits per side and 1 store (house) for each player.
    private const int PitsPerSide = 7;
    private const int TotalPits = PitsPerSide * 2 + 2; // Including two stores
    private int[] seedsInPits = new int[TotalPits]; // Array to store the number of seeds in each pit

    // Initialize with a standard number of seeds per pit, except stores which start empty.
    private const int InitialSeedsPerPit = 7;

    void Start()
    {
        //InitializeBoard();
    }

    public void InitializeBoard()
    {
        // Initialize seeds for all pits except stores
        for (int i = 0; i < TotalPits; i++)
        {
            if (i == PitsPerSide || i == TotalPits - 1) // Skip the stores
            {
                seedsInPits[i] = 0;
            }
            else
            {
                seedsInPits[i] = InitialSeedsPerPit;
            }
        }

        // Optionally, update the visual representation of the board here.
        UpdateBoardVisuals();
    }

    void UpdateBoardVisuals()
    {
        // Code to update the board's visual representation goes here.
        // This can involve updating the number of seed models in each pit, etc.
    }

    // Method to handle player interactions, e.g., when a player selects a pit.
    public void SelectPit(int pitIndex)
    {
        // Validation to ensure a valid pit is selected
        if (pitIndex < 0 || pitIndex >= TotalPits) return;

        // Additional logic to handle the selection of the pit
        // and distributing the seeds according to the game rules.

        // After updating the game state, update the board visuals
        UpdateBoardVisuals();
    }
}
