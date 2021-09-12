using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCharacterScript : MonoBehaviour
{
    GameObject scoreObject;

    void Start()
    {
        scoreObject = GameObject.Find("ScoreSystem");
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            scoreObject.GetComponent<ScoreScripts>().AddScore();
            Destroy(gameObject);
        }
    }
}
