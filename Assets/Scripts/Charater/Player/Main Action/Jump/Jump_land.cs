using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_land : PlayerState
{
    public Jump_land(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }
}
