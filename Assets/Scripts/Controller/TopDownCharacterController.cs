using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{ 
    // ��������Ʈ�� �븮�� ,onmove�� ����ǵ�, ������ ���� vector direction
    public delegate void OnMoveDel(Vector2 direction);
    // �Ӹ�
    public OnMoveDel OnMoveEvent;

    public delegate void OnLookDel(Vector2 direction);

    public OnLookDel OnLookEvent;

    //public event Action<Vector2> OnMoveEvent;
    //public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); //���� ����� , ���� ����Ű���� �޾ƿ´�
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); //���� ����� , ���� ����Ű���� �޾ƿ´�
    }

}
