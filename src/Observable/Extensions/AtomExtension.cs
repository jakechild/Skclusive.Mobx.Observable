using System;

namespace Skclusive.Mobx.Observable
{
    public static class AtomExtension
    {
        public static void CheckIfStateModificationsAreAllowed(this IAtom atom)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ee223aa5-c298-4e2b-81bf-cadb3475b969" + System.Environment.NewLine);
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
            var hasObservers = atom.Observers.Count > 0;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fadcc82f-0d62-44bb-87e9-11e6539879de" + System.Environment.NewLine);
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
            // Should never be possible to change an observed observable from inside computed, see #798
            if (States.State.ComputationDepth > 0 && hasObservers)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "087d03ed-a27f-4862-9058-9c79c0f6a114" + System.Environment.NewLine);
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
                throw new Exception($"Computed values are not allowed to cause side effects by changing observables that are already being observed. Tried to modify: {atom.Name}");
            }
        // TODO: investigate why below code commented
        // Should not be possible to change observed state outside strict mode, except during initialization, see #563
        //if (!States.State.AllowStateChanges && (hasObservers || States.State.EnforceActions))
        //{
        //    throw new Exception((States.State.EnforceActions ? "Since strict-mode is enabled, changing observed observable values outside actions is not allowed. Please wrap the code in an `action` if this change is intended. Tried to modify: "
        //        : "Side effects like changing state are not allowed at this point. Are you trying to modify state from, for example, the render function of a React component? Tried to modify: ") +
        //        atom.Name);
        //}
        }
    }
}