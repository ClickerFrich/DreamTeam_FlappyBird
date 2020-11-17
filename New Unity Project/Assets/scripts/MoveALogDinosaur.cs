using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveALogDinosaur : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody rb;

    public bool life = true;
   // public float horizoontalInput = 15f

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Destroy(gameObject, 5.3f); удаление обьекта

    }

    void FixedUpdate()
    {
        if (life)
        {
            rb.AddForce(new Vector2(-1 * speed * Time.deltaTime, 0));
        }
        
    }
}


