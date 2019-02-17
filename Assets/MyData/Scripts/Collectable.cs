using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

    Vector3 spin;
    public GameObject text;
    public GameObject myLight;
    public Quaternion textRotation;

    private void Start()
    {
        textRotation = text.transform.rotation;
    }
    // Update is called once per frame
    void Update () {
        if (text.activeSelf == true)
        {
            text.transform.rotation = textRotation;
            myLight.SetActive(true);
            spin = new Vector3(1f, 1f, 0f);
            transform.Rotate(spin);
            text.transform.rotation = textRotation;
        }
        if(text.activeSelf == false)
        {
            myLight.SetActive(false);
            spin = new Vector3(2f, 2f, 0f);
            transform.Rotate(spin);
        }

	}

   


}
