using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AmaneCheage : MonoBehaviour
{
    private Animator anim;
    private AnimatorStateInfo currentState;
    private AnimatorStateInfo previousState;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
	}
	
	// Update is called once per frame
	void OnGUI ()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            anim.SetBool("Jab", true);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            anim.SetBool("ScrewKick", true);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            anim.SetBool("Spinkick", true);
        }
        //if (GUI.Button(new Rect(Screen.width - 90, 180, 100, 20), "Land"))
        //    anim.SetBool("Land", true);
    }
}
