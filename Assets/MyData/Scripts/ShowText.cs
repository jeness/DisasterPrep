using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour {
    public GameObject textName;
    //Vector3 spinReverse;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //spinReverse = new Vector3(0f, 0f, 0f);

       // textName.transform.Rotate(spinReverse);
        
    }


    public void EnableText()
    {
        textName.SetActive(true);
        //Debug.Log("I am stay!");
    }

    public void DisableText()
    {
        textName.SetActive(false);
        //Debug.Log("I am out!");
    }
}
