using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float minX, maxX, minY, maxY;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizon = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        rbody.velocity = new Vector2(horizon, verti)* speed;

        rbody.position = new Vector2(
            Mathf.Clamp(rbody.position.x, minX, maxX),
            Mathf.Clamp(rbody.position.y, minY, maxY));
    }
}
