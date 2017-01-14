using UnityEngine;
using System.Collections;
//using UnityEngine.UI; //za text

public class TimeText : MonoBehaviour {
    public GUIText timeText;
    public float timer = 30.00f;
    public AudioClip zvokEndTime;


    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        timeText.text = "Remaining time: " + timer.ToString("0.0");

        if(timer <= 0)
        {
            timeText.text = "";
            AudioSource.PlayClipAtPoint(zvokEndTime, transform.position);
            Time.timeScale = 0;
            Application.LoadLevel(0);
        }
	}
}
