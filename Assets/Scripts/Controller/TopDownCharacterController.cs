using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{ 
    // 델리게이트는 대리자 ,onmove를 만들건데, 음식의 재료는 vector direction
    public delegate void OnMoveDel(Vector2 direction);
    // 임명
    public OnMoveDel OnMoveEvent;

    public delegate void OnLookDel(Vector2 direction);

    public OnLookDel OnLookEvent;

    //public event Action<Vector2> OnMoveEvent;
    //public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); //음식 만들기 , 재료는 방향키에서 받아온다
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); //음식 만들기 , 재료는 방향키에서 받아온다
    }

}
