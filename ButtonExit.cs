using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    [SerializeField] private Button ButtonObject;

    public void OnClickButton()
    {
        ButtonObject.image.color = Color.red;
    }
}
