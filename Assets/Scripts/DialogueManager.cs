using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DialogueManager : MonoBehaviour
{
   public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI option1Text;
    public TextMeshProUGUI option2Text;

    public void StartDialogue(DialogueOption option)
    {
        dialogueText.text = option.dialogueText;
        option1Text.text = option.option1Text;
        option2Text.text = option.option2Text;
    }
}
