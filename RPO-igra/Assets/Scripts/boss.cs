using UnityEngine;
using System.Collections;

public class boss : MonoBehaviour {

    public double timestamp = 0.0;
    public float range = 10f;

    public Object metek;

    public Transform igralec;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        igralec = GameObject.Find("player").transform;


        if (Mathf.Sign(igralec.position.x - transform.position.x) != Mathf.Sign(transform.localScale.x))
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        }

    }

}

