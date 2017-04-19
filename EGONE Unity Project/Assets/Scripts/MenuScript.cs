using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void quitButton()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void startButton()
    {
        SceneManager.LoadScene(1);
    }

    public void creditsButton()
    {
        SceneManager.LoadScene(2);
    }

	public void controlsButton()
	{
		SceneManager.LoadScene(3);
	}
}
