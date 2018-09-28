using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public Rigidbody rb;

	public float speed = 1000;

	public void init()
	{
		

		rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
	}

	public void initialize()
	{

		if(!rb)
			rb = GetComponent<Rigidbody>();
		rb.isKinematic = false;
		rb.velocity = Vector3.zero;

		rb.AddForce(transform.forward * speed);
	}

	void OnCollisionEnter(Collision collision)
	{

		rb.isKinematic = true;

	}
}