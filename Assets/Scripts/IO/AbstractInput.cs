using System.Threading.Tasks;
using IO;
using Settings;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class AbstractInput
{
    protected GameActions Actions;
    protected InputAction lastAction;

    protected AbstractInput(GameActions actions)
    {
        Actions = actions;
    }

    protected async void TemporarilyLockBinding(InputAction.CallbackContext context)
    {
        if (SettingsManager.Settings.IgnoreDoubleInputTime <= 0) return;
        
        InputAction action = context.action;
        
        
        if (action != lastAction)
        {
            lastAction?.Enable();
        }
        lastAction = action;
        
        action.Disable();
        await Task.Delay(SettingsManager.Settings.IgnoreDoubleInputTime);
        action.Enable();
        
        
    }

    
    public abstract void Enable();
    public abstract void Disable();
}
