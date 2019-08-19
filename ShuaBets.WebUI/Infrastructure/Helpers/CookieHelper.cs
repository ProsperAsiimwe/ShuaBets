using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagicApps.Infrastructure.Helpers;

namespace ShuaBets.WebUI.Infrastructure.Helpers
{
    public class CookieHelper
    {
        public void SetCookies(int referenceId)
        {
            ReferenceId = referenceId;
            Authorised = true;
        }

        public bool Authorised {
            get {
                bool _id = bool.Parse(CustomHelper.GetCookieValue("ShuaBets-Authorised", Boolean.FalseString));
                return _id;
            }
            set {
                CustomHelper.CreateCookie("ShuaBets-Authorised", value.ToString());
            }
        }

        public int ReferenceId {
            get {
                int _id = int.Parse(CustomHelper.GetCookieValue("ShuaBets-ReferenceId"));
                return _id;
            }
            set {
                CustomHelper.CreateCookie("ShuaBets-ReferenceId", value.ToString());
            }
        }

        public void Flush()
        {
            CustomHelper.CreateCookie("ShuaBets-Authorised", Boolean.FalseString, -1);
            CustomHelper.CreateCookie("ShuaBets-ReferenceId", "0", -1);
        }
    }
}