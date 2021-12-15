// using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void Back()
	{
		SceneManager.LoadScene(0);
	}
	public void QuiteGame()
	{
		Application.Quit();
	}
	public void RestartGame()
	{
		SceneManager.LoadScene(2);
	}
}