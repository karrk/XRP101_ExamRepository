using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : PooledBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _deactivateTime;
    [SerializeField] private int _damageValue;

    private Rigidbody _rigidbody;
    private WaitForSeconds _wait;

    private void Awake()
    {
        Init();
    }

    private void OnEnable()
    {
        StartCoroutine(DeactivateRoutine());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other
                .GetComponentInParent<PlayerController>()
                .TakeHit(_damageValue);
        }
    }

    private void Init()
    {
        _wait = new WaitForSeconds(_deactivateTime);

        // 컴포넌트가 없음
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Fire()
    {
        // 속도 초기화
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.AddForce(transform.forward * _force, ForceMode.Impulse);
    }

    private IEnumerator DeactivateRoutine()
    {
        yield return _wait;
        ReturnPool();
    }

    public override void ReturnPool()
    {
        Pool.Push(this);
        gameObject.SetActive(false);
    }

    public override void OnTaken<T>(T t)
    {
        if (!(t is Transform)) return;

        transform.LookAt((t as Transform));
        Fire();
    }
}
