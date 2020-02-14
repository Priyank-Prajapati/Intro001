using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float minX, maxX, minY, maxY;
    public GameObject laser;
    public Transform laserSpawn;
    public float fireRateDelay = 0.25f;

    private Rigidbody2D rbody;
    private float timer = 0;

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

    void Update()
    {
        //1. check user input
        if (Input.GetAxis("Fire1") > 0 && timer > fireRateDelay)
        {
            //2. create the object (instantiate)
            GameObject gobj = Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            gobj.transform.Rotate(0, 0, -90);

            // reset timer
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
