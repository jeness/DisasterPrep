using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCtrl : MonoBehaviour {

    public PlayerGrab player;

	// Use this for initialization
	void Start () {
        player.GetComponent<PlayerGrab>();
	}
	
	public void InHands()
    {
        if (transform.parent.CompareTag("Hands"))
        {
            player.enabled = true;
        } else
        {
            player.enabled = false;
        }

    }
}
