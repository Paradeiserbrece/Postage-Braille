using Braille;
using UI;
using UnityEngine.InputSystem;

namespace IO
{
    public class GlobalInput : AbstractInput
    {
        private string _popupText = "";
        public GlobalInput(GameActions gameActions) : base(gameActions)
        {
            this.Actions = gameActions;
            
            IOEventManager.AssistiveOutput += SetPopupText;
        }
        
        ~GlobalInput()
        {
            IOEventManager.AssistiveOutput -= SetPopupText;
        }

        private void SetPopupText(string arg1, AssistiveOutput.OutputType arg2)
        {
            _popupText = arg1;
        }

        
        public override void Enable()
        {
            Actions.Constants.Tastenbelegungzurücksetzen.started += OnReset;
            Actions.Constants.Popupanzeigen.started += OnShowPopup;

            Actions.Constants.Tastenbelegungzurücksetzen.started += TemporarilyLockBinding;
            Actions.Constants.Popupanzeigen.started += TemporarilyLockBinding;

            Actions.Constants.Enable();
        }


        public override void Disable()
        {
            Actions.Constants.Tastenbelegungzurücksetzen.started -= OnReset;
            Actions.Constants.Popupanzeigen.started -= OnShowPopup;

            Actions.Constants.Tastenbelegungzurücksetzen.started -= TemporarilyLockBinding;
            Actions.Constants.Popupanzeigen.started -= TemporarilyLockBinding;

            Actions.Constants.Disable();
        }
        
        private void OnShowPopup(InputAction.CallbackContext obj)
        {
            NativePopup.Show(_popupText);
            
        }

        private void OnReset(InputAction.CallbackContext callbackContext)
        {
            ActionRebinder.Instance.ResetRebinds();
            IOEventManager.AssistiveOutput("Tastenbelegung zurückgesetzt", AssistiveOutput.OutputType.Both);
        }
        
    }
}
