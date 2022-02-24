using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gameplay : MonoBehaviour
{
    public TextMeshProUGUI display;

    void Start()
    {
        display.text = Data.display.wordsNShit.words;
    }
}
