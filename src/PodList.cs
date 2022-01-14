using System;
using k8s;

namespace Simple
{
    internal class PodList
    {
        private static void Main(string[] args)
        {
            var config = KubernetesClientConfiguration.BuildDefaultConfig();
            IKubernetes client = new Kubernetes(config);
            Console.WriteLine("Starting Request!");

            var ns = Environment.GetEnvironmentVariable("NAMESPACE") ?? "default";
            var list = client.ListNamespacedPod(ns);
            foreach (var item in list.Items)
            {
                Console.WriteLine(item.Metadata.Name);
            }

            if (list.Items.Count == 0)
            {
                Console.WriteLine("Empty!");
            }
        }
    }
}
