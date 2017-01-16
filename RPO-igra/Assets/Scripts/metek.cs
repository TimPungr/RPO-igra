using UnityEngine;
using System.Collections;

public class metek : MonoBehaviour {
    public float hitrost;
    public Transform igralec;
    private Rigidbody2D taRigidBody;
    public float Cas;

    public AudioClip zvokDie;
    public LevelManager gameLevelManager;
    private LifeManager lifeSystem;

    public Transform respawn;



    // Use this for initialization
    void Start () {
        igralec = GameObject.Find("player").transform;
        taRigidBody = GetComponent<Rigidbody2D>();
        gameLevelManager = FindObjectOfType<LevelManager>();
        respawn = GameObject.Find("respawntocka").transform;

        /* if (igralec.position.x < transform.position.x)
         {
             hitrost = -hitrost;
         }*/

    }
	
	// Update is called once per frame
	void Update () {
        taRigidBody.velocity = /*new Vector2(hitrost, taRigidBody.velocity.y)*/transform.right * hitrost * -1;
        Destroy(gameObject, Cas);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "player")
        {
            igralec.transform.position = respawn.position;
            //Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(zvokDie, transform.position);
            //gameLevelManager.Respawn();
            lifeSystem.TakeLife();
        }

    }
}
