using X.Proto.Common.Data;
using X.Proto.Component.Patterns.ChainResponsibility;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.BT.Calc.ChainLinks
{
    /// <summary>
    /// UML: Calc_ChainResponsibility page — BT_ForbidLink «named» : BT_CountryBase
    /// Own detail page lists the two XFuncPlexBase classes it drives through
    /// `multiplexor` — see ChainLinks/FRB_Plexes.
    /// </summary>
    public class BT_ForbidLink : BT_CountryBase
    {
        public BT_ForbidLink( IXMultiplexor pMultiplexor ) : base( pMultiplexor )
        {
        }

        public override Task<XData> HandleLink( XData pParamChainData ) => throw new NotImplementedException();
    }
}
