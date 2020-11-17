using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	
	public GameObject objects;
	public int numberOfObjects;
	bool creats_On_Or_off = true;

	float timeToWait;

	void FixedUpdate()
	{
        if (creats_On_Or_off)
        {
			creats_On_Or_off = false;
			Add();
		    
		}
	}

	void Add() 
	{
		numberOfObjects = Random.Range(1, 5);

		//Debug.Log(numberOfObjects + "-" + "numberOfObjects");


		timeToWait = 2.0f;
		StartCoroutine(Waiting());
		for (int i = 0; i < numberOfObjects; i++)
        {
			int a = Random.Range(0, 2);

			if (a == 1)
			{
				objects.transform.localPosition = new Vector3(16, -2.56f, 0);
				//objects.transform.localScale = new Vector3(3f, 3f, 3f);
			}

			else
			{
				objects.transform.localPosition = new Vector3(16, 2.56f, 0);
			}
			objects = Instantiate(objects, objects.transform.position, Quaternion.identity) as GameObject;
		}

		//Thread.Sleep(6);
		//StartCoroutine(13);

		timeToWait = 95.0f;
		StartCoroutine(Waiting());
		

	}

	IEnumerator Waiting()
	{
		yield return new WaitForSeconds(timeToWait);
		creats_On_Or_off = true;
		
	}
}
