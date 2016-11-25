using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class CheckpointController : MonoBehaviour {

    public Sprite redFlag;
    public Sprite blueFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;

	// Use this for initialization
	void Start () {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioClip zvok;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            checkpointSpriteRenderer.sprite = blueFlag;
            AudioSource.PlayClipAtPoint(zvok, other.transform.position);
            checkpointReached = true;
        }
    }
}
