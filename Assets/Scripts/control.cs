using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movingSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void jump(){
        //rb.addVelocity()
        Debug.Log("jump");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            jump();
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A)){
            transform.Translate(-1 * movingSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D)){
            transform.Translate(1 * movingSpeed * Time.deltaTime, 0, 0);
        }
        
        
    }
}
