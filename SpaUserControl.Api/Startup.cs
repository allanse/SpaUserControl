﻿using System;
using Owin;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.UI;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using SpaUserControl.Api.Helpers;
using SpaUserControl.Api.Security;
using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Startup;
using Unity;

namespace SpaUserControl.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);
            config.DependencyResolver = new UnityResolver(container);

            ConfigureWebApi(config);
            ConfigureOAuth(app, container.Resolve<IUserService>());

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );
        }

        public void ConfigureOAuth(IAppBuilder app, IUserService service)
        {
            OAuthAuthorizationServerOptions oAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/security/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                Provider = new AuthorizationServerProvider(service)

            };

            //Token generation
            app.UseOAuthAuthorizationServer(oAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());


        }
    }
}