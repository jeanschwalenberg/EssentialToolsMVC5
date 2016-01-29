using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Infrastructure {
    public class NinjectDependencyResolver : IDependencyResolver{
        private IKernel kernel;
    }
}