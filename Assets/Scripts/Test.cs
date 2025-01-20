using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] BaseSkill testSkill;
    [SerializeField] BaseSkill baseSkill;

     
    void Start()
    {
        testSkill.ExecuteSkill();
        baseSkill.ExecuteSkill();
    }
}