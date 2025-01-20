using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    //1. 코루틴을 활용한다.
    //2. 비동기 함수를 활용한다.
    //3. 인보크란 뭐냐

    [SerializeField] bool isBreak = false;

    private void Update()
    {
        //인풋처리
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
