using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int points;

    public static GameManager S;
    
    // Start is called before the first frame update
    void Awake()
    {
        S = this;
    }

    private void Start()
    {
        lives = 4;
    }

    public void LoseLife()
    {
        lives -= 1;
    }

    public void AddPoint(int numPoints)
    {
        points += numPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
