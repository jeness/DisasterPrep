using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    Vector3 spin;


    // Update is called once per frame
    void Update () {
        spin = new Vector3(2f, 2f, 0f);

        transform.Rotate(spin);
	}
}
