using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardList : MonoBehaviour
{
    public Sprite[] deck;
    public GameObject champImage;
    public GameObject challengerImage;

    private Image champImageComponent;
    private Image challengerImageComponent;

    // Start is called before the first frame update
    void Start()
    {
        champImageComponent = champImage.GetComponent<Image>();
        challengerImageComponent = challengerImage.GetComponent<Image>();

        AssignRandomImages();
    }

    public void Swap()
    {

        int randomIndex2 = Random.Range(0, deck.Length);

        champImageComponent.sprite = challengerImageComponent.sprite;
        if (deck.Length >= 1)
        {
          challengerImageComponent.sprite = deck[randomIndex2];
          RemoveSpriteAtIndex(randomIndex2);
        }
        else
        {
          Debug.Log("We're out");
        }



    }

    public void Keep()
    {
      if (deck.Length >= 1)
      {
        int randomIndex2 = Random.Range(0, deck.Length);
        challengerImageComponent.sprite = deck[randomIndex2];

        RemoveSpriteAtIndex(randomIndex2);
      }
      else
      {
        Debug.Log("We're out");
      }
    }

    private void AssignRandomImages()
    {
        if (deck.Length >= 2)
        {
            int randomIndex1 = Random.Range(0, deck.Length);
            int randomIndex2 = Random.Range(0, deck.Length);

            while (randomIndex1 == randomIndex2)
            {
                randomIndex2 = Random.Range(0, deck.Length); // Ensure randomIndex2 is different from randomIndex1
            }

            champImageComponent.sprite = deck[randomIndex1];
            challengerImageComponent.sprite = deck[randomIndex2];

            RemoveSpriteAtIndex(randomIndex1);
            RemoveSpriteAtIndex(randomIndex2);
        }
        else
        {
          Debug.Log("We're out");
        }
    }

    private void RemoveSpriteAtIndex(int index)
    {
        List<Sprite> deckList = new List<Sprite>(deck);
        deckList.RemoveAt(index);
        deck = deckList.ToArray();
    }
}
