using UnityEngine;
using System.Collections;

public class osnovni_nasprotnik : MonoBehaviour {

    // Use this for initialization
    /*void Start () {
	
	}*/
    public float hitrost = 1f;

    public Vector2 konecZrak;
    public Vector2 konecTla1;
    public Vector2 konecTla2;



    public bool collidingTla;
    public bool collidingZrak;
    public LayerMask Zrak;
    public LayerMask Tla;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            Destroy(col.gameObject);
        }
    }

    void Update () {
        konecZrak =new Vector2(transform.position.x + (2 * Mathf.Sign(hitrost)), transform.position.y - 1);
        GetComponent<Rigidbody2D>().velocity = new Vector2(hitrost, GetComponent<Rigidbody2D>().velocity.y);
        konecTla1 = new Vector2(transform.position.x + (0.5f * Mathf.Sign(hitrost)), transform.position.y+1);
        konecTla2 = new Vector2(transform.position.x + (0.5f * Mathf.Sign(hitrost)), transform.position.y);

        collidingZrak = Physics2D.Linecast(transform.position, konecZrak, Zrak);
        collidingTla = Physics2D.Linecast(konecTla2, konecTla1, Tla);


        if (!collidingZrak || collidingTla)
        {

            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            hitrost *= -1;
        }

        

    }
}
