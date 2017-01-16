using UnityEngine;
using System.Collections;

public class enemydamagecontroller : MonoBehaviour {
    public AudioClip zvokDie;

    public LevelManager gameLevelManager;
    private bool obrnjenNaprej;
    private LifeManager lifeSystem;

    public float bounce = 5f;

    public Transform igralec;
    public Transform respawn;


    // Use this for initialization
    void Start () {
        respawn = GameObject.Find("respawntocka").transform;
        igralec = GameObject.Find("player").transform;


    }


    //public float skoda = 1f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            /*
            col.zivljenje -=skoda;
            */
            //Destroy(col.gameObject);
            if(col.gameObject.GetComponent<Rigidbody2D>().velocity.y < -0.05f)
            {
                Destroy(gameObject);
                col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y + bounce);
            } else
            {
                // Destroy(col.gameObject);
                igralec.transform.position = respawn.position;
                AudioSource.PlayClipAtPoint(zvokDie, transform.position);
                gameLevelManager.Respawn();
                lifeSystem.TakeLife();
            }
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
