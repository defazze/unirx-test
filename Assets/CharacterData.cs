using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// Плоский класс для хранения данных об объекте.
/// Это может быть так же ScriptableObject или Singleton
/// Контроллеры завязываются на этот класс и ничего не знают друг о друге
/// </summary>
public class CharacterData : MonoBehaviour
{
    public IntReactiveProperty direction = new IntReactiveProperty();
}
