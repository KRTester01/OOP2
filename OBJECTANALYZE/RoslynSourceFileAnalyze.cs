using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTANALYZE
{
    class RoslynSourceFileAnalyze : ISourceFileAnalyzer
    {
        private AccessModifier GetModiferForMethod(MethodDeclarationSyntax method)
        {
            if (method.Modifiers.Any(mod => mod.IsKind(SyntaxKind.PublicKeyword)))
            {
                return AccessModifier.Public;
            }
            return AccessModifier.Private;
        }

        private IEnumerable<MethodDeclarationSyntax> GetTheMethods(string sourceCode)
        {
            var tree = CSharpSyntaxTree.ParseText(sourceCode).GetRoot();
            return tree.DescendantNodes().OfType<MethodDeclarationSyntax>();
        }

        public List<MethodDetail> GetMethodDetails(string sourceCode)
        {
            var methods = GetTheMethods(sourceCode);

            var methodDetails = new List<MethodDetail>();

            // This is example code, you don't want to really use it this way
            var dummyMethodOne = new MethodDetail();
            //            dummyMethodOne.MethodName = "Not the Name";
            //          dummyMethodOne.MethodAccessModifier = AccessModifier.Private;
            //        methodDetails.Add(dummyMethodOne);

            foreach (var method in methods)
            {
                System.Diagnostics.Debug.WriteLine(method.Identifier.Text);
                Console.WriteLine("Access Modifier: {0} Method {1}", GetModiferForMethod(method), method.Identifier);
                dummyMethodOne.MethodName = method.Identifier.Text;
                dummyMethodOne.MethodAccessModifier = GetModiferForMethod(method);
                methodDetails.Add(dummyMethodOne);
            }

            return methodDetails;
        }
        public string GetTheMethodDetails(string sourcecode)
        {
            throw new NotImplementedException();
        }
    }
}
