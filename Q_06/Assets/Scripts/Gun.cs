using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _range;
    [SerializeField] private LayerMask _targetLayer;

    public void Fire(Transform origin)
    {
        Ray ray = new(origin.position, origin.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _range, _targetLayer))
        {
            Debug.Log($"{hit.transform.name} Hit!!");
        }

        Debug.DrawRay(origin.position, origin.forward * _range, Color.blue, 1f);
    }

}
