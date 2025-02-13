using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private float _fireBallDestroyTime = 3;

    private RectTransform rectTransform;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Destroy(gameObject, _fireBallDestroyTime);
    }
    private void Update()
    {
        rectTransform.position += new Vector3(2, 0, 0);
    }
}
