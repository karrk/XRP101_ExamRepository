using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // Ÿ�ӽ������� ������ �ޱ� ���� FixedUpdate
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score);
    }
}
