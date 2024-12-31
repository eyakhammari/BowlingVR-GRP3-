using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
    public List<GameObject> pins; // Assign pins in the Inspector
    private List<Vector3> initialPositions = new List<Vector3>();
    private List<Quaternion> initialRotations = new List<Quaternion>();

    private void Start()
    {
        // Save initial positions and rotations of pins
        foreach (GameObject pin in pins)
        {
            initialPositions.Add(pin.transform.position);
            initialRotations.Add(pin.transform.rotation);
        }
    }

    public void ResetPins()
    {
        for (int i = 0; i < pins.Count; i++)
        {
            if (pins[i] != null)
            {
                // Reset position and rotation
                pins[i].transform.position = initialPositions[i];
                pins[i].transform.rotation = initialRotations[i];

                // Reset velocity and angular velocity
                Rigidbody rb = pins[i].GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }

    // New method to count fallen pins
    public int GetFallenPinCount()
    {
        int fallenPinCount = 0;

        foreach (GameObject pin in pins)
        {
            if (pin != null)
            {
                Rigidbody rb = pin.GetComponent<Rigidbody>();
                if (rb != null && rb.isKinematic == false)
                {
                    // Check if the pin has fallen
                    if (Vector3.Dot(pin.transform.up, Vector3.up) < 0.5f) // If pin's up vector is not close to global up
                    {
                        fallenPinCount++;
                    }
                }
            }
        }

        return fallenPinCount;
    }
}
