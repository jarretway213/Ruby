using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    /// Update is a method used to change the position of our character. It uses the following lines of code to execute this task.
    void Update()
    {
	
	float horizontal = Input.GetAxis("Horizontal");
	float vertical = Input.GetAxis("Vertical");
	//We have just created two new variables relating to the horizontal and vertical axes for Ruby to move on.
	    
		Vector2 position = transform.position;
		position.x = position.x + 3.0f * horizontal * Time.deltaTime;
		position.y = position.y + 3.0f * vertical * Time.deltaTime;
		transform.position = position;
    }
}
