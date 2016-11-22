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

<<<<<<< HEAD

    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;

=======
   
    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;
      
>>>>>>> origin/lol
        coinText.text = "Coins: " + coins;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + 340, Screen.height / 2 - 170, 100, 40), "Return to menu"))
        {
            Application.LoadLevel(8);
        }
    }
}