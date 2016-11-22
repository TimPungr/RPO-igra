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
<<<<<<< HEAD

    public AudioClip zvok;
=======
   // public AudioClip audio;

  
>>>>>>> origin/lol
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
         //   AudioSource audio = GetComponent<AudioSource>();
            gameLevelManager.AddCoins(coinValue);
<<<<<<< HEAD
            AudioSource.PlayClipAtPoint(zvok, other.transform.position);
=======
          //  audio.Play();
>>>>>>> origin/lol
            Destroy(gameObject);
        }

    }

}