using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAuthor : MonoBehaviour
{
    [SerializeField] private Text TextContent;

    private string _author = @"Создатель игры Майнкрафт. 
Имя автора - Маркус Перссон. Маркус программист из Швеции, а также гейм-дизайнер. 
Гораздо больше он известен под своим псевдонимом Нотч (Notch).";

    public void OnClickButton()
    {
        TextContent.text = _author;
    }
}
