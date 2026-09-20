using X.Proto.Common.Data;
using X.Proto.Common.Endpoints.Invoker;
using X.Proto.Component.Patterns.ChainResponsibility;

namespace TestOfClaudeGen.Core.BT.Calc.ChainLinks
{
    /// <summary>
    /// UML: Calc_ChainResponsibility page — BT_DocumentsLink «named» : XChainFlowBase
    /// Field "- _invoker: IXInvoker".
    /// </summary>
    public class BT_DocumentsLink : XChainFlowBase
    {
        private readonly IXInvoker _invoker;

        public BT_DocumentsLink( IXInvoker pInvoker )
        {
            _invoker = pInvoker;
        }

        public override Task<XData> HandleLink( XData pParamChainData ) => throw new NotImplementedException();
    }
}
