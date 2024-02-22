using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Deck
{
    private List<Card>deckcards;

   

    public Deck(List<Card>deckcards)
    {
        this.deckcards=deckcards;
    }
    public Deck()
    {
        deckcards= new List<Card>();
    }
    public void Addcard(Card card)
    {
        
    }
    public void Removecard(Card card)
    {
        deckcards.Remove(card);
    }
    

}
