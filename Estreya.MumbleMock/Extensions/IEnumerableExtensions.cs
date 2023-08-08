using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estreya.MumbleMock.Extensions;
public static class IEnumerableExtensions
{
    public static Vector3 ToVector3(this IEnumerable<float> values)
    {
        var arr = values.ToArray();

        return new Vector3(arr[0], arr[1], arr[2]);
    }
}
