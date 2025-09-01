using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   // same as dragging dropping
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)  // when object FIRST hits collider
    {
        if (collision.gameObject.layer == 3)  // if collision happened on bird layer (FUTURE PROOFING)
        {
            logic.addScore(1);
        }
        
    }

}
