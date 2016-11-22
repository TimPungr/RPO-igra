using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class start : MonoBehaviour {

    public Texture2D icon;
    private bool _isFirstMenu = true;
    private bool _isLevelSelectMenu = false;

    void Start()
    {
    
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


    void FirstMenu() {
        if (_isFirstMenu == true)
        {

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

    void LevelSelectMenu()
    {
        if (_isLevelSelectMenu)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 150, 100, 50), "Load level 1.1"))
            {
                Application.LoadLevel(1);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 150, 100, 50), "Load level 1.2"))
            {
                Application.LoadLevel(2);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 150, 100, 50), "Load level 1.3"))
            {
                Application.LoadLevel(3);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 130, Screen.height / 2 - 150, 100, 50), "Load level 1.4"))
            {
                Application.LoadLevel(4);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 430, Screen.height / 2 - 90, 100, 50), "Load level 2.1"))
            {
                Application.LoadLevel(4);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 90, 100, 50), "Load level 2.2"))
            {
                Application.LoadLevel(6);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 90, 100, 50), "Load level 2.3"))
            {
                Application.LoadLevel(7);
            }
            
        }

    }



   












}
