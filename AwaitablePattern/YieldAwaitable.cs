using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AwaitablePattern
{
    public struct YieldAwaitable
    {
        public YieldAwaiter GetAwaiter();

        public struct YieldAwaiter : INotifyCompletion
        {
            public bool IsCompleted { get; private set; }
            public void OnCompleted(Action continuation);
            public void GetResult();

        }
    }
}
