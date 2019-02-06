using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;
    public GameObject particle;
    public Material enableColor, disableColor;

    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(transform.position.x,1.28f, transform.position.z);
    }

    public void TeleportEnable()
    {
        GetComponent<Renderer>().material = enableColor;
        particle.SetActive(true);
    }

    public void TeleportDisable()
    {
        GetComponent<Renderer>().material = disableColor;
        particle.SetActive(false);
    }
}
