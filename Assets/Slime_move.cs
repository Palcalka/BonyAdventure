using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Slime_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if(Physics2D.Raycast(transform.position,transform.right+transform.position)){
        //     transform.localScale = new Vector3(-1,1,1);
        // }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        transform.parent.localScale = new Vector3(-1,1,1);
    }
    private  void OnCollisionEnter2D(Collision2D other) {
        
    }
}
