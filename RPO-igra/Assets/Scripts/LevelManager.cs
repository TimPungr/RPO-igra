using UnityEngine;
using System.Collections;
using UnityEngine.UI; //za text
public class LevelManager : MonoBehaviour
{
    public float respawnDelay;
    public player_move gamePlayer;
    public int coins;
    public Text coinText;

    void Start()
    {
        gamePlayer = FindObjectOfType<player_move>();
        coinText.text = "Coins: " + coins;
    }
    
    void Update()
    {

    }
    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");
    }
    public IEnumerator RespawnCoroutine()
    {
        gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        gamePlayer.gameObject.SetActive(true);
    }
    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;
        coinText.text = "Coins: " + coins;
    }
}