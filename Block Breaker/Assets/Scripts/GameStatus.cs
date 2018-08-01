using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {
    //params
    [Range(0.1f , 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 69;

    //state
    [SerializeField] int currScore = 0;


	public void AddToScore()
    {
        currScore += pointsPerBlock;
    }
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = gameSpeed;
	}
}
