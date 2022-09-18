using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] private string ScoreEndpoint = "https://bol-server.onrender.com/score";
    [SerializeField] private ScoreManager sm;


    private string userText;

    public void OnEndClick()
    {
        StartCoroutine(GetScore());
        SceneManager.LoadScene(4);
    }

    private IEnumerator GetScore()
    {

        string username = Login.uname;
        string score = sm.currentscore.ToString();

        //WWWForm form = new WWWForm();
        //form.AddField("rUsername", username);
        //form.AddField("rScore", score);

        UnityWebRequest request = UnityWebRequest.Get($"{ScoreEndpoint}?rUsername={username}&rScore={score}");
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
            Debug.Log($"{username} : {score}");
        }
    }
}