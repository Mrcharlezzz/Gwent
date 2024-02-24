using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weatherCard : Card
    {
        public enum Position
        {
            M,R,S,MR,MS,RS,MRS //Rows where the weather can be played M(Melee) R(Range) S(Siege)
        }
        public int weatherdebuff {get;set;} //All units affected by the weather will have its attack set to wheatherdebuff
    }