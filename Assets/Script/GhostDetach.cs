using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GhostDetach : MonoBehaviour
{
    public GameObject KeyItem;  // The item to trigger the ghost detachment
    public GameObject Ghost;    // The ghost object that is attached to the player
    private GameObject player;
    private Transform initialParent; // To store the initial parent (player)
    public FirstPersonMovement playerMovement;

    public bool inReach;
    public AudioSource audioSource;    
    
    public Text textOB;
    public string dialogue = "Dialogue";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            TriggerActions();
        }
    }
    void Start()
    {
       
        initialParent = Ghost.transform.parent;
    }

    void Update()
    {
    
        if (KeyItem.activeInHierarchy)
        {
            DetachGhostFromPlayer();
            player = GameObject.FindWithTag("Player");
            player.GetComponent<FirstPersonMovement>().enabled = false;
        }
    }

  
    void DetachGhostFromPlayer()
    {
        Ghost.transform.SetParent(null); 
       
    }
    void TriggerActions()
    {
       
        if (audioSource != null)
        {
            audioSource.Play();
        }


        textOB.GetComponent<Text>().enabled = true;
        textOB.text = dialogue.ToString();
        StartCoroutine(DisableText());

       


        player.GetComponent<FirstPersonMovement>().enabled = true;
        Destroy(Ghost);

    }
    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(2);
        textOB.GetComponent<Text>().enabled = false;


    }




}
