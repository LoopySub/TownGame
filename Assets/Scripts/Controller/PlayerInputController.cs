using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController //moveinput을 받아오기 위해 상속(TopDownCharacterController가 대장
{
    public void OnMove(InputValue value)
    {
       Vector2 moveinput =  value.Get<Vector2>(); // input을 가져옴
        CallMoveEvent(moveinput);   // 재료값을 넣어줌!
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim);  //중앙 원점 기준 카메라

        newAim = (worldPos  -  (Vector2)transform.position).normalized;   //캐릭터 기준으로 변환

        CallLookEvent(newAim);

                
    }
}
