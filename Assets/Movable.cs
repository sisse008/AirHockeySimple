using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movable : MonoBehaviour
{

    public float speed = 100f;
    public RuntimeInputHelper.InputType.InputTypeEnum inputType;
    Transform me;

    private void Awake()
    {
        me = GetComponent<Transform>();
    }

    private void Start()
    {
        RuntimeInputHelper.RegisterInputEvents(inputType , Move);
       
    }

    private void Move(float horizontal_axis, float vertical_axis)
    {
        Vector3 direction = new Vector3(horizontal_axis, vertical_axis, 0f).normalized;

        me.position = me.position + direction * speed * Time.deltaTime;
    }
}
