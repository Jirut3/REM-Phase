using System.Collections;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public AudioClip firstTrack;     // First background music track
    public AudioClip secondTrack;    // Second background music track

    public float firstTrackDuration; // Duration of the first track (if needed, but can also be calculated from the AudioClip itself)

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayBackgroundMusic());
    }

    // Coroutine to handle the background music playback
    IEnumerator PlayBackgroundMusic()
    {
        // Play the first background music (non-looping)
        audioSource.clip = firstTrack;
        audioSource.loop = false;  // Ensure the first track does not loop
        audioSource.Play();

        // Wait for the first track to finish
        yield return new WaitForSeconds(firstTrack.length);  // Wait based on the length of the first track

        // Play the second background music (looping)
        audioSource.clip = secondTrack;
        audioSource.loop = true;  // Set the second track to loop
        audioSource.Play();
    }
}
