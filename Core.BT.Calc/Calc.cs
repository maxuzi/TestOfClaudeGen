using X.Proto.Common.Data;
using X.Proto.Component.Patterns.ChainResponsibility;

namespace TestOfClaudeGen.Core.BT.Calc
{
    /// <summary>
    /// UML: Core.BT.Calc page — «class» Calc : ICalc
    /// Field "- _chainProcess: IXChainResponsibility" drives the chain described
    /// on the Calc_ChainResponsibility page (ChainLinks folder).
    /// </summary>
    public class Calc : ICalc
    {
        private readonly IXChainResponsibility _chainProcess;

        public Calc( IXChainResponsibility pChainProcess )
        {
            _chainProcess = pChainProcess;
        }

        public Task<XData> Calculating( XData oChainData ) => throw new NotImplementedException();
    }
}
