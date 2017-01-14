using UnityEngine;
using System.Collections;

public class enemydamagecontroller : MonoBehaviour {
    public AudioClip zvokDie;

    public LevelManager gameLevelManager;
    private bool obrnjenNaprej;
    private LifeManager lifeSystem;

    public float bounce = 5f;

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
            //Destroy(col.gameObject);
            if(col.gameObject.GetComponent<Rigidbody2D>().velocity.y < -0.05f)
            {
                Destroy(gameObject);
                col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y + bounce);
            } else
            {
               // Destroy(col.gameObject);
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
