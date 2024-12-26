using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxController : MonoBehaviour
{
    public Animator boxAnimator; // Reference to the Animator component on the Boxopening GameObject
    public Button openButton;    // Reference to the Open button
    public Button closeButton;   // Reference to the Close button
    public ParticleSystem confettiParticle;   // Reference to the Close button

    void Start()
    {
        // Play the Box_Intro animation initially
        boxAnimator.Play("Box_Intro");

        // Set up button listeners
        openButton.onClick.AddListener(OpenBox);
        closeButton.onClick.AddListener(CloseBox);

        // Ensure buttons are in the correct initial state
        openButton.gameObject.SetActive(true); // Open button is visible
        closeButton.gameObject.SetActive(false); // Close button is hidden
    }

    void OpenBox()
    {
        if (confettiParticle.isPlaying)
        {
            confettiParticle.Stop();
        }
        // Trigger the Box_Open animation
        boxAnimator.SetTrigger("Open");
        
        // Switch button visibility
        openButton.gameObject.SetActive(false); // Hide Open button
        closeButton.gameObject.SetActive(true); // Show Close button
    }
    
    void CloseBox()
    {
        // Trigger the Box_Close animation
        boxAnimator.SetTrigger("Close");

        // Switch button visibility
        closeButton.gameObject.SetActive(false); // Hide Close button
        openButton.gameObject.SetActive(true); // Show Open button
    }
}
