using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeToggle : MonoBehaviour
{

  public AudioSource audioSource; // Reference to the AudioSource component
    public Sprite playSprite; // The sprite to display when audio is playing
    public Sprite pauseSprite; // The sprite to display when audio is paused
    private bool isAudioPlaying = false; // Track the audio state

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial sprite based on the initial audio state
        UpdateButtonImage();
    }

    // Function to toggle the audio source state
    public void ToggleAudioSource()
    {
        if (audioSource != null)
        {
            isAudioPlaying = !isAudioPlaying; // Toggle the audio state

            if (isAudioPlaying)
            {
                audioSource.Play(); // Play the audio
            }
            else
            {
                audioSource.Pause(); // Pause the audio
            }

            UpdateButtonImage(); // Update the button image based on the new audio state
        }
    }

    // Function to update the button image based on the audio state
    private void UpdateButtonImage()
    {
        // Get the Button component
        Button button = GetComponent<Button>();

        if (button != null)
        {
            // Get the Image component of the button
            Image buttonImage = button.GetComponent<Image>();

            if (buttonImage != null)
            {
                // Set the button's image based on the audio state
                buttonImage.sprite = isAudioPlaying ? pauseSprite : playSprite;
            }
        }
    }
}
