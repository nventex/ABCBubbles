using UnityEngine;

public class Mover : MonoBehaviour 
{
	void Update()
	{
		rigidbody.velocity = transform.up;
	}	
}
