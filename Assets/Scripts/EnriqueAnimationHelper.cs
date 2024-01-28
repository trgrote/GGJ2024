using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnriqueAnimationHelper : MonoBehaviour
{
    [SerializeField] string _paramName;

    Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetBool(bool value)
    {
        _animator.SetBool(_paramName, value);
    }
}
