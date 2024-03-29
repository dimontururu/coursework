using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_пазлы
{
    interface Authorization
    {
        void LoadingForm();
    }
    internal class AuthorizationPlayer: Authorization
    {
        public void LoadingForm() { }
    }

    internal class AuthorizationAdministrator : Authorization
    {
        public void LoadingForm() { }
    }
}
