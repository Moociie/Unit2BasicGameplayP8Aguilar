using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 0;


    // Start is called before the first frame update
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Lives = " + lives);
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
