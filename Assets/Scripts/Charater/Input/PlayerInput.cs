using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public PlayerInputSystem system;
    public Vector2 axes=>system.Gameplay.Axes.ReadValue<Vector2>();    
    public float AxisX=>axes.x;
    public float AxisY=>axes.y;
    public bool Move => AxisX != 0f;
    public bool Switch => system.Gameplay.Switch_Nui.WasPerformedThisFrame();
    public bool Realse => system.Gameplay.Realse_skill.WasPerformedThisFrame();
    public bool Attack => system.Gameplay.Attack.WasPerformedThisFrame();
    private void Awake()
    {
        system=new PlayerInputSystem();
    }
   public void EnableGameplayInputs()
    {
        system.Gameplay.Enable();
    }
}
