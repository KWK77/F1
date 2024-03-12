using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve speddMul;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 5)
            timer = 0;
        timer += Time.deltaTime;
        transform.Rotate(Vector3.up * speddMul.Evaluate(0.5f * timer));
    }
}
