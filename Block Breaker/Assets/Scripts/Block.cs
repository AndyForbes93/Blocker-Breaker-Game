using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip blockSound;

    //cached reference
    LevelAgain level;
   // GameStatus gameStatus;

    //on start call COuntBreakableBlocks method from Level class
     void Start()
    {
      
       level = FindObjectOfType<LevelAgain>();
       level.CountBreakableBlocks();

        
    }

    //destroys block and play souns on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(blockSound , Camera.main.transform.position);
        Destroy(gameObject, .1f);
        level.BlockDestroyed();
    }
}
