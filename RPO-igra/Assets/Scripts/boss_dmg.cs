using UnityEngine;
using System.Collections;

public class boss_dmg : MonoBehaviour {

    public float timer;

    public float casMedSkodo;

    public float bounce = 5f;

    public int zivljenje = 3;

    public Rigidbody2D turretclone;

    public Rigidbody2D turretclone2;

    public Transform turretlocation;

    public Transform turretlocation2;

    public GameObject konec;
    // Use this for initialization
    void Start () {
        timer = casMedSkodo;
	}
    //col.gameObject.GetComponent<Rigidbody2D>().velocity.y< 1 && 

    void klon(Rigidbody2D klon, Transform lokacija, Rigidbody2D klon2, Transform lokacija2)
    {
        Rigidbody Clone = (Rigidbody)Instantiate(klon, lokacija.position, transform.rotation);
        Rigidbody Clone2 = (Rigidbody)Instantiate(klon2, lokacija2.position, transform.rotation);

    }

    void klon2(Rigidbody2D klon, Transform lokacija)
    {
        Rigidbody Clone = (Rigidbody)Instantiate(klon, lokacija.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "player")
        {
            if (timer < 0)
            {
                timer = casMedSkodo;
                zivljenje--;
                col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y + bounce);
            }
            if(zivljenje == 1)
            {
                klon(turretclone,turretlocation, turretclone2, turretlocation2);
                klon2(turretclone2,turretlocation2);
            }
        }
    }
    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        if (zivljenje <= 0)
        {
            Destroy(konec);
            Destroy(transform.parent.gameObject);
        }
    }
}
