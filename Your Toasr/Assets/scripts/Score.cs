using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public int scoreToWin = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score: " + score);
        if (score >= scoreToWin)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
