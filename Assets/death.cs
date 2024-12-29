using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if(other.transform.tag.Equals("Weapon")){
    //         Destroy(gameObject);

    //     }

    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag.Equals("Weapon"))
        {
            Destroy(gameObject);
        }
    }
}
