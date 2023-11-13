using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameManager gameManager; // Reference to the GameManager

    void Update()
    {
        HandlePlayerInput();
    }

    private void HandlePlayerInput()
    {
        // Check for player input (e.g., mouse click or touch)
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Assuming each pit is a GameObject with a collider
                // Check if the hit object is a pit
                if (hit.collider.gameObject.CompareTag("Pit"))
                {
                    // Retrieve the index or identifier of the pit
                    int pitIndex = GetPitIndex(hit.collider.gameObject);

                    // Pass the selected pit index to the GameManager
                    gameManager.PlayerTurn(pitIndex);
                }
            }
        }
    }

    private int GetPitIndex(GameObject pitObject)
    {
        // Implement logic to determine the index of the pit based on the hit GameObject
        // This index should correspond to the pit's position on the board
        return 0; // Placeholder, replace with actual logic
    }
}
