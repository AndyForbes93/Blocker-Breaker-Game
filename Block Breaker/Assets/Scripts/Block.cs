using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    //config params
    [SerializeField] AudioClip blockSound;
    [SerializeField] GameObject blockParticleVFX;
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] hitSprites;

    //cached reference
    LevelAgain level;

    //state vars
    [SerializeField] int timesHit; //TODO: only serialized for debug

    //on start call COuntBreakableBlocks method from Level class
     void Start()
    {
        CountBreakableBlocks();
    }

    private void CountBreakableBlocks()
    {
        if (tag == "Breakable")
        {
            level = FindObjectOfType<LevelAgain>();
            level.CountBreakableBlocks();

        }
    }

    //destroys block and play souns on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == "Breakable")
        {
            HandleHit();

        }
    }
    //checking whether or not block is hit enough to be destroyed
    private void HandleHit()
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            DestroyBlock();
        } else
        {
            ShowNextHitSprite();
        }
    }
    //function to desroy block
    private void DestroyBlock()
    {
        PlayBlockDestroyedSFX();
        Destroy(gameObject, .1f);
        level.BlockDestroyed();
        TriggerParticleVFX();
    }
    //SFX for destroyed block
    private void PlayBlockDestroyedSFX()
    {
        FindObjectOfType<GameSession>().AddToScore();
        AudioSource.PlayClipAtPoint(blockSound, Camera.main.transform.position);

    }
    //TODO: fix particle FX
    private void TriggerParticleVFX()
    {
        GameObject particles = Instantiate(blockParticleVFX , transform.position , transform.rotation);
        Destroy(particles, 1f);
    }

    private void ShowNextHitSprite()
    {
        int spriteIndex = timesHit - 1;
        if(hitSprites[spriteIndex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("BLOCK SPRITE IS MISSING FROM ARRAY");
        }
        
    }
}
