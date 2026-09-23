using Microsoft.AspNetCore.Mvc;
using X.Proto.Common.Endpoints.Invoker;

namespace TestOfClaudeGen.OutsideApi.Controllers
{
    /// <summary>
    /// UML: DC page — HomeController, grouped under TutorialDemoProject.OutsideApi.
    /// UML: HomeControllerP page — Route="tutorial-demo/v1/", field "- _invoker: IXInvoker".
    /// No action methods yet — StageEndpoints creates only the class skeleton;
    /// methods are StageEndpointsAppsRelations' job (per 02_outside.WebApp.txt).
    /// </summary>
    [ApiController]
    [Route( "tutorial-demo/v1/" )]
    public class HomeController : ControllerBase
    {
        private readonly IXInvoker _invoker;

        public HomeController( IXInvoker pInvoker )
        {
            _invoker = pInvoker;
        }
    }
}
