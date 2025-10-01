using UnityEngine;

public class DoorKnockEvent : MonoBehaviour
{
    public GameObject KeyItem;
    public AudioSource SoundEffect;

    // Flag to prevent the sound from playing multiple times
    private bool hasPlayed = false;

    void Start()
    {
        // Ensure the audio doesn't play initially
        hasPlayed = false;
    }

    void Update()
    {
      
        if (KeyItem.activeInHierarchy && !hasPlayed)
        {
            // Play the sound and set the flag to prevent multiple plays
            SoundEffect.Play();
            hasPlayed = true;

           
        }
    }
}
