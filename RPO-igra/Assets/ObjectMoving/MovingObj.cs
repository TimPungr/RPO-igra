using UnityEngine;
using System.Collections;

public class MovingObj : MonoBehaviour {

 public float hitrost;
 public float razdalja;
 //public float razdaljaY;
 //public float razdaljaX;

    private Vector3 tempP;
   
 void Start () 
  {
        tempP = transform.position;
        
 }
 
 void Update () 
  {
        tempP.y = Mathf.Sin(Time.realtimeSinceStartup * hitrost) * razdalja;
        //tempP.y = Mathf.Sin(Time.realtimeSinceStartup * hitrost)* razdaljaY;
        //tempP.x = Mathf.Sin(Time.realtimeSinceStartup * hitrost) * razdaljaX;
        transform.position = tempP;
 }
}