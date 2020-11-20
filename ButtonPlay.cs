using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private Text _textGame;

    private string _playText = "Игра началась!";

    public void OnClickButton()
    {
        _textGame.text = _playText;
    }
}
