using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class HealCard : Card // INHERITANCE
{
    [SerializeField] private string nameCard = "Heal"; // ENCAPSULATION
    //[SerializeField] private float damage = 5f;

    // POLYMORPHISM
    public override void playCard()
    {
        Debug.Log($"Use| {nameCard}");
    }

    // POLYMORPHISM
    public override void OnPointerClick(PointerEventData eventData)
    {
        playCard();
    }

}
