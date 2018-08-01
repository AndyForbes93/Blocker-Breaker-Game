using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAgain : MonoBehaviour {

	[SerializeField] int breakableBlocks;

	//cached reference
	SceneLoader sceneLoader;

	private void Start()
	{
		sceneLoader = FindObjectOfType<SceneLoader>();
	}


	//add up all bloack on level
	public void CountBreakableBlocks()
	{
		breakableBlocks++;

	}
	//count # of blocks destroyed and load next level on completion
	public void BlockDestroyed()
	{
		breakableBlocks--;

		if(breakableBlocks <= 0)
		{
			sceneLoader.LoadNextScene();

		}

	}
}
