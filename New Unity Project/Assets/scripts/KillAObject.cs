using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
  void OnCollisionEnter(Collision myCollision)
  {
       //string s = myCollision.gameObject.name


     // myCollision.gameObject.AddComponent(Rigidbody);
      Debug.Log(s + "2");
     // Destroy(myCollision.gameObject.name)



  }


 


  void OnCollisionEnter(Collision myCollision) 
  {
     // myCollision.gameObject.AddComponent(Rigidbody);
      //Destroy(myCollision.gameObject.name);
          //Destroy(GameObject.Find("dust(clone)"));
  }
   */

    void OnTriggerEnter(Collider other)
    {
        //Destroy(myCollision.gameObject.name);
        Debug.Log(other.gameObject.name);
        var ObjectBonus1 = GameObject.Find(other.gameObject.name);
        Destroy(ObjectBonus1);
    }
}
