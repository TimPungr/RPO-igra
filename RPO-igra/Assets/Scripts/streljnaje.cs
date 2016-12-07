using UnityEngine;
using System.Collections;

public class streljnaje : MonoBehaviour {
    public float razdalja;

    //public GameObject metek;

    public Transform igralec;

    public Transform cannon;

    public Transform rangecast;

    public bool CollPlayer;

    public LayerMask player;

    private float timer;

    public float casMedStreli;

    public Rigidbody2D metekclone;

    public float hitrost;

    void strel()
    {
        Rigidbody Clone = (Rigidbody)Instantiate(metekclone, cannon.position, transform.rotation);
        Clone.velocity = transform.right * hitrost;
    }

    // Use this for initialization
    void Start () {
        igralec = GameObject.Find("player").transform;
        timer = casMedStreli;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        CollPlayer = Physics2D.Linecast(transform.position, rangecast.position, player);
        if (CollPlayer && timer < 0)
        {
            timer = casMedStreli;
            strel();
            
        }

	}
}
