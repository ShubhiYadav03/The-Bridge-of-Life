using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpOnTrigger : MonoBehaviour
{
    public GameObject questionImg;
         // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                questionImg.SetActive(true);
            }
        }


        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                questionImg.SetActive(false);
               
            }
        }
}