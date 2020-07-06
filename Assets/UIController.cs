using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

/// <summary>
/// Контроллер UI
/// </summary>
public class UIController : MonoBehaviour
{
    [SerializeField]
    private Text DirectionText;
    void Awake()
    {
        var data = FindObjectOfType<CharacterData>();

        //Биндинг текстбокса на свойство
        data.direction.SubscribeToText(DirectionText, d => d == 0 ? "Stop" : d == 1 ? "Right" : "Left");
    }
}
