using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class player_move : MonoBehaviour
{
    public AudioClip zvok;
    //
    public float hitrost = 10;
    public float skok = 2;
    public bool natleh = false;
    Transform mytrans;
    public LayerMask playerMask;
    Transform tla;
    Rigidbody2D player;
    public Vector3 respawnPoint;
    public LevelManager gameLevelManager;
    private bool obrnjenNaprej;


    // Use this for initialization
    void Start()
    {
        obrnjenNaprej = true;
        player = this.GetComponent<Rigidbody2D>();
        mytrans = this.transform;
        tla = GameObject.Find(this.name + "/tla").transform;
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<LevelManager>();

    }


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        natleh = Physics2D.Linecast(mytrans.position, tla.position,playerMask);
        gibanje(Input.GetAxisRaw("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (natleh)
        {
            AudioSource.PlayClipAtPoint(zvok, transform.position);
            player.velocity += skok * Vector2.up;
            player.AddForce(new Vector2(0, skok), ForceMode2D.Impulse);
        }
    }


    public void gibanje(float horizontalno)
    {
        obrniIgralca(horizontalno);
        Vector2 moveVel = player.velocity;
        moveVel.x = horizontalno * hitrost;
        player.velocity = moveVel;
        
    }

    public void obrniIgralca(float horizontalno)
    {
        if(horizontalno > 0 && !obrnjenNaprej || horizontalno < 0 && obrnjenNaprej)
        {
            obrnjenNaprej = !obrnjenNaprej;

            Vector3 velikost = transform.localScale;

            velikost.x *= -1;

            transform.localScale = velikost;
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
