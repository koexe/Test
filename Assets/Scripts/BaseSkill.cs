using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseSkill : ScriptableObject
{
    [SerializeField] protected int coolTime;
    [SerializeField] protected int damage;


    public virtual void ExecuteSkill()
    {
        this.coolTime = 1;
        // 스킬 A도 ExecuteSkill로 실행
        // 스킬 B도 ExecuteSkill로 실행
    }

    public virtual void EndTurnCallback()
    {
        Debug.Log("턴 끝남");
    }
}
