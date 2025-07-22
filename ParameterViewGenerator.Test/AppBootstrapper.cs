using Autofac;
using Autofac.Core;
using Caliburn.Micro;
using ParameterViewGenerator.Test.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using ConfigManager;

namespace ParameterViewGenerator.Test
{
    public class AppBootstrapper : BootstrapperBase
    {
        private IContainer _container;

        private readonly ContainerBuilder _containerBuilder = new();

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            base.Configure();

            _containerBuilder.RegisterType<WindowManager>().As<IWindowManager>().SingleInstance();
            _containerBuilder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            _containerBuilder.RegisterType<MainViewModel>().SingleInstance();
            _containerBuilder.RegisterType<ParameterViewModel>().SingleInstance();

            var paramData = new ParamData();
            _containerBuilder.RegisterInstance(paramData).SingleInstance();

            _container = _containerBuilder.Build();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
        }

        protected override void OnExit(object sender, EventArgs e)
        {

        }
    }
}
