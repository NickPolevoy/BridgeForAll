using Prism.Modularity;
using Prism.Regions;
using System;
using Autofac;

namespace DeskForGame
{
    using Views;

    public class DeskForGameModule : IModule
    {
        readonly IRegionManager regionManager;
        private IContainer container;
        public DeskForGameModule(IContainer container, RegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("DeskForGameRegion", typeof (DeskForGameView));
        }
    }
}