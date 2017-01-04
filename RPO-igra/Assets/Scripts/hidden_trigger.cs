using UnityEngine;
using System.Collections;

public class hidden_trigger : MonoBehaviour {

    public GameObject konecvrata;

    public GameObject boss;

    public GameObject crushing;

    public float hitrost;

    private Vector3 premik;

    private bool vstop;

	// Use this for initialization
	void Start () {
        premik.y = hitrost;
	}
	
	// Update is called once per frame
	void Update () {
        premik.y = hitrost * Time.deltaTime;
        if (vstop)
        {
            crushing.transform.Translate(premik);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            Destroy(konecvrata);
            Destroy(boss);
            vstop = true;
            Destroy(crushing, 5);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Destroy(gameObject);
    }
}
