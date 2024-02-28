using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor.VersionControl;
using UnityEngine;

public class CardDatabase: MonoBehaviour
{   
    public static List<Card> cardlist =new List<Card>()
    {
        new Card(0,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(1,"Julio Cesar",Resources.Load<Sprite>("Ramses2"),Card.Type.Leader,"Padre del imperio romano\n Efecto: +2 de poder para el ejército y en caso de empate garantiza la victoria",Card.Faction.Rome,-1,-1,Card.Position.L),
        new Card(2,"Alejandro Magno",Resources.Load<Sprite>("Ramses2"),Card.Type.Leader,"Lider de los griegos(cambiar)\n Efecto: 1 vez por ronda roba una carta del mazo",Card.Faction.Greece,-1,-1,Card.Position.L),
        new Card(3,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(4,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(5,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(6,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(7,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(8,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(9,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(10,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(11,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(12,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(13,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(14,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(15,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(16,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(17,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(18,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(19,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(20,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(21,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(22,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(23,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(24,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(25,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(26,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),
        new Card(27,null,null,Card.Type.Silver,null,Card.Faction.Neutral,0,0,Card.Position.MRS),



    };
    
  
    
}
