using Settings;
using UnityEngine;
using UnityEngine.InputSystem;

namespace IO
{
    public class BrailleSettingsInput : AbstractInput
    {
        public BrailleSettingsInput(GameActions gameActions) : base(gameActions)
        {
            this.Actions = gameActions;
        }
        public override void Enable()
        {
            Actions.BrailleSettings.Schriftgrößeerhöhen.started += OnBrailleSizeUp;
            Actions.BrailleSettings.Schriftgrößeverkleinern.started += OnBrailleSizeDown;
            Actions.BrailleSettings.Punktgrößeerhöhen.started += OnDotSizeUp;
            Actions.BrailleSettings.Punktgrößeverkleinern.started += OnDotSizeDown;
            Actions.BrailleSettings.Zeichenabstanderhöhen.started += OnBrailleSpacingUp;
            Actions.BrailleSettings.Zeichenabstandverkleinern.started += OnBrailleSpacingDown;
            Actions.BrailleSettings.Zeilenabstanderhöhen.started += OnLineSpacingUp;
            Actions.BrailleSettings.Zeilenabstandverkleinern.started += OnLineSpacingDown;
            Actions.BrailleSettings.Enable();
        }

        public override void Disable()
        {
            Actions.BrailleSettings.Schriftgrößeerhöhen.started -= OnBrailleSizeUp;
            Actions.BrailleSettings.Schriftgrößeverkleinern.started -= OnBrailleSizeDown;
            Actions.BrailleSettings.Punktgrößeerhöhen.started -= OnDotSizeUp;
            Actions.BrailleSettings.Punktgrößeverkleinern.started -= OnDotSizeDown;
            Actions.BrailleSettings.Zeichenabstanderhöhen.started -= OnBrailleSpacingUp;
            Actions.BrailleSettings.Zeichenabstandverkleinern.started -= OnBrailleSpacingDown;
            Actions.BrailleSettings.Zeilenabstanderhöhen.started -= OnLineSpacingUp;
            Actions.BrailleSettings.Zeilenabstandverkleinern.started -= OnLineSpacingDown;
            Actions.BrailleSettings.Disable();
        }


        private void OnBrailleSizeUp(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.BrailleSize = System.Math.Clamp(SettingsManager.Settings.BrailleSize + SettingsManager.Settings.BrailleSizeIncrement, SettingsManager.Settings.MinBrailleSize , SettingsManager.Settings.MaxBrailleSize);
            IOEventManager.InvokeBrailleSizeChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnBrailleSizeDown(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.BrailleSize = System.Math.Clamp(SettingsManager.Settings.BrailleSize - SettingsManager.Settings.BrailleSizeIncrement, SettingsManager.Settings.MinBrailleSize , SettingsManager.Settings.MaxBrailleSize);
            IOEventManager.InvokeBrailleSizeChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnDotSizeUp(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.DotSize = System.Math.Clamp(SettingsManager.Settings.DotSize + SettingsManager.Settings.DotSizeIncrement, SettingsManager.Settings.MinDotSize , SettingsManager.Settings.MaxDotSize);
            IOEventManager.InvokeDotSizeChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnDotSizeDown(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.DotSize = System.Math.Clamp(SettingsManager.Settings.DotSize - SettingsManager.Settings.DotSizeIncrement, SettingsManager.Settings.MinDotSize , SettingsManager.Settings.MaxDotSize);
            IOEventManager.InvokeDotSizeChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnBrailleSpacingUp(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.BrailleSpacing = System.Math.Clamp(SettingsManager.Settings.BrailleSpacing + SettingsManager.Settings.BrailleSpacingIncrement, SettingsManager.Settings.MinBrailleSpacing , SettingsManager.Settings.MaxBrailleSpacing);
            IOEventManager.InvokeBrailleSpacingChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnBrailleSpacingDown(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.BrailleSpacing = System.Math.Clamp(SettingsManager.Settings.BrailleSpacing - SettingsManager.Settings.BrailleSpacingIncrement, SettingsManager.Settings.MinBrailleSpacing , SettingsManager.Settings.MaxBrailleSpacing);
            IOEventManager.InvokeBrailleSpacingChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnLineSpacingUp(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.LineSpacing = System.Math.Clamp(SettingsManager.Settings.LineSpacing + SettingsManager.Settings.LineSpacingIncrement, SettingsManager.Settings.MinLineSpacing , SettingsManager.Settings.MaxLineSpacing);
            IOEventManager.InvokeLineSpacingChanged();
            SettingsManager.Instance.SaveSettings();
        }

        private void OnLineSpacingDown(InputAction.CallbackContext context)
        {
            SettingsManager.Settings.LineSpacing = System.Math.Clamp(SettingsManager.Settings.LineSpacing - SettingsManager.Settings.LineSpacingIncrement, SettingsManager.Settings.MinLineSpacing , SettingsManager.Settings.MaxLineSpacing);
            IOEventManager.InvokeLineSpacingChanged();
            SettingsManager.Instance.SaveSettings();
        }
    }
}
