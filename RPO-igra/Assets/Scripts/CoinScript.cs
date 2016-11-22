using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class CoinScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }
    
    void Update()
    {

    }
   // public AudioClip audio;

  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
         //   AudioSource audio = GetComponent<AudioSource>();
            gameLevelManager.AddCoins(coinValue);
          //  audio.Play();
            Destroy(gameObject);
        }
    }
}