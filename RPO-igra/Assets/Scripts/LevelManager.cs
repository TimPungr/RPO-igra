using UnityEngine;
using System.Collections;
using UnityEngine.UI; //za text
public class LevelManager : MonoBehaviour
{
    public float respawnDelay;
    public player_move gamePlayer;
    public int coins;
    public Text coinText;
    public int Highscore = 0;
    public Text HighscoreText;
    public int skupaj;

    public Transform igralec;

    public Transform respawn;

    void Awake()
    {
        // Call the LevelManager and set the last level.
        PreviousLevel.setLastLevel(Application.loadedLevelName);
    }

    void Start()
    {
        gamePlayer = FindObjectOfType<player_move>();
        coinText.text = "Coins: " + coins;

        if (PlayerPrefs.HasKey("Highscore"))
        {
            Highscore = PlayerPrefs.GetInt("Highscore");
         //   skupaj = Highscore + coins;
        }
        HighscoreText.text = "Highscore: " + Highscore;
      //  HighscoreText.text = "Highscore: " + skupaj;

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
        igralec.transform.position = respawn.position;
        gamePlayer.gameObject.SetActive(true);
    }


    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;

        coinText.text = "Coins: " + coins;
        skupaj = Highscore + numberOfCoins;
        HighscoreText.text = "Highscore: " + skupaj;
        Highscore = skupaj;
        PlayerPrefs.SetInt("Highscore", skupaj);
        PlayerPrefs.Save();
    }

    /**
   void OnGUI()
   {
       if (GUI.Button(new Rect(Screen.width / 2 + 340, Screen.height / 2 - 170, 100, 40), "Return to menu"))
       {
           Application.LoadLevel(12);
       }
   if (Input.GetKey(KeyCode.Escape))
   {
       Application.LoadLevel(12);

   }
    
}*/
}