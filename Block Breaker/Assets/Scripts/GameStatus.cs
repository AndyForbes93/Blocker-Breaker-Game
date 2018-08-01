using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameStatus : MonoBehaviour {
	//params
	[Range(0.1f , 3f)] [SerializeField] float gameSpeed = 1f;
	[SerializeField] int pointsPerBlock = 69;
	[SerializeField] Text scoreText;

	//state
	[SerializeField] int currScore = 0;

	public void Awake()
	{
		int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

		if(gameStatusCount > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}


	//displayin starting score 
	public void Start()
	{
		scoreText.text = "Score: " + currScore.ToString(); 
		
	}

	//adde=s broken blocks to score and displays
	public void AddToScore()
	{
		currScore += pointsPerBlock;
		scoreText.text = "Score: " + currScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = gameSpeed;
	}
}
