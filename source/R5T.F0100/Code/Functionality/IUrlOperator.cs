using System;

using Microsoft.AspNetCore.Components;

using R5T.T0132;


namespace R5T.F0100
{
    [FunctionalityMarker]
    public partial interface IUrlOperator : IFunctionalityMarker
    {
        /// <summary>
        /// A URI looks like https://localhost:3232/Blog/Article01?id=3. Use this function to get the "/Blog/Article01" component, the URL path.
        /// </summary>
        public string GetCurrentUrlPath(NavigationManager navigationManager)
        {
            var uriString = navigationManager.Uri;

            var uri = new Uri(uriString);

            var path = uri.AbsolutePath;

            return path;
        }
    }
}
