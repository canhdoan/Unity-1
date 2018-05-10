using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chengecamera : MonoBehaviour
{

    //たかがﾒｲﾝｶﾒﾗを記述するだけだ!
    [SerializeField] private GameObject mainCamera;

    //切り替え亀
    [SerializeField] private GameObject otherCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		//1ｷｰでｶﾒﾗ切り替え
        if(Input.GetKeyDown("1"))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            otherCamera.SetActive(!otherCamera.activeSelf);
        }
	}
}
