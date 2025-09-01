using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -40;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;  // LETS DEPEND ON FPS!!! DIFF

        if (transform.position.x < deadZone)  // delete pipe once it's off screen
        {
            // u can do Debug.Log("Pipe Deleted");  so consol will say when it happens!
            Destroy(gameObject);     
        }
    }
}
