using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Контроллер ввода
/// </summary>
public class CharacterInputController : MonoBehaviour
{
    private CharacterData _character;

    void Awake()
    {
        _character = GetComponent<CharacterData>();
    }

    void Update()
    {
        //Обновлене реактивного свойства пользовательским вводом

        if (Input.GetKeyDown(KeyCode.A))
        {
            _character.direction.Value = -1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _character.direction.Value = 1;
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            _character.direction.Value = 0;
        }
    }
}
