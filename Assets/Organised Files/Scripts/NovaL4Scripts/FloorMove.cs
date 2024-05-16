using UnityEngine;

public class MoveOnCollision : MonoBehaviour
{
    public Transform pointB; // The point you want to move towards
   

    private bool hasCollidedTrapDoor = false;
    public string trapdoor;

    public int speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if collided with the object you want to trigger movement
        if (collision.gameObject.CompareTag(trapdoor))
        {
            hasCollidedTrapDoor = true;
        }
        
    }

    private void FixedUpdate()
    {
        if (hasCollidedTrapDoor)
        {
            // Move towards pointB
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, Time.deltaTime * speed);

            // Check if reached pointB
            if (transform.position == pointB.position)
            {
                hasCollidedTrapDoor = false; // Reset collision flag
            }

        }
       
       
    }
}