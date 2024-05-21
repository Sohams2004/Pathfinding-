using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float horizontal, vertical;

    Rigidbody2D playerRb;

    private void Start()
    {
        playerRb = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * moveSpeed;
        vertical = Input.GetAxisRaw("Vertical") * moveSpeed;

        playerRb.velocity = new Vector2 (horizontal, vertical);
    }
}
