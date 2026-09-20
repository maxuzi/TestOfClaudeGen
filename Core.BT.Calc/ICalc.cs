using X.Proto.Common.Data;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.BT.Calc
{
    /// <summary>
    /// UML: Core.BT.Calc page — «interface» ICalc : IXConnector
    /// </summary>
    public interface ICalc : IXConnector
    {
        Task<XData> Calculating( XData oChainData );
    }
}
