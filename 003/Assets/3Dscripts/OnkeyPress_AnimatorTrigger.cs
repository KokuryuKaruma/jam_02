using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnkeyPress_AnimatorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
 public string pushKey ="space";
    public string triggerName = "";

    bool pushFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(pushKey))
        {
            if (pushFlag == false)
            {
                pushFlag = true;

                Animator m_Animator = gameObject.GetComponent<Animator>();
                m_Animator.SetTrigger(triggerName);
            }
        }
        else
        {
            pushFlag = false;
        }
    }
}
