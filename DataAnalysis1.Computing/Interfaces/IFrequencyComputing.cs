using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.Computing
{
    public interface IFrequencyComputing<in T>
    {
        int CountFrequency(T elem);
        double CountRelativeFrequency(T elem);
        double ComputeEmpiricalCumulativeDistributionFunctionValue(int index);
    }
}
