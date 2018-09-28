using UnityEngine;

// This class is meant to hold position and rotation at a given time
public class PointInTime : MonoBehaviour
{
	public Vector3 position;
	public Quaternion rotation;

	public PointInTime(Vector3 pos, Quaternion rot)
	{
		position = pos;
		rotation = rot;
	}
}
