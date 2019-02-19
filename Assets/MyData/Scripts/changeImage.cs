using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeImage : MonoBehaviour {

    // Use this for initialization
    private GameObject[] images;
    private int len;
    
    // Starting in 0 seconds.
    // a projectile will be launched every 0.3 seconds
    void Start()
    {
        //if(images == null)
        //{
            
            images = GameObject.FindGameObjectsWithTag("TVImage");
            len = images.Length;
        //}

        
        InvokeRepeating("LaunchProjectile", 0f, 1.5f);
    }

    void LaunchProjectile()
    {
        foreach (GameObject image in images)
        {
            image.SetActive(false);
        }
        int index = Random.Range(0, len);
        images[index].SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
