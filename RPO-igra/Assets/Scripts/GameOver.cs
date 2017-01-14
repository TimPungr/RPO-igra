using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	}
	
	void OnGUI(){
		
		//if retry button is pressed load scene 0 the game
		GUI.contentColor = Color.red;
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2 +100,100,40),"Retry?")){
			//Application.LoadLevel(1);
            Application.LoadLevel(PreviousLevel.getLastLevel());
		}
		//and quit button
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2 + 100, 100,40),"Quit")){
			Application.Quit();
		}
	}
	
}