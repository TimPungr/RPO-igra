using UnityEngine;
using System.Collections;

public class vrata : MonoBehaviour {


    public GameObject vrataklon;

    public Transform vratalokacija;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void zaprivrata()
    {
        GameObject zaprtavrata = (GameObject)Instantiate(vrataklon, vratalokacija.position, vratalokacija.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            zaprivrata();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
