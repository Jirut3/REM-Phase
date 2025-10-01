using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartingScreen : MonoBehaviour
{
    private GameObject player;
    public GameObject startingScreen;

    public float waitTime;


    public FirstPersonMovement playerMovement;

    void Start()
    {
        startingScreen.SetActive(true);
        player = GameObject.FindWithTag("Player");
        player.GetComponent<FirstPersonMovement>().enabled = false;

        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        startingScreen.SetActive(false);
        player.GetComponent<FirstPersonMovement>().enabled = true;

    }

   


        void Update()
    {
        
    }
}
