using UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace IO
{
    public class NavigationInput : AbstractInput
    {
        public NavigationInput(GameActions gameActions) : base(gameActions)
        {
            this.Actions = gameActions;
        }

        public override void Enable()
        {
            Actions.Navigation.antwort1.started += OnAnswer0;
            Actions.Navigation.antwort2.started += OnAnswer1;
            Actions.Navigation.antwort3.started += OnAnswer2;
            Actions.Navigation.antwort4.started += OnAnswer3;
            Actions.Navigation.antwort5.started += OnAnswer4;
            Actions.Navigation.antwort6.started += OnAnswer5;
            Actions.Navigation.UILayerwechseln.started += OnSwitchUILayer;
            Actions.Navigation.weiter.started += OnNext;
            Actions.Navigation.zurück.started += OnPrev;
            Actions.Navigation.bestätigen.started += OnConfirm;
            Actions.Navigation.Enable();
        }

        public override void Disable()
        {
            Actions.Navigation.antwort1.started -= OnAnswer0;
            Actions.Navigation.antwort2.started -= OnAnswer1;
            Actions.Navigation.antwort3.started -= OnAnswer2;
            Actions.Navigation.antwort4.started -= OnAnswer3;
            Actions.Navigation.antwort5.started -= OnAnswer4;
            Actions.Navigation.antwort6.started -= OnAnswer5;
            Actions.Navigation.UILayerwechseln.started -= OnSwitchUILayer;
            Actions.Navigation.weiter.started -= OnNext;
            Actions.Navigation.zurück.started -= OnPrev;
            Actions.Navigation.bestätigen.started -= OnConfirm;
            Actions.Navigation.Disable();
        }

        private void OnAnswer0(InputAction.CallbackContext context)
        {
            SelectOption(0);
        }

        private void OnAnswer1(InputAction.CallbackContext context)
        {
            SelectOption(1);
        }

        private void OnAnswer2(InputAction.CallbackContext context)
        {
            SelectOption(2);
        }

        private void OnAnswer3(InputAction.CallbackContext context)
        {
            SelectOption(3);
        }

        private void OnAnswer4(InputAction.CallbackContext context)
        {
            SelectOption(4);
        }

        private void OnAnswer5(InputAction.CallbackContext context)
        {
            SelectOption(5);
        }

        private void OnNext(InputAction.CallbackContext context)
        {
            SceneControl.CurrentUI.HighlightNextOption();
        }

        private void OnPrev(InputAction.CallbackContext context)
        {
            SceneControl.CurrentUI.HighlightPreviousOption();
        }

        private void OnConfirm(InputAction.CallbackContext context)
        {
            SelectOption();
        }

        private void SelectOption(int index)
        {
            var selected = SceneControl.CurrentUI.CurrentFocusables[index];
            selected.ConfirmAction();
        }

        private void SelectOption()
        {
            SceneControl.CurrentUI.CurrentlyFocusedOption.ConfirmAction();
        }

        private void OnSwitchUILayer(InputAction.CallbackContext context)
        {
            SceneControl.CurrentUI.SwitchLayer();
        }
    }
}
