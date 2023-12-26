using Microsoft.AspNetCore.Components.Web;

namespace TaskSystem
{
    public static class CustomRenderModes
    {
        public static readonly InteractiveAutoRenderMode InteractiveAutoRenderModeNoPreRender
            = new InteractiveAutoRenderMode(prerender: false);
        public static readonly InteractiveServerRenderMode InteractiveServerRenderModeNoPreRender
            = new InteractiveServerRenderMode(prerender: false);
        public static readonly InteractiveWebAssemblyRenderMode InteractiveWebAssemblyRenderModeNoPreRender
            = new InteractiveWebAssemblyRenderMode(prerender: false);
    }
}