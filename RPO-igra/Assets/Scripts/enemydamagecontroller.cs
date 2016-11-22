using UnityEngine;
using System.Collections;

public class enemydamagecontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    //public float skoda = 1f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            /*
            col.zivljenje -=skoda;
            */
            Destroy(col.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
