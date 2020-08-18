using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager gameManager;
	
    void OnTriggerEnter(Collider c)
	{
		if(c.tag == "Player")
		{
			gameManager.CompleteLevel();
		}

	}

}
