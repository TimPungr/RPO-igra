using UnityEngine;
using System.Collections;

public class osnovni_nasprotnik : MonoBehaviour {

    // Use this for initialization
    /*void Start () {
	
	}*/
    public float hitrost = 1f;
    //public Transform zacetek;
    //public Transform konec;

    public Vector2 konec;

    public bool colliding;
    public LayerMask detectWhat;
    // Update is called once per frame
    void Update () {
        konec =new Vector2(transform.position.x + (2 * Mathf.Sign(hitrost)), transform.position.y - 1);
        GetComponent<Rigidbody2D>().velocity = new Vector2(hitrost, GetComponent<Rigidbody2D>().velocity.y);

        colliding = Physics2D.Linecast(transform.position, konec, detectWhat);

        if (!colliding)
        {

            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            hitrost *= -1;
        }

    }
}
