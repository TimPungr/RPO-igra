using UnityEngine;
using System.Collections;

public class lifePickup : MonoBehaviour {
    private LifeManager lifeSystem;

	// Use this for initialization
	void Start () {
        lifeSystem = FindObjectOfType<LifeManager>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "player")
        {
            lifeSystem.GiveLife();
            Destroy(gameObject);
        }
    }
}
