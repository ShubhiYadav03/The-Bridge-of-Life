using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuManager : MonoBehaviour
{

    public Button playButton;
    //public GameSettings settings;

    public void OnPlayPressed()
    {
        //SoundManager.GetInstance().PlaySmashSound();
        StartCoroutine("LaunchGame");
        playButton.interactable = false;
    }

    public void OnQuitPressed()
    {
        //SoundManager.GetInstance().PlaySmashSound();
        Application.Quit();
    }

    public IEnumerator LaunchGame()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadSceneAsync(3);
    }
}
