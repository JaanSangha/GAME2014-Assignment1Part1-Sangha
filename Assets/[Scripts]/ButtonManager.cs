using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        Debug.Log(activeScene.name);
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnBackButtonPressed()
    {
        if( SceneManager.GetActiveScene().name == "Main")
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }

    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene("Start");
    }
}
