using Braille;
using UnityEngine.InputSystem;

namespace IO
{
    public class ResetInput : AbstractInput
    {
        private string _popupText = "";
        public ResetInput(GameActions gameActions) : base(gameActions)
        {
            this.Actions = gameActions;
            
            IOEventManager.AssistiveOutput += SetPopupText;
        }
        
        ~ResetInput()
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
            Actions.Constants.Enable();
        }


        public override void Disable()
        {
            Actions.Constants.Tastenbelegungzurücksetzen.started -= OnReset;
            Actions.Constants.Popupanzeigen.started += OnShowPopup;
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
