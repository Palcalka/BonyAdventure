using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimeattack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private  void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.tag.Equals("Player")){
            other.transform.GetComponent<playerHp>().damage();
        }
    }
}
