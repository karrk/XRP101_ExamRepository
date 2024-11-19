using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // 타임스케일의 영향을 받기 위해 FixedUpdate
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score);
    }
}
