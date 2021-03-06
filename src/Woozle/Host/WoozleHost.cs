﻿using System.Reflection;
using Funq;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Auth;
using ServiceStack.WebHost.Endpoints;
using Woozle.Dependencies;
using Woozle.Domain.MandatorManagement;
using Woozle.Model;
using Woozle.Model.SessionHandling;
using Woozle.Persistence.Ef.Dependencies;
using Woozle.Services;
using Woozle.Services.Authentication;
using Woozle.Settings;

namespace Woozle.Host
{
    /// <summary>
    /// HTTP Serverhost based on <see cref="AppHostHttpListenerBase"/>
    /// </summary>
    public class WoozleHost : AppHostHttpListenerBase
    {
        private readonly WoozleDefaults defaults;

        /// <summary>
        /// Initializes a new <see cref="WoozleHost"/>
        /// </summary>
        /// <param name="defaults">Default values for this host</param>
        /// <param name="serviceName">The name of the service</param>
        /// <param name="assemblies">The assemblies which contain services</param>
        protected WoozleHost(WoozleDefaults defaults, string serviceName, params Assembly[] assemblies)
            : base(serviceName, assemblies)
        {
            this.defaults = defaults;
        }

        /// <summary>
        /// Initializes a new <see cref="WoozleHost"/>
        /// </summary>
        /// <param name="serviceName">The name of the service</param>
        /// <param name="assemblies">The assemblies which contain services</param>
        protected WoozleHost(string serviceName, params Assembly[] assemblies) : base(serviceName, assemblies)
        {
        }

        /// <summary>
        /// Configures the host.
        /// </summary>
        /// <remarks>
        ///  - Adds the <see cref="SessionFeature"/>
        ///  - Adds the <see cref="AuthFeature"/> with the <see cref="WoozleCredentialsAuthProvider"/>
        ///  - Adds the <see cref="WoozlePlugin"/>
        /// </remarks>
        /// <param name="container">The IoC-Container</param>
        public override void Configure(Container container)
        {
            ConfigureDefaultScope(container);
            MappingConfiguration.Configure();
            Plugins.Add(new SessionFeature());
            Plugins.Add(CreateAuthFeature(container));
            Plugins.Add(new WoozleEntityFrameworkPlugin());
            Plugins.Add(new WoozlePlugin(defaults));
        }

        /// <summary>
        /// Sets the default reuse scope for the IoC container, which takes effect for all default dependency injection bindings.
        /// </summary>
        /// <param name="container"></param>
        private static void ConfigureDefaultScope(Container container)
        {
            container.DefaultReuse = ReuseScope.Request;
        }

        protected virtual AuthFeature CreateAuthFeature(Container container)
        {
            var authFeature = new AuthFeature(() => new Session(CreateDefaultSessionData(container)), new IAuthProvider[]
            {
                new WoozleCredentialsAuthProvider(container)
            })
            {
                HtmlRedirect = string.Empty
            };
            return authFeature;
        }

        private SessionData CreateDefaultSessionData(Container container)
        {
            var settings = container.Resolve<IWoozleSettings>();
            var user = new User()
            {
                LanguageId = settings.DefaultLanguage.Id,
                Language = settings.DefaultLanguage
            };
            return new SessionData(user, settings.DefaultMandator);
        }
    }
}
