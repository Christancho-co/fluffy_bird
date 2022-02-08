using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float jumpspeed;
    public ui UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = new Vector2(0, jumpspeed);
        }
    
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
       // if (other.CompareTag("obstacle"))
           // transform.position = new Vector2(0, 0);
        //Rb.velocity = new Vector2(0, 0);
        UI.Lost();
        
    {
        
    }
}
}
