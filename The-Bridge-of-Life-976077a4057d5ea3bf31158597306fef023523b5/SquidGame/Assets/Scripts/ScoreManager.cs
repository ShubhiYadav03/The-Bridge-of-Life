using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public AudioSource squidgame;
    public AudioSource strongglass;
    public AudioSource weakglass;
    public AudioSource wronganswer;
    public AudioSource correct;
    public AudioSource wronganswerlifesaved;
    public int currentscore;
    private int currentLife;
    public TextMeshProUGUI scoretext;
    public GameObject leftButton;
    public GameObject rightButton;
    [SerializeField] private List<Image> lifeImageList;
    public GameObject loseText;
    public TextMeshProUGUI loseScore;

    public void updatescore(int score)
    {
        currentscore += score;
        scoretext.text = "Score: " + currentscore.ToString();
        Debug.Log("Score updated");
    }

    public int lifeCount(int lifeRemaining)
    {
        if (currentLife >= 3)
        {
            rightButton.SetActive(false);
            leftButton.SetActive(false);

            Debug.Log("Lost");
            //loseText.enabled = true;
            return currentLife;
        }
        reduceLife(currentLife);
        Debug.Log("Oops!");
        currentLife += lifeRemaining;
        
        return currentLife;
    }

    public void reduceLife(int index)
    {
        
        lifeImageList[index].enabled = false;
    }
}
