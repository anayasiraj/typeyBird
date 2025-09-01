using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;   // reference to the rigidbody of bird! public to access outside of script
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource flapSound;
    // public AudioSource aww;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength; // or (0, 1) 
            flapSound.Play();
        }

        if (birdIsAlive && (transform.position.y > 17 || transform.position.y < -17))
        {
            birdIsAlive = false;
            logic.gameOver();

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            birdIsAlive = false;
            logic.gameOver();
        }

    }




}
