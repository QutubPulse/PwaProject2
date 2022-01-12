using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Client.Pages
{
    public interface ICallJavaScript
    {
        Task Calljs(int value);
    }
}
