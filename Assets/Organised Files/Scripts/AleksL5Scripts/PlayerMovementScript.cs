using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float Speed = 5f;
    public Animator Animator;
    public Transform Player;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput).normalized;
        Vector3 movement = new Vector3(inputVector.x, inputVector.y, 0f) * Speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
            Animator.SetBool("IsRunning", true);
        }
        else
        {
            Animator.SetBool("IsRunning", false);
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePosition.x < transform.position.x)
        {
            Player.localScale = new Vector3(-1.7f, 1.7f, 1.7f);
        }
        if (mousePosition.x >= transform.position.x)
        {
            Player.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        }
    }
}








