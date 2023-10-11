using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class DialogueOption
{
    public string text;
    public int requiredStrength;
    public int requiredDexterity;
    public int strengthChange;
    public int dexterityChange;
    public int healthChange;
}
