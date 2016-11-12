using UnityEngine;
using System.Collections;

public class player_move : MonoBehaviour {

	public float hitrost = 4f;
	public float skok = 0.1f;
	public bool skokaktiven = false;
    public Vector3 respawnPoint;
    public LevelManager gameLevelManager;

    void skoci(){
		if(Input.GetKey(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
		}
	}

	void levo(){
		GetComponent<Rigidbody2D>().velocity = (Vector3.left * 100 * 2 * Time.deltaTime);
	}


	void desno(){
		GetComponent<Rigidbody2D>().velocity = (Vector3.right * 100 * 2 * Time.deltaTime);
	}
	
	// Use this for initialization
	void Start () {
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<LevelManager>();

    }


	// Update is called once per frame
	void Update () {


		// levo

		if(Input.GetKey(KeyCode.LeftArrow)){
			levo ();
		}

		// desno

		if (Input.GetKey (KeyCode.RightArrow)) {
			desno ();
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (skokaktiven == false) {

					GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, skok), ForceMode2D.Impulse);
					

			}

		}
	}

	void OnCollisionEnter2D(Collision2D trk){
		if (trk.gameObject.tag == "tla") { 
			skokaktiven = false;
		}
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FallDetector")
        {
            gameLevelManager.Respawn();
        }
        if (other.tag == "Checkpoint")
        {
            respawnPoint = other.transform.position;
        }
    }



}
