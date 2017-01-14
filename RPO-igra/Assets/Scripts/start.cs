using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class start : MonoBehaviour {

    public Texture2D icon;
    private bool _isFirstMenu = true;
    private bool _isLevelSelectMenu = false;
    public Text score;
   // public Level11Script ls;

    void Start()
    {
    //    ls = FindObjectOfType<Level11Script>();
    }

    void OnGUI()
    {
        FirstMenu();
        LevelSelectMenu();

        if (_isLevelSelectMenu == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 + 100, 100, 40), "Back"))
            {
                _isLevelSelectMenu = false;
                _isFirstMenu = true;
            }
        }
    }

    public int sc;
    void FirstMenu() {
        if (_isFirstMenu == true)
        {
            
            sc = PlayerPrefs.GetInt("Highscore");
            score.text = "Your score is: " + sc;


            if (GUI.Button(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 30, 200, 200), icon))
            {
                Application.LoadLevel(1);
            }
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 + 100, 100, 40), "Level select"))
            {
                _isFirstMenu = false;
                _isLevelSelectMenu = true;
            }
           
            //and quit button
            GUI.contentColor = Color.red;
            if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 + 100, 100, 40), "Quit"))
            {
                Application.Quit();
            }


        }

    }

    //public int lol = 2;
   // public int lol;

    public Texture2D locked;
    public Texture2D un11;
    public Texture2D un12;
    public Texture2D un13;
    public Texture2D un14;
    public Texture2D un21;
    public Texture2D un22;
    public Texture2D un23;
    public Texture2D un31;
    public Texture2D un32;
    public Texture2D un33;
    public Texture2D un34;
    public Texture2D un41;
    public Texture2D un42;
    public Texture2D un43;
    public Texture2D un44;
    public Texture2D un45;
    public Texture2D un46;
    public Texture2D un47;
    public Texture2D un48;
    public Texture2D un49;

    //var LevelReached : int = 0;
    int LevelReached = 0;
    public int lol = 3;


    void LevelSelectMenu()
    {
        if (_isLevelSelectMenu)
        {
            LevelReached = PlayerPrefs.GetInt("LevUnlock");
            //
            if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 150, 100, 50), un11))
            {
                Application.LoadLevel(1);
            }


            if (LevelReached == 1 || LevelReached > 1)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), locked))
                {

                }
            }
            
            // if (lol == 3)
            if (LevelReached == 2 || LevelReached > 2)
            {

                  if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                //if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), "Load level 1.2"))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 3 || LevelReached > 3)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 4 || LevelReached > 4)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 5 || LevelReached > 5)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 6 || LevelReached > 6)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 7 || LevelReached > 7)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 8 || LevelReached > 8)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 9 || LevelReached > 9)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 10 || LevelReached > 10)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), locked))
                {

                }
            }

            if (LevelReached == 11 || LevelReached > 11)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 12 || LevelReached > 12)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 13 || LevelReached > 13)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 14 || LevelReached > 14)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 15 || LevelReached > 15)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), un45))
                {
                    Application.LoadLevel(16);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 16 || LevelReached > 16)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), un45))
                {
                    Application.LoadLevel(16);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 70, Screen.height / 2 + 30, 100, 50), un46))
                {
                    Application.LoadLevel(17);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 + 70, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 17 || LevelReached > 17)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), un45))
                {
                    Application.LoadLevel(16);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 70, Screen.height / 2 + 30, 100, 50), un46))
                {
                    Application.LoadLevel(17);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 170, Screen.height / 2 + 30, 100, 50), un47))
                {
                    Application.LoadLevel(18);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 + 170, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 18 || LevelReached > 18)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), un45))
                {
                    Application.LoadLevel(16);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 70, Screen.height / 2 + 30, 100, 50), un46))
                {
                    Application.LoadLevel(17);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 170, Screen.height / 2 + 30, 100, 50), un47))
                {
                    Application.LoadLevel(18);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 270, Screen.height / 2 + 30, 100, 50), un48))
                {
                    Application.LoadLevel(19);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2+ 270, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }
            if (LevelReached == 19 || LevelReached > 19)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), un12))
                {
                    Application.LoadLevel(2);
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), un13))
                {
                    Application.LoadLevel(3);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), un14))
                {
                    Application.LoadLevel(4);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), un21))
                {
                    Application.LoadLevel(5);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), un22))
                {
                    Application.LoadLevel(6);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), un23))
                {
                    Application.LoadLevel(7);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 30, 100, 50), un31))
                {
                    Application.LoadLevel(8);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 30, 100, 50), un32))
                {
                    Application.LoadLevel(9);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 30, 100, 50), un33))
                {
                    Application.LoadLevel(10);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 30, 100, 50), un34))
                {
                    Application.LoadLevel(11);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 + 30, 100, 50), un41))
                {
                    Application.LoadLevel(12);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 + 30, 100, 50), un42))
                {
                    Application.LoadLevel(13);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 + 30, 100, 50), un43))
                {
                    Application.LoadLevel(14);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 + 30, 100, 50), un44))
                {
                    Application.LoadLevel(15);
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 30, 100, 50), un45))
                {
                    Application.LoadLevel(16);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 70, Screen.height / 2 + 30, 100, 50), un46))
                {
                    Application.LoadLevel(17);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 170, Screen.height / 2 + 30, 100, 50), un47))
                {
                    Application.LoadLevel(18);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 270, Screen.height / 2 + 30, 100, 50), un48))
                {
                    Application.LoadLevel(19);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 370, Screen.height / 2 + 30, 100, 50), un49))
                {
                    Application.LoadLevel(20);
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 + 370, Screen.height / 2 + 30, 100, 50), locked))
                {

                }
            }

        }

    }



   












}
