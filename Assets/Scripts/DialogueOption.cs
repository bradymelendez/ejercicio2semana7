using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class DialogueOption
{
    public string dialogueText;
    public string option1Text;
    public string option2Text;
    public int requiredStrength;
    public int requiredDexterity;
    public int strengthChange;
    public int dexterityChange;
    public int healthChange;
}

