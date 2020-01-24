using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    int movementspeed=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horizon*movementspeed, 0.0f);
    }
}
