using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] BaseSkill[] skills;

    // Start is called before the first frame update
    void Start()
    {
        skills[0].ExecuteSkill();
        skills[1].ExecuteSkill();
        skills[2].ExecuteSkill();
        skills[3].ExecuteSkill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void EndOfTurn()
    {
        skills[0].EndTurnCallback();
        skills[1].EndTurnCallback();
        skills[2].EndTurnCallback();
        skills[3].EndTurnCallback();
    }
}
