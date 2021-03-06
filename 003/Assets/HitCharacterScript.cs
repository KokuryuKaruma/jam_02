using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCharacterScript : MonoBehaviour
{
    GameObject scoreObject;
    public AudioClip sound;

    void Start()
    {
        scoreObject = GameObject.Find("ScoreSystem");
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            scoreObject.GetComponent<ScoreScripts>().AddScore();
            Destroy(gameObject);
        }
    }
}
