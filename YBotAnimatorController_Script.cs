using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBotAnimatorController_Script : MonoBehaviour {
    static Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isForward", true);
        }
        else
        {
            anim.SetBool("isForward", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isBackward", true);
        }
        else
        {
            anim.SetBool("isBackward", false);
        }

	}
}
