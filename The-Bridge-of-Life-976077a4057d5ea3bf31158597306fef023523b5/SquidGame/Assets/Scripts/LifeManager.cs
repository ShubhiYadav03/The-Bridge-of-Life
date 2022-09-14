using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeManager : MonoBehaviour
{
    //private GameObject myButton;
    public TMP_InputField answer;
    public string actualAns;
    public GameObject glass;
    //public MouseLook mouse;
    public GameObject questionImg;
    //public AudioSource Door1_3;
    //public AudioSource Correct;
    //public AudioSource Incorrect;
    private int scoreCount=20;
    private int lifeRemaining=1;
    //public Text scoreText;
    //public Text winText;

   // public string strength;
    public bool strong=true;
    [SerializeField] private ScoreManager sm;
 
    string input;
    public Rigidbody rb;
    private void Start()
    {
        rb.useGravity = false;
        rb = GetComponent<Rigidbody>();
    }
    public void EnableGravity()
    {
        rb.useGravity = true;
    }

    /*public void start(){
        scoreCount=0;
        lifeRemaining=3;
        //winText.text="";
    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sm.leftButton.SetActive(false);
            sm.rightButton.SetActive(false);
            questionImg.SetActive(true);
        }
    }
    public void onSubmit()
    { 

        //myButton = gameObject.GetComponent<Button>(); 
        input = answer.text.ToString(); 
        questionImg.SetActive(false);
        sm.leftButton.SetActive(true);
        sm.rightButton.SetActive(true);
        if(strong){
            if (input.ToUpper() == actualAns.ToUpper())
            {
                //Correct.Play();
                sm.updatescore(scoreCount);
                //scoreText.text="Score"+scoreCount;
                //door.SetActive(false);
             //   questionImg.SetActive(false);
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
               // questionImg.SetActive(false);

                //Incorrect.Play();
                /*if(lifeRemaining<=0){
                    winText.text="Game Over!!";
                }*/
            }
        }
        else{
            if (input.ToUpper() == actualAns.ToUpper())
            {
                //Correct.Play();
                //scoreCount+=20;
                //scoreText.text="Score"+scoreCount;
                //glass.SetActive(false);
               // questionImg.SetActive(false);
                Debug.Log("You did it!");
                // MyAnimationController.SetBool("open", true);
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false;
                //mouse.enabled = true;
                //Door1_3.Play();
            }
            else
            {
                if (sm.lifeCount(lifeRemaining) >= 3)
                {
                    EnableGravity();
                    sm.rightButton.SetActive(false);
                    sm.leftButton.SetActive(false);
                    //questionImg.SetActive(false);
                    glass.SetActive(false);
                }
               // questionImg.SetActive(false);
                Debug.Log(input.ToUpper());
                Debug.Log(actualAns.ToUpper());
                //Incorrect.Play();
                
            }
           
        }
        
    }

}

