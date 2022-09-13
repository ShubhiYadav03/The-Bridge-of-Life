using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    private int currentscore;
    private int currentLife;
    public Text scoretext;
    [SerializeField] private List<Image> lifeImageList;
    public TextMeshProUGUI loseText;
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
            Debug.Log("Lost");
            loseText.enabled = true;
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
