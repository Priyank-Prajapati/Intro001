using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Explosion;
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
