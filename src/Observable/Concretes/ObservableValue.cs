using System;
using System.Collections.Generic;

namespace Skclusive.Mobx.Observable
{
    public class ObservableValue<TIn, TOut> : Atom, IObservableValue<TIn, TOut>
    {
        public ObservableValue(TIn value, string name = null, IManipulator manipulator = null, object meta = null) : base(name ?? $"ObservableValue@{States.NextId}")
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a5155e1d-914b-422a-a6da-509cbc49b9c5" + System.Environment.NewLine);
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
            Meta = meta;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c4deb0f9-068e-4531-8aff-46c4a0b32ff9" + System.Environment.NewLine);
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
            Manipulator = manipulator ?? Manipulator<TIn, TOut>.For();
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2fd92947-9b2b-4e4a-8788-5f701574374d" + System.Environment.NewLine);
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
            _Value = Manipulator.Enhance(value, default(TIn), Name);
        }

        public static IObservableValue<TIn, TOut> From()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "303103bb-fa15-420c-ba9c-fbdc9e0f8d0a" + System.Environment.NewLine);
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
            return From(default(TIn));
        }

        public static IObservableValue<TIn, TOut> From(TIn value)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "70d667fa-d529-4633-a08b-76218c3dfa4b" + System.Environment.NewLine);
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
            return From(value, null);
        }

        public static IObservableValue<TIn, TOut> From(TIn value, string name, IManipulator<TIn, TOut> manipulator = null, object meta = null)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e00d65f8-7eaa-4b87-a79c-0be56c4da191" + System.Environment.NewLine);
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
            return new ObservableValue<TIn, TOut>(value, name, manipulator, meta);
        }

        private IManipulator Manipulator { set; get; }
        public object Meta { get; }
        public IList<Func<IValueWillChange<TIn>, IValueWillChange<TIn>>> Interceptors { private set; get; } = new List<Func<IValueWillChange<TIn>, IValueWillChange<TIn>>>();
        public IList<Action<IValueDidChange<TIn>>> Listeners { private set; get; } = new List<Action<IValueDidChange<TIn>>>();
        private object _Value { get; set; }

        object IValueReader.Value
        {
            get
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "623537a2-9eb0-45cc-a329-993c6de2464c" + System.Environment.NewLine);
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
                ReportObserved();
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f5b907e6-b430-4a05-9288-122fd04cb3e4" + System.Environment.NewLine);
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
                return Manipulator.Dehance((TIn)_Value);
            }
        }

        object IValueWriter.Value
        {
            set
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "be4834e9-00b7-42aa-b1c2-790e5c1aa6c2" + System.Environment.NewLine);
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
                var oldValue = (TIn)_Value;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a03cd21b-bc16-46d3-b7f2-ba017b637855" + System.Environment.NewLine);
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
                if (PrepareNewValue(oldValue, value, out object newValue))
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1ac2d719-84c2-4834-82b3-2c496b58d478" + System.Environment.NewLine);
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
                    SetNewValue(newValue);
                }
            }
        }

        TOut IValueReader<TOut>.Value
        {
            get
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "80027ff7-d612-45e0-8a3d-ede471d8aadb" + System.Environment.NewLine);
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
                return (TOut)(this as IValueReader).Value;
            }
        }

        TIn IValueWriter<TIn>.Value
        {
            set
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f28bc7e5-4629-405d-80ea-788a3ad0c5f8" + System.Environment.NewLine);
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
                (this as IValueWriter).Value = value;
            }
        }

        public TIn Value
        {
            get
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8607f926-ad63-4a96-8db3-109dabfa9c19" + System.Environment.NewLine);
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
                ReportObserved();
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "875c5277-22dc-42ee-a654-66354ca1c20e" + System.Environment.NewLine);
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
                return (TIn)_Value;
            }

            set
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dd49cdc3-a8c7-40c4-beef-1cd1ac8d25bf" + System.Environment.NewLine);
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
                (this as IValueWriter).Value = value;
            }
        }

        object IObservableValue.Value
        {
            get
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9a0d6730-b39d-4cfb-b3bb-c7852231620a" + System.Environment.NewLine);
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
                ReportObserved();
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0694793a-5349-4581-a9ed-7e6259857da4" + System.Environment.NewLine);
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
                return _Value;
            }

            set
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3fcd02a0-d195-4f0f-9948-c4cf1e3c2ec4" + System.Environment.NewLine);
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
                (this as IValueWriter).Value = value;
            }
        }

        public void SetNewValue(object newValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4739926d-3c0a-4000-acc8-5851773016bb" + System.Environment.NewLine);
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
            SetNewValue((TIn)newValue);
        }

        public void SetNewValue(TIn newValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f7c197c8-f373-438c-b764-ef06f7b63b73" + System.Environment.NewLine);
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
            var oldValue = _Value;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e6953a80-43ab-48f8-b5d0-eb9967fd14cc" + System.Environment.NewLine);
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
            _Value = newValue;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3bf6cf98-fb7a-4771-bab0-fdf864ec5c05" + System.Environment.NewLine);
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
            ReportChanged();
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "efb579b7-067e-42e9-99e0-b86ffb7a4f2d" + System.Environment.NewLine);
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
            if (this.HasListeners())
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d81813b8-b7bc-4377-a25d-6105c49b0a74" + System.Environment.NewLine);
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
                this.NotifyListeners<IValueDidChange<TIn>>(new ValueDidChange<TIn>(newValue, (TIn)oldValue, this));
            }
        }

        public bool PrepareNewValue(object oldValue, object changeValue, out object newValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8b87ac64-a6b7-4cb4-ba22-39549fdd7d56" + System.Environment.NewLine);
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
            if (PrepareNewValue((TIn)oldValue, (TIn)changeValue, out TIn newTValue))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1f01e1a7-b9fd-4012-a513-68abfd311c66" + System.Environment.NewLine);
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
                newValue = newTValue;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dfbf24d0-fe23-4922-aabb-c297126e3090" + System.Environment.NewLine);
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
                return true;
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a6fd589d-8cf4-43b8-af46-903fc4c115ec" + System.Environment.NewLine);
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
            newValue = null;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aaa825f5-8297-470d-bfaa-86b40b14dbd9" + System.Environment.NewLine);
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
            return false;
        }

        public bool PrepareNewValue(TIn oldValue, TIn changeValue, out TIn newValue)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "28c4c1f6-5365-4a76-bed8-413353122295" + System.Environment.NewLine);
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
            this.CheckIfStateModificationsAreAllowed();
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bfaafcdd-b812-43cc-b530-1243e7be590d" + System.Environment.NewLine);
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
            newValue = changeValue;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "542d7539-cd2b-42fd-9d03-2714d1011517" + System.Environment.NewLine);
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
            if (this.HasInterceptors<IValueWillChange<TIn>>())
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "16063bdc-0234-48f6-b83c-ba1b405fccb3" + System.Environment.NewLine);
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
                var change = this.NotifyInterceptors(new ValueWillChange<TIn>(newValue, this));
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "429408a4-11e9-4314-b54f-4bea62fbc1ee" + System.Environment.NewLine);
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
                if (change == null)
                {
                    new System.Action(() =>
                    {
                        using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                        if (m.WaitOne(3000))
                        {
                            try
                            {
                                System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67f85ed2-ff8e-446c-b52c-847abc715220" + System.Environment.NewLine);
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
                    return false;
                }

                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "159d40ba-ebe9-48e6-86ba-72c6e4c584c2" + System.Environment.NewLine);
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
                newValue = change.NewValue;
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7c88d6e3-41c3-4a49-be95-dd0c6967fca7" + System.Environment.NewLine);
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
            newValue = (TIn)Manipulator.Enhance(newValue, oldValue, Name);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "60ef19da-1205-44f8-87b7-5d2f92d912c3" + System.Environment.NewLine);
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
            return !EqualityComparer<TIn>.Default.Equals(newValue, oldValue);
        }

        public IDisposable Intercept(Func<IValueWillChange<TIn>, IValueWillChange<TIn>> interceptor)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d99fa685-190a-4e0d-ada9-e7e959bbdb4e" + System.Environment.NewLine);
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
            return this.ResigerInterceptor<IValueWillChange<TIn>>(interceptor);
        }

        public IDisposable Observe(Action<IValueDidChange<TIn>> listener, bool force = false)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "933f7563-2dfd-458f-b455-13b017df66ec" + System.Environment.NewLine);
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
            if (force)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "53db4953-cf55-4fdf-a659-96bd15663b7e" + System.Environment.NewLine);
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
                listener(new ValueDidChange<TIn>((TIn)_Value, default(TIn), this));
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8932f0e5-a2e1-4e48-98ab-913267adb338" + System.Environment.NewLine);
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
            return this.ResigerListener<IValueDidChange<TIn>>(listener);
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
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6b184d45-fb22-4e54-8199-407fbc609b43" + System.Environment.NewLine);
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
            return $"{Name}[${Value}]";
        }
    }

    public class ObservableValue<T> : ObservableValue<T, T>, IObservableValue<T>
    {
        public ObservableValue(T value, string name = null, IManipulator<T, T> manipulator = null, object meta = null) : base(value, name, manipulator, meta)
        {
        }

        public new static IObservableValue<T> From()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c11f6e84-8e38-403e-8019-2797696bce92" + System.Environment.NewLine);
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
            return From(default(T));
        }

        public new static IObservableValue<T> From(T value)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "49e10a8f-1509-46db-9970-4ea3b2f175bc" + System.Environment.NewLine);
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
            return From(value, null);
        }

        public new static IObservableValue<T> From(T value, string name, IManipulator<T, T> manipulator = null, object meta = null)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "138d80f1-4bc8-4bc7-8581-332de1d2a192" + System.Environment.NewLine);
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
            return new ObservableValue<T>(value, name, manipulator, meta);
        }
    }
}
