using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // ������Ƽ�� ������ ���κ��� �߰�
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
