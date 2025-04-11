using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedplayer : MonoBehaviour
{
    public float speedx;
    public float speedy;
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _comSpriteRenderer;
    public int directionx;
    public int directiony;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Start()
    {

    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0)
        {
            _comSpriteRenderer.flipX = false;
            directionx = 1;
            directiony = 0;
        }
        else if (horizontal < 0)
        {
            _comSpriteRenderer.flipX = true;
            directionx = -1;
            directiony = 0;
        }

        if (vertical > 0)
        {
            _comSpriteRenderer.flipY = false;
            directiony = 1;
            directionx = 0;
        }
        else if (vertical < 0)
        {
            _comSpriteRenderer.flipY = true;
            directiony = -1;
            directionx = 0;
        }
        _compRigidbody2D.linearVelocity = new Vector2(speedx * horizontal, speedy * vertical);
    }
}
