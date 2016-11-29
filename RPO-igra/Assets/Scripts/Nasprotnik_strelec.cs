using UnityEngine;
using System.Collections;

public class Nasprotnik_strelec : MonoBehaviour {

     public double timestamp = 0.0;
     public float range = 10f;

     public Object metek;

     public Transform igralec;
     // Use this for initialization
     void Start () {

     }


     // Update is called once per frame
     void Update () {
         igralec = GameObject.Find("player").transform;
         if (Vector3.Distance(transform.position, igralec.position) >= 200)
         {
             transform.position += transform.forward * 3 * Time.deltaTime;

             if (Vector3.Distance(transform.position, igralec.position) <= range && (Time.time > timestamp))
             {
                 Instantiate(metek, transform.position, transform.rotation);
                 timestamp = Time.time + timestamp;
             }
         }


         Vector3 tarca = igralec.position - transform.position;
         float angle = Mathf.Atan2(tarca.y, tarca.x) * Mathf.Rad2Deg + 180;
         Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
         transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 3);

     }
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, range);

    }
}
