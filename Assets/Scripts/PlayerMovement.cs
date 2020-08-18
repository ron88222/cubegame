using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	//reference to RigidBody component called rb
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	private bool left = false;
	private bool right = false;
	/*
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
		//rb.useGravity = false;
		
    }
	*/

    // Update is called once per frame
	//checking inputs in update rather than fixed update as to not miss/delay user inputs
	void Update()
	{
		left = Input.GetKey("a");
		right = Input.GetKey("d");
	}
	
	//FixedUpdate is better for physics objects in unity
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //adds force on z axis
		
		if(right)
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
		}
		if(left)
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
		}
		
		//if falls below platform
		if(rb.position.y < -1f) 
		{
			FindObjectOfType<GameManager>().EndGame();
		}
    }
}
