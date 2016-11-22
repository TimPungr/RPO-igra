using UnityEngine;
using System.Collections;

public class Hover_nasprotnik : MonoBehaviour
{
    //public float hitrostH = 2f;
    public float hitrostV = 1f;
   // public float zacetnitimerH = 5f;
    public float zacetnitimerV = 5f;
    //float timerH;
    float timerV;
    Vector3 premik;
    // Use this for initialization
    void Start()
    {
       // timerH = zacetnitimerH;
        timerV = zacetnitimerV;

    }

    // Update is called once per frame
    void Update()
    {

        //premik.x = -1 * hitrostH * Time.deltaTime;
        premik.y = timerV * Time.deltaTime;


        //timerH -= Time.deltaTime;
        timerV -= hitrostV * Time.deltaTime;
        //if (timerH < 0)
        /*{
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            //hitrostH *= -1;
            timerH = zacetnitimerH;
        }*/
        if (timerV * Mathf.Sign(timerV) > zacetnitimerV)
        {
            hitrostV *= -1;
            //timerV = zacetnitimerV;
        }

        transform.Translate(premik);

    }
}
