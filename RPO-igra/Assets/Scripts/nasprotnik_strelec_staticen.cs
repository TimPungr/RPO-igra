using UnityEngine;
using System.Collections;

public class nasprotnik_strelec_staticen : MonoBehaviour {
    public double timestamp = 0.0;
    public float range = 10f;

    public Object metek;

    public Transform igralec;

    public Transform rangecast;
    // Use this for initialization
    void Start()
    {
        igralec = GameObject.Find("player").transform;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Mathf.Sign(igralec.position.x - transform.position.x) == Mathf.Sign(transform.localScale.x))
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, range);

    }
}
