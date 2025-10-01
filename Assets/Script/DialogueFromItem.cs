using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class DialogueFromItem : MonoBehaviour
{
    public Text textOB;
    public GameObject Activator;
    public string dialogue = "Dialogue";

    public float timer = 2f;
    private bool hasPlayed = false;


    void Start()
    {
        hasPlayed = false;
        textOB.GetComponent<Text>().enabled = false;
    }

    void Update()
    {

        if (Activator.activeInHierarchy && !hasPlayed)
        {
            textOB.GetComponent<Text>().enabled = true;
            textOB.text = dialogue.ToString();
            StartCoroutine(DisableText());
            hasPlayed = true;
        }
    }

    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(timer);
        textOB.GetComponent<Text>().enabled = false;
        

    }


}
