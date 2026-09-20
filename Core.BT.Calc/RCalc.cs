using Autofac;
using Autofac.Extras.DynamicProxy;
using TestOfClaudeGen.Core.BT.Calc.ChainLinks;
using TestOfClaudeGen.Core.BT.Calc.ChainLinks.BON_Plexes;
using TestOfClaudeGen.Core.BT.Calc.ChainLinks.FRB_Plexes;
using TestOfClaudeGen.Core.BT.Calc.EmployeeCountry;
using X.Proto.Common.ServiceConnector;
using X.Proto.Component.Patterns.ChainResponsibility;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.BT.Calc
{
    /// <summary>
    /// Autofac registration for the Core.BT.Calc use case: Calc itself, every chain
    /// link reachable from Calc_ChainResponsibility (resolved by class name — see
    /// XChainResponsibility.RunChain), the multiplexor Plexes each link drives
    /// (resolved by class name — see XMultiplexor.RunTasks/RunFuncs), and the
    /// Employee_Country ManyToMany component included in this same project.
    /// </summary>
    public class RCalc : Module
    {
        protected override void Load( ContainerBuilder builder )
        {
            builder.RegisterType<Calc>()
                   .Named<IXConnector>( "ICalc" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_BonusLink>()
                   .Named<XChainFlowBase>( "BT_BonusLink" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_DocumentsLink>()
                   .Named<XChainFlowBase>( "BT_DocumentsLink" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_ForbidLink>()
                   .Named<XChainFlowBase>( "BT_ForbidLink" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_BON_InsertInfo>()
                   .Named<XTaskPlexBase>( "BT_BON_InsertInfo" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_BON_InsertDetail>()
                   .Named<XTaskPlexBase>( "BT_BON_InsertDetail" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_FRB_SelectCountryPlex>()
                   .Named<XFuncPlexBase>( "BT_FRB_SelectCountryPlex" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<BT_FRB_SelectEmployeePlex>()
                   .Named<XFuncPlexBase>( "BT_FRB_SelectEmployeePlex" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<Employee_Country>()
                   .Named<IXConnector>( "IEmployee_Country" )
                   .SingleInstance()
                   .WithParameter( "pTableName", "clc.employee__country" )
                   .WithParameter( "pConnectionName", null )
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );
        }
    }
}
