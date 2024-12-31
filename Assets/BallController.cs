using UnityEngine;

public class BallController : MonoBehaviour
{
    public PinManager pinManager; // Reference to the PinManager script
    public UnityEngine.UI.Text scoreText; // Assign the Canvas Text component in the Inspector

    private bool hasScored = false; // Prevent scoring multiple times per throw

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin" && !hasScored)
        {
            hasScored = true; // Ensures score is calculated only once per round
            Invoke("CalculateScore", 3f); // Delay to let pins fall
        }
    }

    private void CalculateScore()
    {
        int fallenPins = pinManager.GetFallenPinCount();
        scoreText.text = "Score: " + fallenPins;
        hasScored = false; // Reset for next round


        // Log the score to the Console
        Debug.Log("Score: " + fallenPins);

        hasScored = false; // Reset for next round


    }
}
