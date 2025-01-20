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
        // ��ų A�� ExecuteSkill�� ����
        // ��ų B�� ExecuteSkill�� ����
    }

    public virtual void EndTurnCallback()
    {
        Debug.Log("�� ����");
    }
}
