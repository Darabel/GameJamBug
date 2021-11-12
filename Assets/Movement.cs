using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Collected collected;
    bool food;
    [SerializeField] float turnSpeed = 150f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        collected = GetComponent<Collected>();
        food = collected.hasFood;
        if (other.tag == "Food")
        {
            moveSpeed = slowSpeed;
        }   

        if (other.tag == "Home" && food)
        {
            moveSpeed = boostSpeed;
        }    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = normalSpeed;    
    }
}
