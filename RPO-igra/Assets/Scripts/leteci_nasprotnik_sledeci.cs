using UnityEngine;
using System.Collections;

public class leteci_nasprotnik_sledeci : MonoBehaviour {


    private Transform igralec;

    public float hitrost = 2f;

    public float razdalja = 10f;

    public LayerMask playerlayer;

    private bool vObmocju;
    // Use this for initialization
    void Start()
    {
        igralec = GameObject.Find("player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        vObmocju = Physics2D.OverlapCircle(transform.position, razdalja, playerlayer);

        if (vObmocju)
        {
            transform.position = Vector3.MoveTowards(transform.position, igralec.position, hitrost * Time.deltaTime);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, razdalja);

    }
}
