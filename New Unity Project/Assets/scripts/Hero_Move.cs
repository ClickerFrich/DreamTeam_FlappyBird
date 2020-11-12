using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Move : MonoBehaviour
{
    public GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Если нажать на экран, то пишет  "Jump"
   
        if (Input.touchCount > 0)
        {
                print("Jump"); 
        }
        */

        if (Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
        {
            if (isUp)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                isUp = false;
            }
            else
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                isUp = true;
            }
        }
    }
}
