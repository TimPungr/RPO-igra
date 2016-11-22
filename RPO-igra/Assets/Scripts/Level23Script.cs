using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Level23Script : MonoBehaviour {
    float wait;
    bool check;
    // Use this for initialization
    public AudioClip zvok;

    IEnumerator MyMethod()
    {

        yield return new WaitForSeconds(2);
    }

    void OnTriggerEnter2D(Collider2D other){
		//if the object that triggered the event is tagged player
		if (other.tag == "player") {
            AudioSource.PlayClipAtPoint(zvok, other.transform.position);
            // wait = zvok.length;
            // if (check) {
            //     wait -= Time.deltaTime;
            //  }
            //  if (wait < 0.1) {
            StartCoroutine(MyMethod());
                Application.LoadLevel(0);
           // }
           // Application.LoadLevel(0);
           

        }
		
//		if (other.gameObject.transform.parent) {
//			Destroy (other.gameObject.transform.parent.gameObject);
//			
//		} else {
//			Destroy (other.gameObject);		
//		}
	}
	
}




