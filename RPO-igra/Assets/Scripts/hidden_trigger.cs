using UnityEngine;
using System.Collections;

public class hidden_trigger : MonoBehaviour {

    public GameObject konecvrata;

    public GameObject boss;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            Destroy(konecvrata);
            Destroy(boss);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
