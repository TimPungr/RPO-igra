using UnityEngine;
using System.Collections;

public class UFOboss : MonoBehaviour {

    public float okrevanje;
    public float letenje;
    public float timer;
    public float smer;

    public float hitrostOkr;
    public float hitrostLet;

    public Transform postaja;
    public Transform levo;
    public Transform desno;

    public GameObject cannon1;
    public GameObject cannon2;
    public GameObject cannon3;
    public GameObject cannon4;
    public GameObject cannon5;

    public int zivljenje;

    public float casMedSkodo;
    public float timerSkoda;

    public float bounce;

    public int grelevo = 1;

    private bool okreval = true;
	// Use this for initialization
	void Start () {
        timer = letenje;
        timerSkoda = casMedSkodo;
        smer = Random.Range(0.0f, 5.0f);
        cannon4.GetComponent<streljnaje>().enabled = false;
        cannon5.GetComponent<streljnaje>().enabled = false;
    }
	

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            if (timerSkoda < 0)
            {
                timerSkoda = casMedSkodo;
                zivljenje--;
               // col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y + bounce);
                
            }
            if (zivljenje == 1)
            {
                okrevanje *= 0.8f;
                letenje *= 1.2f;
                cannon4.GetComponent<streljnaje>().enabled = true;
                cannon5.GetComponent<streljnaje>().enabled = true;
                cannon4.GetComponent<streljnaje>().casMedStreli *= 0.75f;
                cannon5.GetComponent<streljnaje>().casMedStreli *= 0.75f;
                cannon1.GetComponent<streljnaje>().casMedStreli *= 0.75f;
                cannon2.GetComponent<streljnaje>().casMedStreli *= 0.75f;
                cannon3.GetComponent<streljnaje>().casMedStreli *= 0.75f;

                cannon4.GetComponent<streljnaje>().hitrost *= 1.5f;
                cannon5.GetComponent<streljnaje>().hitrost *= 1.5f;
                cannon1.GetComponent<streljnaje>().hitrost *= 1.5f;
                cannon2.GetComponent<streljnaje>().hitrost *= 1.5f;
                cannon3.GetComponent<streljnaje>().hitrost *= 1.5f;

                cannon4.GetComponent<streljnaje>().razdalja *= 1.5f;
                cannon5.GetComponent<streljnaje>().razdalja *= 1.5f;
                cannon1.GetComponent<streljnaje>().razdalja *= 1.5f;
                cannon2.GetComponent<streljnaje>().razdalja *= 1.5f;
                cannon3.GetComponent<streljnaje>().razdalja *= 1.5f;

            }
        }
    }
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        smer -= Time.deltaTime;
        timerSkoda -= Time.deltaTime;
        if (smer <= 0)
        {
            grelevo *= -1;
            smer = Random.Range(1.0f, 3.5f);
        }

        if(zivljenje == 0)
        {
            Destroy(gameObject);
        }

        if (okreval)
        {
            float hitr = hitrostLet * Time.deltaTime;
            if (grelevo >= 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, levo.position, hitr);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, desno.position, hitr);
            }
            if (timer <= 0)
            {
                cannon1.GetComponent<streljnaje>().enabled = false;
                cannon2.GetComponent<streljnaje>().enabled = false;
                cannon3.GetComponent<streljnaje>().enabled = false;
                okreval = false;
                timer = okrevanje;
            }
        }
        else
        {
            float hitr = hitrostOkr * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, postaja.position, hitr);


            if (timer <= 0)
            {
                cannon1.GetComponent<streljnaje>().enabled = true;
                cannon2.GetComponent<streljnaje>().enabled = true;
                cannon3.GetComponent<streljnaje>().enabled = true;
                okreval = true;
                timer = letenje;
            }
        }
	}
}
