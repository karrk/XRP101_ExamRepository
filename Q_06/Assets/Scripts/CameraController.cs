using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool _hasFollowTarget;
    private Transform _followTarget;
    public Transform FollowTarget
    {
        get => _followTarget;
        set
        {
            _followTarget = value;
            if (_followTarget != null) _hasFollowTarget = true;
            else _hasFollowTarget = false;
        }
    }

    private void LateUpdate() => SetTransform();

    private void SetTransform()
    {
        if (!_hasFollowTarget) return;

        transform.forward = _followTarget.forward;

        // muzzle �� ��ǥ�� ȸ���� �����Ѵ�..?
        // _followTarget.SetPositionAndRotation(
        //     transform.position,
        //     transform.rotation
        //     );


    }
}
