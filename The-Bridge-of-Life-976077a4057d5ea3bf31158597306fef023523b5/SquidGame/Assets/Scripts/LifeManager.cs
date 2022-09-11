using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeManager : MonoBehaviour
{
    public TMP_InputField answer;
    public string actualAns;
    public GameObject glass;
    //public MouseLook mouse;
    public GameObject questionImg;
    //public AudioSource Door1_3;
    public AudioSource Correct;
    public AudioSource Incorrect;
    private int scoreCount=0;
    private int lifeRemaining=3;
    public Text scoreText;
    //public Text winText;
    [SerializeField] private List<Image> lifeImageList;
   // public string strength;
    public bool strong=true;

    string input;

    public void startGame(){
        scoreCount=0;
        lifeRemaining=3;
        //winText.text="";
    }
     public void reduceLife(int index){
        lifeImageList[index].enabled=false;
    }
    public void onSubmit()
    {
        input = answer.text.ToString(); 
        if(strong){
            if (input.ToUpper() == actualAns.ToUpper())
            {
                Correct.Play();
                scoreCount+=20;
                scoreText.text="Score"+scoreCount;
                //door.SetActive(false);
                questionImg.SetActive(false);
                Debug.Log("You did it!");
                // MyAnimationController.SetBool("open", true);
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false;
                //mouse.enabled = true;
                //Door1_3.Play();
            }
            else
            {
                
                Debug.Log(input.ToUpper());
                Debug.Log(actualAns.ToUpper());
                Incorrect.Play();
                /*if(lifeRemaining<=0){
                    winText.text="Game Over!!";
                }*/
            }
        }
        else{
            if (input.ToUpper() == actualAns.ToUpper())
            {
                Correct.Play();
                //scoreCount+=20;
                //scoreText.text="Score"+scoreCount;
                //glass.SetActive(false);
                questionImg.SetActive(false);
                Debug.Log("You did it!");
                // MyAnimationController.SetBool("open", true);
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false;
                //mouse.enabled = true;
                //Door1_3.Play();
            }
            else
            {

                lifeRemaining--;
                reduceLife(lifeRemaining);
                Debug.Log(input.ToUpper());
                Debug.Log(actualAns.ToUpper());
                Incorrect.Play();
                if(lifeRemaining<=0){
                  //  winText.text="Game Over!!";
                    glass.SetActive(false);
                }
            }
        }
    }

}

