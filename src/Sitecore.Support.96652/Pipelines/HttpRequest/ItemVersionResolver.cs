namespace Sitecore.Support.Pipelines.HttpRequest
{
    using Sitecore;
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines.HttpRequest;
    using System;
    using System.Linq;
    public class ItemVersionResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            if (Context.Item != null && !Context.Item.Versions.GetVersionNumbers().Contains(Context.Item.Version))
            {
                Context.Item = null;
            }
        }
    }
}
