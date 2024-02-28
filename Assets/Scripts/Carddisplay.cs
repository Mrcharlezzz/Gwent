using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Carddisplay : MonoBehaviour
{
    public List<Card> carddisplay=new List<Card>();
    public int displayId; // this will allow me to display different cards from the inspector in the same Card GameObject
    //References to class Card
    public int id;
    public string cardname;
    public Sprite image;
    public Card.Type type;
    public string carddescription;
    public Card.Faction faction;
    public bool Displayatk {get{
        if(atk<0)
            return false;
        else
            return true;
    }}

    public int atk;
    public Card.Position position;

    //References to GameObject

    public TextMeshProUGUI nameText;
    public Image CardImage;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI carddescriptionText;
    public TextMeshProUGUI posText;
    public TextMeshProUGUI atkText;
    public Image borderseparation;

    
    // Start is called before the first frame update
    void Start()
    {
        carddisplay.Add(CardDatabase.cardlist[displayId]);
        id= carddisplay[0].id;
        cardname= carddisplay[0].cardname;
        image= carddisplay[0].image;
        type= carddisplay[0].type;
        carddescription= carddisplay[0].carddescription;
        faction= carddisplay[0].faction;
        atk= carddisplay[0].atk;
        position= carddisplay[0].position;

        nameText.text=cardname;
        carddescriptionText.text=carddescription;
        typeText.text=type.ToString();
        atkText.text=atk.ToString();
        posText.text=position.ToString();
        CardImage.sprite=image;
    }

    // Update is called once per frame
    void Update()
    {
        if(Displayatk)
        {
            atkText.gameObject.SetActive(true);
            borderseparation.gameObject.SetActive(true);
        }
        else
        {
            atkText.gameObject.SetActive(false);
            borderseparation.gameObject.SetActive(false);
        }
    }
}
