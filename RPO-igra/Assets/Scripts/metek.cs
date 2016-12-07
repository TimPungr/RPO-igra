using UnityEngine;
using System.Collections;

public class metek : MonoBehaviour {
    public float hitrost;
    public Transform igralec;
    private Rigidbody2D taRigidBody;
    public float Cas;

    // Use this for initialization
    void Start () {
        igralec = GameObject.Find("player").transform;
        taRigidBody = GetComponent<Rigidbody2D>();

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
        if (col.name == "player")
        {
            Destroy(col.gameObject);
        }

    }
}
