using UnityEngine;
using System.Collections;

public class streljnaje : MonoBehaviour {
    public float razdalja;

    public GameObject metek;

    public Transform igralec;

    public Transform cannon;

    public Transform rangecast;

    public bool CollPlayer;

    public LayerMask player;

    private float timer;

    public float casMedStreli;

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
            Instantiate(metek, cannon);
            timer = casMedStreli;
        }

	}
}
