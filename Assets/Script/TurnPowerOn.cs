using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPowerOn : MonoBehaviour
{
    
    public GameObject invOB;
    public GameObject[] lights;

    public GameObject text;
    public GameObject DestroyObj
        ;
    public bool powerIsOn;

    private bool inReach;

    void Start()
    {

        foreach (GameObject ob in lights)
        {
            ob.SetActive(false);
        }

        text.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && !powerIsOn)
        {
            inReach = true;
            text.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            text.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && inReach)
        {
            Destroy(DestroyObj);
            invOB.SetActive(true);
            powerIsOn = true;
        }

        if(powerIsOn)
        {
            foreach (GameObject ob in lights)
            {
                ob.SetActive(true);
            }

            inReach = false;
            text.SetActive(false);
        }

        if (!powerIsOn)
        {
            foreach (GameObject ob in lights)
            {
                ob.SetActive(false);
            }

        }

    }
}
