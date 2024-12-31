using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PinManager pinManager;
    public BallController ballController;

    // Define a starting position for the ball
    public Vector3 ballStartingPosition;

    public void StartNewRound()
    {
        // Set the ball's position to the starting position
        ballController.transform.position = ballStartingPosition;

        // Reset ball's velocity and angular velocity
        ballController.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ballController.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        // Reset pins
        pinManager.ResetPins();
    }
}
