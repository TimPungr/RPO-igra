using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dbox;
    public Text dText;
    public bool dialogActive;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(dialogActive && Input.GetKeyDown(KeyCode.Return))
        {
            dbox.SetActive(false);
            dialogActive = false;
        }
	}


    public void showBox(string dialogue)
    {
        dialogActive = true;
        dbox.SetActive(true);
        dText.text = dialogue;
    }
}
