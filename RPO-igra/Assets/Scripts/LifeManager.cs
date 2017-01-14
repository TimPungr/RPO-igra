using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
    public int startinLives;
    private int lifeCounter;
    public LevelManager gameLevelManager;

    private Text theText;

  //  public string GameOver;
     
	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();
        lifeCounter = startinLives;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lifeCounter <= 0) {
            if (PlayerPrefs.HasKey("Highscore"))
            {
                if (PlayerPrefs.GetInt("Highscore") < gameLevelManager.coins)
                {
                    PlayerPrefs.SetInt("Highscore", gameLevelManager.coins);
                }
            }
            else
            {
                PlayerPrefs.SetInt("Highscore", gameLevelManager.coins);
            }

            Application.LoadLevel(0);
        }
        theText.text = "x " + lifeCounter;
	}

    public void GiveLife() {
        lifeCounter++;

    }

    public void TakeLife()
    {
        lifeCounter--;

    }




}
