using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject PlayerExplosion;
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
