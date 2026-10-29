using System.Collections.Generic;

namespace Skclusive.Mobx.Observable
{
    public class Atom : IAtom, IDepTreeNodeClassifier
    {
        public Atom(string name)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9f278b7e-d573-4f8a-aa51-35fe4b422336" + System.Environment.NewLine);
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
            Name = name ?? $"Atom@{States.NextId}";
        }

        public int DiffValue { set; get; }
        public int LastAccessedBy { set; get; }
        public bool IsBeingObserved { set; get; }
        public DerivationState LowestObserverState { set; get; } = DerivationState.NOT_TRACKING;
        public IList<IDerivation> Observers { set; get; } = new List<IDerivation>();
        public bool IsPendingUnobservation { set; get; }
        public string Name { private set; get; }
        public IList<IObservable> Observings { set; get; } = new List<IObservable>();

        DepTreeNodeType IDepTreeNodeClassifier.AtomType => DepTreeNodeType.Atom;

        IDepTreeNode IDepTreeNodeClassifier.Node => this;

        public event AtomHandler OnBecomeObservedEvent;
        public event AtomHandler OnBecomeUnObservedEvent;
        public void OnBecomeObserved()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4167ceb4-b975-4ef1-8fa5-cd6effd57cf7" + System.Environment.NewLine);
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
            if (OnBecomeObservedEvent != null)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9396a907-aab0-4af3-8b39-3cbe55d060a4" + System.Environment.NewLine);
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
                OnBecomeObservedEvent.Invoke(this);
            }
        }

        public void OnBecomeUnobserved()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "69e700a8-c4b4-469d-85e5-125db11c5463" + System.Environment.NewLine);
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
            if (OnBecomeUnObservedEvent != null)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aea30c6e-698b-4f20-8c06-c24b33367d67" + System.Environment.NewLine);
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
                OnBecomeUnObservedEvent.Invoke(this);
            }
        }

        /**
     * Invoke this method _after_ this method has changed to signal mobx that all its observers should invalidate.
     */
        public void ReportChanged()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9241be07-ad34-45f4-91db-e7d0cf2516a9" + System.Environment.NewLine);
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
            Reactions.Transaction(() => this.PropagateChanged());
        }

        /**
    * Invoke this method to notify mobx that your atom has been used somehow.
    * Returns true if there is currently a reactive context.
    */
        public bool ReportObserved()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a7cde9b8-1ddf-4325-988a-492088449675" + System.Environment.NewLine);
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
            return ObservableExtension.ReportObserved(this);
        }

        public override string ToString()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "27c960d7-522a-4dc6-9d33-e5b363cc38a3" + System.Environment.NewLine);
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
            return Name;
        }
    }
}