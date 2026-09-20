using X.Proto.Component.Patterns.ChainResponsibility;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.BT.Calc.ChainLinks
{
    /// <summary>
    /// UML: Calc_ChainResponsibility page — BT_CountryBase «abstract» : XChainFlowBase
    /// Field "+ multiplexor: IXMultiplexor" (protected, per the skills docs).
    /// </summary>
    public abstract class BT_CountryBase : XChainFlowBase
    {
        protected readonly IXMultiplexor multiplexor;

        protected BT_CountryBase( IXMultiplexor pMultiplexor )
        {
            multiplexor = pMultiplexor;
        }
    }
}
