using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class player_move : MonoBehaviour
{
    public AudioClip zvok;
    public AudioClip zvokDie;
    public AudioClip zvokFlag;
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
    private LifeManager lifeSystem;

    public bool canMove;
    public int interactionCounter = 0;
    private DialogueManager dMan;
    public string dialogue;


    public static void MyDelay(int seconds)
    {
        System.DateTime dt = System.DateTime.Now + System.TimeSpan.FromSeconds(seconds);

        do { } while (System.DateTime.Now < dt);
    }

    // Use this for initialization
    void Start()
    {
        PreviousLevel.setLastLevel(Application.loadedLevelName);
        obrnjenNaprej = true;
        player = this.GetComponent<Rigidbody2D>();
        mytrans = this.transform;
        tla = GameObject.Find(this.name + "/tla").transform;
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<LevelManager>();
        lifeSystem = FindObjectOfType<LifeManager>();
        canMove = true;

    }

    //
    void Awake()
    {
        // Call the LevelManager and set the last level.
        PreviousLevel.setLastLevel(Application.loadedLevelName);
    }

    //

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }

        natleh = Physics2D.Linecast(mytrans.position, tla.position, playerMask);
        gibanje(Input.GetAxisRaw("Horizontal"));
        if (Input.GetKeyDown("space"))
        {
            Jump();
        }

    }

    void FixedUpdate()
    {
       
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
            AudioSource.PlayClipAtPoint(zvokDie, transform.position);
            gameLevelManager.Respawn();
            lifeSystem.TakeLife();
        }
        if (other.tag == "Checkpoint")
        {
            AudioSource.PlayClipAtPoint(zvokFlag, transform.position);
            respawnPoint = other.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }


}
