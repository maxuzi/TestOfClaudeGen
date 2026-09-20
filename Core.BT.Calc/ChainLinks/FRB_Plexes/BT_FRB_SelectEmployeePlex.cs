using X.Proto.Common.Data;
using X.Proto.Common.Endpoints.Invoker;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.BT.Calc.ChainLinks.FRB_Plexes
{
    /// <summary>
    /// UML: BT_ForbidLink detail page — BT_FRB_SelectEmployeePlex «named» : XFuncPlexBase
    /// Field "- _invoker: IXInvoker".
    /// </summary>
    public class BT_FRB_SelectEmployeePlex : XFuncPlexBase
    {
        private readonly IXInvoker _invoker;

        public BT_FRB_SelectEmployeePlex( IXInvoker pInvoker )
        {
            _invoker = pInvoker;
        }

        public override Task<XData> RunFunc( XData pQueryParams ) => throw new NotImplementedException();
    }
}
