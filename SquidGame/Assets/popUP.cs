using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUP : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject  question;
        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                question.SetActive(true);
            }
        }


        //      void OnTriggerExit(Collider other)
        // {
        //     if (other.CompareTag("Player"))
        //     {
        //         question.enabled = false;
              
        //     }
        // }

       



       
        
    }

