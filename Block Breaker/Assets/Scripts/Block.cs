using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip blockSound;

    //cached refernce
    Level level;

    //on start call COuntBreakableBlocks metjod from Level class
    private void Start()
    {
       level = FindObjectOfType<Level>();
       level.CountBreakableBlocks();

        
    }

    //destroys block and play souns on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //level.CountBreakableBlocks();

        AudioSource.PlayClipAtPoint(blockSound , Camera.main.transform.position);
        Destroy(gameObject, .1f);
    }
}
