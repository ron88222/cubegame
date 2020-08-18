using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameEnd = false;
	public float restartDelay = 3f;
	public GameObject completeLevelUI;
	
	
	public void EndGame()
	{
		if(gameEnd == false)
		{
			gameEnd = true;
			Debug.Log("game over");
			
			//restart game
			Invoke("Restart", restartDelay);// calls function in defined time
			//Restart();
		}
	}
	
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}
	
}
