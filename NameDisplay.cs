using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameDisplay : MonoBehaviour
{
  public Image imageComponent;

  public TextMeshProUGUI nameDisplayText; // Reference to the TextMeshPro Text object

    void Update()
    {
        // Get the Image component attached to this GameObject
        imageComponent = GetComponent<Image>();

        if (imageComponent == null)
        {
            Debug.LogError("No Image component found on this GameObject.");
            return;
        }

        // Get the sprite assigned to the Image component
          Sprite sprite = imageComponent.sprite;

          if (sprite == null)
          {
              Debug.LogError("No sprite assigned to the Image component.");
              return;
          }

          // Display the name of the sprite in the UI Text object
          if (nameDisplayText != null)
          {
              nameDisplayText.text =  sprite.name;
          }
          else
          {
              Debug.LogError("No UI Text object assigned to 'NameDisplay'.");
          }
      }
}
