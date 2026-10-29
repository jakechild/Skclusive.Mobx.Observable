using System;
using System.Collections.Generic;
using System.Linq;

namespace Skclusive.Mobx.Observable
{
    public class ObservableAction<T> : IObservable, IObservableAction
    {
        public ObservableAction(string name, Func<object[], object> action, params object[] prefixes)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6ad4520f-a518-4c8d-a78f-a80f252e5fd1" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            Name = name;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "adab28fa-61e4-436d-9221-ac4aa77a931d" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            Prefixes = prefixes;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5b610b9e-9aac-4afe-a647-9406df2919d6" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            Action = action;
        }

        private object[] Prefixes { set; get; }
        private Func<object[], object> Action { set; get; }
        public int DiffValue { set; get; }
        public int LastAccessedBy { set; get; }
        public bool IsBeingObserved { set; get; }
        public DerivationState LowestObserverState { set; get; }
        public IList<IDerivation> Observers { private set; get; }
        public bool IsPendingUnobservation { set; get; }
        public IList<IObservable> Observings { set; get; }
        public string Name { private set; get; }

        public object Execute(object[] arguments)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "003edd20-f3c2-400d-a7c5-7dcf43f61259" + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return Action.Invoke(Prefixes.Concat(arguments).ToArray());
        }

        public void OnBecomeObserved()
        {
        }

        public void OnBecomeUnobserved()
        {
        }
    }
}