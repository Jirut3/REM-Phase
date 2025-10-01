using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text textOB;
    public GameObject Activator;
    public GameObject ExtraDestroy;
    public string dialogue = "Dialogue";

    public float timer = 2f;



    void Start()
    {
        textOB.GetComponent<Text>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textOB.GetComponent<Text>().enabled = true;
            textOB.text = dialogue.ToString();
            StartCoroutine(DisableText());
        }
    }

    IEnumerator DisableText()
    {
        Destroy(ExtraDestroy);
        yield return new WaitForSeconds(timer);
        textOB.GetComponent<Text>().enabled = false;
        Destroy(Activator);
        

    }


}
