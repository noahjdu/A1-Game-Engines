using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dr. Emmett Brown: Marty! I need you to go back with me!
/// Marty McFly: Where?
/// Dr.Emmett Brown: Back to the Points in Time throughout a queue!
/// </summary>
public class BackInTime : MonoBehaviour
{
	// Bool to keep track of when you are rewinding
	bool isRewinding = false;

	// This is the time in seconds to record
	public float recordTime = 5f;

	// Rigidbody. There's only a comment here because it looked weird without
	private Rigidbody rb;

	// temporalNodes is essentially a queue; adding and deleting points how you would in a queue
	private List<PointInTime> temporalNodes;

	void Start()
	{
		// Initialize components
		temporalNodes = new List<PointInTime>();
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		// Put the input in update
		if (Input.GetKeyDown(KeyCode.T))
			StartRewind();
		if (Input.GetKeyUp(KeyCode.T))
			StopRewind();
	}

	void FixedUpdate()
	{
		// The reason these are called in FixedUpdate() is because we're concerned with the physics
		if (isRewinding)
			Rewind();
		else
			Record();
	}

	
	// This function records the PiTs 
	void Record()
	{
		if (temporalNodes.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
			temporalNodes.RemoveAt(temporalNodes.Count - 1);

		temporalNodes.Insert(0, new PointInTime(transform.position, transform.rotation));
	}

	// This function goes through the queue sending the object this script is on to the previous points in time, up to the maximum amount of recorded seconds
	void Rewind()
	{
		if (temporalNodes.Count > 0)
		{
			PointInTime pointInTime = temporalNodes[0];
			transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
			temporalNodes.RemoveAt(0);
		}
		else
		{
			StopRewind();
		}

	}

	// It needs to be set to kinematic so that it doesn't have physics applied to it as it is
	public void StartRewind()
	{
		isRewinding = true;
		rb.isKinematic = true;
	}

	public void StopRewind()
	{
		isRewinding = false;
		rb.isKinematic = false;
	}
}