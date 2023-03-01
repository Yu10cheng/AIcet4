using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour

{
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	public float speed = 20f;
	
	/*
    void Update()
    {
		if(Input.GetKey(KeyCode.D))
		{
			//delta time, keep movement the same across framerates
			Vector3 playerPosition = transform.position;
			playerPosition.x += speed * Time.deltaTime;
			
			//Transform
			
			transform.position = playerPosition;
		}
			if(Input.GetKey(KeyCode.W))
		{
			Vector3 playerPosition = transform.position;
			playerPosition.y += speed * Time.deltaTime;	
			transform.position = playerPosition;
		}
	
						
    }
	*/
	void Update()
	{
		//between -1 to 1
		float horizontal = Input.GetAxis("Horizontal");
		
		float vertical = Input.GetAxis("Vertical");
		
		Camera camera = Camera.main;
		
		Vector3 forward = camera.transform.forward;
		Vector3 right = camera.transform.right;
		
		forward.y = 0f;
		right.y = 0f;
		forward.Normalize();
		right.Normalize();
		
		Vector3 desiredMoveDirection = (forward * vertical) + (right * horizontal);
		desiredMoveDirection. Normalize();
		
		//Vector3 moveDirection = new Vector3(vertical,0f,horizontal);
		transform.position += desiredMoveDirection * speed * Time.deltaTime;
	}
}
