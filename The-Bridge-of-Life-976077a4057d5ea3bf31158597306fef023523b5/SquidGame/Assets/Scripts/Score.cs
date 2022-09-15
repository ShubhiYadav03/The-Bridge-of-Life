using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    [SerializeField] private string ScoreEndpoint = "http://127.0.0.1:13098/score";
    [SerializeField] private ScoreManager sm;

  
  private string userText;

  public void OnEndClick()
    {

        StartCoroutine(GetScore());
    }

    private IEnumerator GetScore()
    {

        string username  = Login.uname;
        string score = sm.currentscore.ToString();
        

        WWWForm form = new WWWForm();
        form.AddField("rUsername", username);
        form.AddField("rScore", score);

        UnityWebRequest request = UnityWebRequest.Post(ScoreEndpoint, form);
        var handler = request.SendWebRequest();

        float startTime = 0.0f;
        while (!handler.isDone)
        {
            startTime += Time.deltaTime;

            if (startTime > 10.0f)
            {
                break;
            }
            yield return null;
        }

        if (request.result == UnityWebRequest.Result.Success)
        {
            LoginResponse response = JsonUtility.FromJson<LoginResponse>(request.downloadHandler.text);

            if (response.code == 0) //login success for game?
            {
                Debug.Log("Score saved");
            }
            else
            {
                switch (response.code)
                {
                    case 1:
                        Debug.Log("Invalid credidential");
                         Debug.Log(username);
                      
                        Debug.Log(score);
                      
                        break;
                    default:
                        Debug.Log("Corruption detected");
                        break;
                }
            }

        }
        else
        {
            Debug.Log("Error connecting to server...");
        };

        yield return null;
    }
}