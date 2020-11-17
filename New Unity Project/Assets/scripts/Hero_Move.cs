using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Hero_Move : MonoBehaviour
{
    public float JumpForce = 0.25f;
    public float fall = 0.11f;

    //что бы эта переменная работала добавьте тэг "Ground" на вашу поверхность земли
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // обратите внимание что все действия с физикой 
    // необходимо обрабатывать в FixedUpdate, а не в Update
    void FixedUpdate()
    {
       
        JumpLogic();
    }


    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rb.AddForce(Vector3.up * JumpForce);

            // Обратите внимание что я делаю на основе Vector3.up 
            // а не на основе transform.up. Если персонаж упал или 
            // если персонаж -- шар, то его личный "верх" может 
            // любое направление. Влево, вправо, вниз...
            // Но нам нужен скачек только в абсолютный вверх, 
            // потому и Vector3.up
        }
        else 
        {
            rb.AddForce(Vector3.down * fall);
        }
    }
}
