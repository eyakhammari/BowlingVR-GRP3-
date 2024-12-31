using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Corrected capitalization for GetMouseButtonUp
        if (Input.GetMouseButtonUp(0)) 
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
