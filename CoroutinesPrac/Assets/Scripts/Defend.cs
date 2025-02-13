using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Defend : MonoBehaviour
{
    [SerializeField] private float _defendCd;
    private float _defense = 0;

    private bool _isOnCd = false;

    [SerializeField] private Button _defButton;
    [SerializeField] private TextMeshProUGUI _showDefAmount;

    private void Start()
    {
        _showDefAmount.text = _defense.ToString();
    }
    private IEnumerator DefendDelay()
    {
        yield return new WaitForSeconds(_defendCd);
        _isOnCd = false;
        _defButton.interactable = true;
    }
    public void ImproveDefense(int defIncrease)
    {
        if (!_isOnCd)
        {
            _defense += defIncrease;
            ShowDefenseAmount();
            _isOnCd = true;
            _defButton.interactable = false;
            StartCoroutine(DefendDelay());
        }
    }

    private void ShowDefenseAmount() => _showDefAmount.text = _defense.ToString();
}
