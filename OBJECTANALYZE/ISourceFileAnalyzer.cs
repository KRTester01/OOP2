using System.Collections.Generic;

namespace ObjectAnalyzer
{
    public interface ISourceFileAnalyzer
    {
        List<MethodDetail> GetMethodDetails(string sourceCode);
    }
}
