using X.Proto.Common.Data;
using X.Proto.Component.Patterns.ChainResponsibility;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.BT.Calc.ChainLinks
{
    /// <summary>
    /// UML: Calc_ChainResponsibility page — BT_BonusLink «named» : BT_CountryBase
    /// Own detail page lists the two XTaskPlexBase classes it drives through
    /// `multiplexor` — see ChainLinks/BON_Plexes.
    /// </summary>
    public class BT_BonusLink : BT_CountryBase
    {
        public BT_BonusLink( IXMultiplexor pMultiplexor ) : base( pMultiplexor )
        {
        }

        public override Task<XData> HandleLink( XData pParamChainData ) => throw new NotImplementedException();
    }
}
