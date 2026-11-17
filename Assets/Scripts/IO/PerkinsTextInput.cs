using System.Collections.Generic;
using System.Linq;
using System.Text;
using Braille;
using UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace IO
{
    public class PerkinsTextInput: AbstractTextInput
    {
        private List<bool> _pressedDots;
        public PerkinsTextInput(GameActions gameActions) : base(gameActions)
        {
            this.Actions = gameActions;
        }
        public override void Enable()
        {
            _pressedDots = new List<bool>(Textbox.EmptyBrailleList);
            Actions.PerkinsBrailer.Punkt1.started += OnDot0Started;
            Actions.PerkinsBrailer.Punkt1.canceled += OnDot0Canceled;
            Actions.PerkinsBrailer.Punkt2.started += OnDot1Started;
            Actions.PerkinsBrailer.Punkt2.canceled += OnDot1Canceled;
            Actions.PerkinsBrailer.Punkt3.started += OnDot2Started;
            Actions.PerkinsBrailer.Punkt3.canceled += OnDot2Canceled;
            Actions.PerkinsBrailer.Punkt4.started += OnDot3Started;
            Actions.PerkinsBrailer.Punkt4.canceled += OnDot3Canceled;
            Actions.PerkinsBrailer.Punkt5.started += OnDot4Started;
            Actions.PerkinsBrailer.Punkt5.canceled += OnDot4Canceled;
            Actions.PerkinsBrailer.Punkt6.started += OnDot5Started;
            Actions.PerkinsBrailer.Punkt6.canceled += OnDot5Canceled;
            Actions.PerkinsBrailer.Rücktaste.started += OnDeleteCharacter;
            Actions.PerkinsBrailer.Leertaste.started += OnSpace;
            
            Actions.PerkinsBrailer.Punkt1.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt1.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt2.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt2.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt3.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt3.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt4.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt4.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt5.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt5.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt6.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt6.canceled += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Rücktaste.started += TemporarilyLockBinding;
            Actions.PerkinsBrailer.Leertaste.started += TemporarilyLockBinding;

            StringBuilder actionsString = new StringBuilder();
            actionsString.Append("action string: \n");
            foreach (var binding in Actions)
            {
                actionsString.Append(binding + "\n");
            }

            Actions.PerkinsBrailer.Enable();
        }

        public override void Disable()
        {
            Actions.PerkinsBrailer.Punkt1.started -= OnDot0Started;
            Actions.PerkinsBrailer.Punkt1.canceled -= OnDot0Canceled;
            Actions.PerkinsBrailer.Punkt2.started -= OnDot1Started;
            Actions.PerkinsBrailer.Punkt2.canceled -= OnDot1Canceled;
            Actions.PerkinsBrailer.Punkt3.started -= OnDot2Started;
            Actions.PerkinsBrailer.Punkt3.canceled -= OnDot2Canceled;
            Actions.PerkinsBrailer.Punkt4.started -= OnDot3Started;
            Actions.PerkinsBrailer.Punkt4.canceled -= OnDot3Canceled;
            Actions.PerkinsBrailer.Punkt5.started -= OnDot4Started;
            Actions.PerkinsBrailer.Punkt5.canceled -= OnDot4Canceled;
            Actions.PerkinsBrailer.Punkt6.started -= OnDot5Started;
            Actions.PerkinsBrailer.Punkt6.canceled -= OnDot5Canceled;
            Actions.PerkinsBrailer.Rücktaste.started -= OnDeleteCharacter;
            Actions.PerkinsBrailer.Leertaste.started -= OnSpace;
            
            Actions.PerkinsBrailer.Punkt1.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt1.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt2.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt2.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt3.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt3.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt4.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt4.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt5.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt5.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt6.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Punkt6.canceled -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Rücktaste.started -= TemporarilyLockBinding;
            Actions.PerkinsBrailer.Leertaste.started -= TemporarilyLockBinding;

            Actions.PerkinsBrailer.Disable();
        }

        #region DotControlsActions
        private void OnDot0Started(InputAction.CallbackContext context) => OnDotNStarted(0, context);
        private void OnDot0Canceled(InputAction.CallbackContext context) => OnDotNCanceled(0, context);
        private void OnDot1Started(InputAction.CallbackContext context) => OnDotNStarted(1, context);
        private void OnDot1Canceled(InputAction.CallbackContext context) => OnDotNCanceled(1, context);
        private void OnDot2Started(InputAction.CallbackContext context) => OnDotNStarted(2, context);
        private void OnDot2Canceled(InputAction.CallbackContext context) => OnDotNCanceled(2, context);
        private void OnDot3Started(InputAction.CallbackContext context) => OnDotNStarted(3, context);
        private void OnDot3Canceled(InputAction.CallbackContext context) => OnDotNCanceled(3, context);
        private void OnDot4Started(InputAction.CallbackContext context) => OnDotNStarted(4, context);
        private void OnDot4Canceled(InputAction.CallbackContext context) => OnDotNCanceled(4, context);
        private void OnDot5Started(InputAction.CallbackContext context) => OnDotNStarted(5, context);
        private void OnDot5Canceled(InputAction.CallbackContext context) => OnDotNCanceled(5, context);
        #endregion
        
        private void LockInCharacter()
        {
            if (_pressedDots.SequenceEqual(Textbox.EmptyBrailleList))
            {
                Textbox.AddCurrentBrailleListAsCharacter();
                Textbox.NextBrailleCharacter();
            }
        }

        private void OnDotNStarted(int n, InputAction.CallbackContext context)
        {
            Textbox.currentBrailleList[n] = true;
            _pressedDots[n] = true;
            Textbox.UpdateCurrentBrailleObject();
        }

        private void OnDotNCanceled(int i, InputAction.CallbackContext context)
        {
            _pressedDots[i] = false;
            LockInCharacter();
        }

        private void OnDeleteCharacter(InputAction.CallbackContext context)
        {
            Textbox.DeleteCharacter();
        }

        private void OnSpace(InputAction.CallbackContext context)
        {
            Textbox.NextBrailleCharacter();
        }
    }
}
