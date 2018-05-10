using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class FightChange : MonoBehaviour
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
	void Update ()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.X))
        {
            anim.SetBool("Spinkick", true);
        }
        if (Input.GetKey(KeyCode.C))
        {
            anim.SetBool("Rising_P", true);
        }
        //if (GUI.Button(new Rect(Screen.width - 190, 180, 100, 20), "Land"))
        //    anim.SetBool("Land", true);
    }
}
