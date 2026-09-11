using QTP.Common;
using QTP.Plugins;
using SMAd.Models;
using System.Text.RegularExpressions;


namespace SMAd.LandingPolicy
{
    /// <summary>
    ///Visa落地页处理策略
    /// </summary>
    public sealed class VisaLandingPageStrategy : ILandingPageStrategy
    {
        private readonly SMAdTask _owner;

        public VisaLandingPageStrategy(SMAdTask owner)
        {
            _owner = owner;
        }
 
        private static readonly Regex UrlRegex = new Regex(
            @"^https://([a-z0-9-]+\.)*link2shops\.com/",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public bool CanHandle(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            return UrlRegex.IsMatch(url);
        }


        public async Task<FlowControl> HandleAsync(WorkerRunContext ctx, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(CommonHelper.RandomRange(100, 200), token);
            return FlowControl.Continue;
        }
    }

}
