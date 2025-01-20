using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    //1. �ڷ�ƾ�� Ȱ���Ѵ�.
    //2. �񵿱� �Լ��� Ȱ���Ѵ�.
    //3. �κ�ũ�� ����

    [SerializeField] bool isBreak = false;

    private void Update()
    {
        //��ǲó��
        if (Input.GetMouseButtonDown(0))
        {
            isBreak = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(Coroutine1());
        }
    }

    private void FixedUpdate()
    {

    }
    IEnumerator Coroutine1()
    {
        Debug.Log(Time.time);
        float elapsedTime = 0f;
        while (elapsedTime < 0.5f)
        {
            elapsedTime += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
        }
        Debug.Log(Time.time);
    }
}
