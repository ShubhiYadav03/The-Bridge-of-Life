using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{

    public float waitTime = 54f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waitforsec());
    }

    IEnumerator Waitforsec(){
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(2);
    }
    
    // Update is called once per frame
  
}
