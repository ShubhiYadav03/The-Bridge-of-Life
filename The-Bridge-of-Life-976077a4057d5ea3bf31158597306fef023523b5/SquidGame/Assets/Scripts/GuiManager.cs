using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiManager : MonoBehaviour
{
    public GameObject menuDialogBox;

    private bool showMenuDialogBox;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            ToggleMenuDialogBox();
        }
    }

    public void ToggleMenuDialogBox()
    {
        //SoundManager.GetInstance().PlaySmashSound();
        showMenuDialogBox = !showMenuDialogBox;
        menuDialogBox.SetActive(showMenuDialogBox);
    }

    public void OnConfirmMenu()
    {
        SceneManager.LoadSceneAsync("menu");
    }
}
