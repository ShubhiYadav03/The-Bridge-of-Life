//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private List<GameObject> leftGlasses;
    [SerializeField] private List<GameObject> rightGlasses;
    private int leftRow = 0;
    private int rightRow = 0;
    public GameObject player;
    public GameObject winImg;
    public TextMeshProUGUI winScore;
    [SerializeField] private ScoreManager sm;
    public Animator camAnimate;
    public Animator DoorAnimate;

    public void onSubmitLeft()
    {
        if(leftRow == 10){
            sm.rightButton.SetActive(false);
            sm.leftButton.SetActive(false);
            camAnimate.SetTrigger("Win");
            DoorAnimate.SetTrigger("Open");
            Invoke("Win", 5);
        }
        player.transform.position = leftGlasses[leftRow].transform.position;
        leftRow++;
        rightRow++;
    }

    public void onSubmitRight()
    {
        if(rightRow == 10){
            sm.rightButton.SetActive(false);
            sm.leftButton.SetActive(false);
            Invoke("Win", 2);
        }
        player.transform.position = rightGlasses[rightRow].transform.position;
        leftRow++;
        rightRow++;
    }

    void Win(){
        winScore.text = "Total Score : "+ sm.currentscore.ToString();
        winImg.SetActive(true);
    }

}

// public Vector3 jump;
// public float jumpForce = 2.0f;

// public bool isGrounded;
// Rigidbody rb;

// void Start()
// {
//     rb = GetComponent<Rigidbody>();
//     jump = new Vector3(1.0f, 5.0f, 0.0f);

// }

// void OnCollisionStay()
// {
//     isGrounded = true;
// }

// void Update()
// {
//     if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
//     {

//         rb.AddForce(jump * jumpForce, ForceMode.Impulse);
//         isGrounded = false;
//     }

//     if (Input.GetKey(KeyCode.UpArrow))
//     {
//         transform.Translate(Vector3.forward);
//     }

//     if (Input.GetKey(KeyCode.DownArrow))
//     {
//         transform.Translate(Vector3.back);
//     }
//     if (Input.GetKey(KeyCode.LeftArrow))
//     {
//         transform.Translate(Vector3.left);
//     }
//     if (Input.GetKey(KeyCode.RightArrow))
//     {
//         transform.Translate(Vector3.right);
//     }

// }




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
// }
