using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False_move : EnemyState
{
    public false_champion false_;
    public False_move(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, false_champion false_) : base(stateMahine, enemy, animatorName)
    {
        this.false_ = false_;
    }
}
