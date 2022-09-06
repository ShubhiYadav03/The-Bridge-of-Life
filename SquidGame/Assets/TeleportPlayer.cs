using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    // [SerializeField] GameObject TP_01;
    // [SerializeField] GameObject TP_02;
    // Vector3 TP_01Location;
    // Vector3 TP_02Location;
    // Start is called before the first frame update
    // void Start()
    // {
    //    // playerController = gameObject.GetComponent<PlayerController>();

    //     TP_01Location = TP_01.transform.position;
    //     TP_02Location = TP_02.transform.position;
        
    // }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);

        if(touch.phase == TouchPhase.Began){

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.name == "Glass"){

                    gameObject.transform.position = glass.transform.position;

                }else if(hit.transform.name == "Glass10"){
                    gameObject.transform.position = glass10.transform.position;
                }
            }

        }

        // if(Input.GetKeyDown("KeyCode.Alpha01")){

        // }



        // if(Input.GetKeyDown("KeyCode.Alpha01")){

        //     TeleportOurPlayer(TP_01Location);

        // }else if(Input.GetKeyDown("KeyCode.Alpha02")){

        //     TeleportOurPlayer(TP_02Location);

        // }

    }

    // void TeleportOurPlayer(Vector3 tPLocation){
    //     gameObject.transform.position = tPLocation;
    // }
}
