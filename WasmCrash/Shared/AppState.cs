using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasmCrash.Shared {
	public class AppState : IAppState {
        public string EmailAddress
        {
            get
            {
                return EmailAddress;
            }
            set
            {
                EmailAddress = value;
                NotifyStateChanged();
            }
        }
        public string PasswordHash
        {
            get
            {
                return PasswordHash;
            }
            set
            {
                PasswordHash = value;
                NotifyStateChanged();
            }
        }
        public bool IsLoggedIn
        {
            get
            {
                return !string.IsNullOrWhiteSpace(EmailAddress) && !string.IsNullOrWhiteSpace(PasswordHash);
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
