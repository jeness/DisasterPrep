using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerWalk : MonoBehaviour {


    public TextMesh totalCoins;
    public float playerSpeed;
    public GameObject wall;
    public int count;
    public GameObject standHere;
    //public GameObject myPlayer;

    void start()
    {
        standHere.SetActive(false);
        //if(myPlayer == null)
        //{
        //    myPlayer = GameObject.FindWithTag("Player");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        //var vel = myPlayer.GetComponent<Rigidbody>().velocity;
        //AudioSource footstep = GetComponent<AudioSource>();
       // if (vel.magnitude != 0 && footstep.isPlaying == false)
       
        //{
            //footstep.volume = Random.Range(0.8f, 1);
            //footstep.pitch = Random.Range(0.8f, 1.1f);
        //    footstep.Play();
       //     footstep.enabled = true;
       //     footstep.loop = true;
       // }
       // if(vel.magnitude == 0)
       // {
       //     footstep.enabled = false;
       //     footstep.loop = false;
       // }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count++;
            totalCoins.text = count.ToString();
            if (count == 10)
            {
                wall.SetActive(false);
                standHere.SetActive(true);
            }
        }
    }
}
