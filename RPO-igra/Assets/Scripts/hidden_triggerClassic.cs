using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class hidden_triggerClassic : MonoBehaviour {

    public GameObject konecvrata;

   
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioClip zvok;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "player")
        {
            Destroy(konecvrata);
            AudioSource.PlayClipAtPoint(zvok, other.transform.position);
            Destroy(gameObject);
        }

    }

    
}
