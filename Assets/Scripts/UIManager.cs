using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
  public Animator startButton;
  public Animator instructionsButton;
  public Animator exitButton;
  public Animator dialog;
  public Animator contentPanel;

  public void OpenSettings()
{
    startButton.SetBool("isHidden", true);
    exitButton.SetBool("isHidden", true);
    instructionsButton.SetBool("isHidden", true);
    dialog.SetBool("isHidden", false);
}

public void CloseSettings()
{
    startButton.SetBool("isHidden", false);
    exitButton.SetBool("isHidden", false);
    instructionsButton.SetBool("isHidden", false);
    dialog.SetBool("isHidden", true);
}

public void StartGame()
    {
        SceneManager.LoadScene("Roll-a-ball");
    }

    public void CloseGame()
    {
      Application.Quit();
    }
}
