using System;
using UnityEngine;

namespace TapsellPlusSDK
{
    public class ClickHandler : MonoBehaviour
    {
        private void OnMouseUpAsButton()
        {
            OnClick?.Invoke();
        }

        public event Action OnClick;
    }
}