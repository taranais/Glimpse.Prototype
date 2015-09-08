﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.Framework.OptionsModel;

namespace Glimpse.Server.Web.Framework
{
    public class ClientAuthorizerOptionsCanAccess : IClientAuthorizer
    {
        private readonly Func<HttpContext, bool> _canAccess;

        public ClientAuthorizerOptionsCanAccess(IOptions<GlimpseServerWebOptions> optionsAccessor)
        {
            _canAccess = optionsAccessor.Value.CanAccessClient;
        }

        public bool AllowUser(HttpContext context)
        {
            return _canAccess != null ? _canAccess(context) : true;
        }
    }
}
