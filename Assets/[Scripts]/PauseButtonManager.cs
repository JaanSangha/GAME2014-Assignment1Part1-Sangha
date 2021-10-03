using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonManager : MonoBehaviour
{

    public GameObject ResumeButton;
    public GameObject ControlsButton;
    public GameObject ExitButton;
    public GameObject EndButton;
    public GameObject BlurScreen;


    public void OnPauseButtonPressed()
    {
        Time.timeScale = 0;
        ResumeButton.SetActive(true);
        ControlsButton.SetActive(true);
        ExitButton.SetActive(true);
        EndButton.SetActive(true);
        BlurScreen.SetActive(true);
    }
    public void OnResumeButtonPressed()
    {
        ResumeButton.SetActive(false);
        ControlsButton.SetActive(false);
        ExitButton.SetActive(false);
        EndButton.SetActive(false);
        BlurScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExitButtonPressed()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void OnEndButtonPressed()
    {
        SceneManager.LoadScene("End");
    }


}
