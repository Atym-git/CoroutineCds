using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    [SerializeField] private float _fireBallCd;
    [SerializeField] private Transform _fireBallRoot;

    [SerializeField] private GameObject _fireBallPrefab;

    private bool _isOnCd = false;

    [SerializeField] private Button _attackButton;
    private IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(_fireBallCd);
        _isOnCd = false;
        _attackButton.interactable = true;
    }
    public void FireBallAttack()
    {
        if (!_isOnCd)
        {
            Instantiate(_fireBallPrefab, _fireBallRoot);
            _isOnCd = true;
            _attackButton.interactable = false;
            StartCoroutine(AttackDelay());
        }
    }
}
