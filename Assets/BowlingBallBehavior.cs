using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallBehavior : MonoBehaviour
{
    public static int score;
    int totalScore = 10;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitPath")
        {
            AddScore(1);
            Destroy(gameObject, 2.0f);
        }
    }

    void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI(score, totalScore);
    }
    
}
