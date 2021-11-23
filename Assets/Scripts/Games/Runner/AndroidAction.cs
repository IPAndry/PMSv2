using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class AndroidAction : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    public float moveSpeed = 10f;

    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        playerDirection = new Vector2(dirX, 0).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * moveSpeed * Time.deltaTime, 0);
    }

}
