using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController //moveinput�� �޾ƿ��� ���� ���(TopDownCharacterController�� ����
{
    public void OnMove(InputValue value)
    {
       Vector2 moveinput =  value.Get<Vector2>(); // input�� ������
        CallMoveEvent(moveinput);   // ��ᰪ�� �־���!
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim);  //�߾� ���� ���� ī�޶�

        newAim = (worldPos  -  (Vector2)transform.position).normalized;   //ĳ���� �������� ��ȯ

        CallLookEvent(newAim);

                
    }
}
