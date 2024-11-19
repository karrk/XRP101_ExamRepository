using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    private bool _isDead;

    private AudioSource _audio;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        if (_isDead == true)
            return;

        _isDead = true;

        _audio.Play();
        StartCoroutine(WaitDie());
    }

    private IEnumerator WaitDie()
    {
        WaitForSeconds delay = new WaitForSeconds(0.2f);

        while (true)
        {
            if (_audio.isPlaying == false)
            {
                break;
            }

            yield return delay;
        }

        gameObject.SetActive(false);
    }
}
