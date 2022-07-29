

using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception:MethodInterceptorsBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnExeption(IInvocation invocation) { }
        protected virtual void OnSuccess(IInvocation invocation) { }


        public override void Intercept(IInvocation invocation)
        {
            bool IsSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {
                IsSuccess = false;
                OnExeption(invocation);
                throw;
            }
            finally
            {
                if (IsSuccess)
                {
                    OnSuccess(invocation);
                }
            }

            OnAfter(invocation);
        }
    }
}
