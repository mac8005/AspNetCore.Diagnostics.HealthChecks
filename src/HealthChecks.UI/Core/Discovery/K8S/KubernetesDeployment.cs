using System.Collections.Generic;

namespace HealthChecks.UI.Core.Discovery.K8S.Deployment
{
    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
    }


    public class Spec
    {
        public IList<Container> containers { get; set; }
        public Template template { get; set; }

    }

    public class Template
    {
       
        public Spec spec { get; set; }
    }


public class KubernetesDeployment
    {
        public Spec spec { get; set; }
    }
}