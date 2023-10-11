using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public string playerName;
    public int strength;
    public int dexterity;
    public int health;
    public TextMeshProUGUI statsText;

    private void Start()
    {
        UpdateStatsText();
    }

    private void UpdateStatsText()
    {
        statsText.text = $"Name: {playerName}, Strength: {strength}, Dexterity: {dexterity}, Health: {health}";
    }
}
