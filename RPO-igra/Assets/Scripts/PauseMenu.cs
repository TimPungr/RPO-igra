using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
    public string mainMenu;
    public bool isPaused;
    public GameObject PauseMenuCanvas;


    // Update is called once per frame
    void Update() {
        if (isPaused)
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + 340, Screen.height / 2 - 170, 100, 40), "Pause"))
        {
            isPaused = !isPaused;
        }
       

    }
    public void Resum()
    {
        isPaused = false;
    }

    public void Quit()
    {
        Application.LoadLevel(21);
    }

}
