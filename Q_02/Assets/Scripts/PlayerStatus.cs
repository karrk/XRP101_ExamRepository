using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // 프로퍼티를 참조할 내부변수 추가
    private float _moveSpeed;

    public float MoveSpeed
    {
        get => _moveSpeed;
        private set => _moveSpeed = value;
    }

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }
}
