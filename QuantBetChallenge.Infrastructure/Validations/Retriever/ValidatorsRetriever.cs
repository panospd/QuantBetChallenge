using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace QuantBetChallenge.Infrastructure.Validations.Retriever
{
    public class ValidatorsRetriever : IValidatorsRetriever
    {
        public IEnumerable<T> GetAll<T>()
        {
            var assembly = Assembly.GetEntryAssembly();
            var assemblies = assembly.GetReferencedAssemblies();

            foreach (var assemblyName in assemblies)
            {
                assembly = Assembly.Load(assemblyName);

                foreach (var ti in assembly.DefinedTypes)
                {
                    if (ti.ImplementedInterfaces.Contains(typeof(T)))
                    {
                        yield return (T)assembly.CreateInstance(ti.FullName);
                    }
                }
            }
        }
    }
}
