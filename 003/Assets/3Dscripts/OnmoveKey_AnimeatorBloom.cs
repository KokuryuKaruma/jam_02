using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnmoveKey_AnimeatorBloom : MonoBehaviour
{
    // Start is called before the first frame update
   public string parameterName = "";

    // Update is called once per frame
    void Update()
    {
        bool pushFlag = false;
        if (Input.GetKey("up"))
        {
            pushFlag = true ;
        }
        if (Input.GetKey("down"))
        { 
            pushFlag = true;
        }
        if (Input.GetKey("right"))
        {
            pushFlag =true;
        }
        if (Input.GetKey("left"))
        {
            pushFlag = true;
        }

        Animator m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool(parameterName,pushFlag);
    }
}
