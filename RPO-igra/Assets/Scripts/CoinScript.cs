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

    public AudioClip zvok;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            gameLevelManager.AddCoins(coinValue);
            AudioSource.PlayClipAtPoint(zvok, other.transform.position);
            Destroy(gameObject);
        }

    }

}