using UnityEngine;
using System.Collections;

public class MovingObj : MonoBehaviour {

 public float hitrost;
 public float razdalja;
 
 private Vector3 tempP;

 void Start () 
  {
        tempP = transform.position;
        
 }
 
 void Update () 
  {
 
  tempP.y = Mathf.Sin(Time.realtimeSinceStartup * hitrost)* razdalja;
  transform.position = tempP;
 }
}