using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class timePlus : MonoBehaviour {

    public TimeText TimeText;
    public AudioClip zvokPlusTime;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            AudioSource.PlayClipAtPoint(zvokPlusTime, transform.position);
            Destroy(gameObject);
            TimeText.timer += 30;
        }

    }
}
