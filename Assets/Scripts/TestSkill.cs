using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Skill", menuName = "Skill/TEST")]
public class TestSkill : BaseSkill
{

    public override void ExecuteSkill()
    {
        base.ExecuteSkill();
        damage = 2;
    }


}
