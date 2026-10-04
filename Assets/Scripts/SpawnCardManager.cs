using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpawnCardManager : MonoBehaviour
{
    [SerializeField] private RectTransform[] allCard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCard(); // ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawncand and randomcard
    void SpawnCard()
    {
        float posX = 0f;
        for (int i = 0; i < 3;i++)
        {
            int index = Random.Range(0, allCard.Length);
            RectTransform card = Instantiate(allCard[index]);
            card.SetParent(transform, false);
            card.anchoredPosition = new Vector2(posX += 150f, 0f);
        }
    }
}
