using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init(this);

        MoveLeft();
    }

    // Update is called once per frame
    public void MoveLeft()
    {
        transform.DOMoveX(-9, 3f).OnComplete<Tween>(MoveRight);
    }
    public void MoveRight()
    {
        transform.DOMoveX(9, 3f).OnComplete<Tween>(MoveLeft);
    }
}
