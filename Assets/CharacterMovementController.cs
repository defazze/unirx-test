using UnityEngine;
using UniRx;
using Unity.Mathematics;

/// <summary>
/// Контроллер перемещения
/// </summary>
public class CharacterMovementController : MonoBehaviour
{
    private float _velocity;

    void Awake()
    {
        var body = GetComponent<Rigidbody2D>();
        var character = GetComponent<CharacterData>();

        //Подписка на изменение свойства
        character.direction.Subscribe(d =>
        {
            _velocity = 4 * math.sign(d);
        });

        //Замена FixedUpdate
        Observable.EveryFixedUpdate().Subscribe(_ =>
        {
            body.velocity = new Vector2(_velocity, body.velocity.y);
        });
    }
}
