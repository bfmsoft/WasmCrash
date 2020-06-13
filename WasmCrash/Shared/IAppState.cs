using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasmCrash.Shared {
    public interface IAppState {
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public bool IsLoggedIn { get; }

        public event Action OnChange;
    }
}
