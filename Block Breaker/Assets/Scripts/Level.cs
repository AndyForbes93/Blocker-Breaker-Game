using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

	//params
	[SerializeField] int breakableBlocks;

	//method to add total of breakable blocks
	public void CountBreakableBlocks()
	{
		breakableBlocks++;
 
	}

}
