using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Heal : MonoBehaviour
{
    [SerializeField] private float _healCd;
    private float _hpAmount = 1;

    private bool _isOnCd = false;

    [SerializeField] private Button _healButton;
    [SerializeField] private TextMeshProUGUI _showHpAmount;

    private void Start()
    {
        _showHpAmount.text = _hpAmount.ToString();
    }

    private IEnumerator HealDelay()
    {
        yield return new WaitForSeconds(_healCd);
        _isOnCd = false;
        _healButton.interactable = true;
    }
    public void TakeDamage(int damage)
    {
        if (!_isOnCd)
        {
            _hpAmount -= damage;
            ShowHpAmount();
            _isOnCd = true;
            _healButton.interactable = false;
            StartCoroutine(HealDelay());
        }
    }
    private void ShowHpAmount() => _showHpAmount.text = _hpAmount.ToString();
}
