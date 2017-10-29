using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace FastReflection
{
    public partial class MainForm : Form
    {
        readonly Stopwatch stopWatch = new Stopwatch();
        readonly Entity entity;
        SerializedObject lastSerialized, lastReserialized;

        int outerLoops, innerLoops;

        public MainForm()
        {
            InitializeComponent();

            entity = new Entity
            {
                AggregateList = new List<Entity> { new Entity { AtomicField = "1" }, new Entity { AtomicField = "2" } },
                AggregateClass = new Entity(),
                AggregateStruct = new SomeStruct { A = 1, B = 2 },
                AggregateArray = new[] { new Entity { AtomicField = "1" }, new Entity { AtomicField = "2" } },
                AggregateDictionary = new Dictionary<Entity, Entity>
                {
                    { new Entity { AtomicField = "Key1" }, new Entity { AtomicField = "Value1" } },
                    { new Entity { AtomicField = "Key2" }, new Entity { AtomicField = "Value2" } }
                },
                AggregateSet = new HashSet<Entity> { new Entity { AtomicField = "1" }, new Entity { AtomicField = "2" } },
                AtomicArray = new[] { "1", "2" },
                AtomicDictionary = new Dictionary<string, int> { { "Key1", 1 }, { "Key2", 2 } },
                AtomicField = "Bar",
                AtomicList = new List<string> { "1", "2" },
                AtomicProperty = 13.37f,
                AtomicSet = new HashSet<string> { "1", "2" },
                Enumeration = EntityKind.Fooish,
                HybridDictionary = new Dictionary<string, Entity>
                {
                    { "Key1", new Entity { AtomicField = "Value1" } },
                    { "Key2", new Entity { AtomicField = "Value2" } }
                },
                Ignored = 1,
                NonReadableAuto = 2,
                NonReadable = 4,
                Nullable = 6,
                InternalField = 8,
                Required = new Entity(),
                Renamed = new Entity(),
                Polymorphic = new Entity()
            };

            innerLoops = (int)InnerLoopsChooser.Value;
            outerLoops = (int)OuterLoopsChooser.Value;
        }

        void ByeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Test1Button_Click(object sender, EventArgs e)
        {
            Entity lastDeserialized = null;

            LogTestStarted("Standard Reflection");

            for (int i = 0; i < outerLoops; i++)
            {
                var serializer = new Serializer(new DirectReflector());
                for (int j = 0; j < innerLoops; j++)
                    lastDeserialized = serializer.Deserialize<Entity>(lastSerialized = serializer.Serialize(entity));
            }

            LogTestCompleted();

            lastReserialized = (new Serializer(new DirectReflector())).Serialize(lastDeserialized);
            DumpSerializedObjects();
        }

        void Test2Button_Click(object sender, EventArgs e)
        {
            Entity lastDeserialized = null;

            LogTestStarted("Reflection.Emit + Delegate (No Caching)");

            for (int i = 0; i < outerLoops; i++)
            {
                var serializer = new Serializer(new EmitReflector());
                for (int j = 0; j < innerLoops; j++)
                    lastDeserialized = serializer.Deserialize<Entity>(lastSerialized = serializer.Serialize(entity));
            }

            LogTestCompleted();

            lastReserialized = (new Serializer(new EmitReflector())).Serialize(lastDeserialized);
            DumpSerializedObjects();
        }

        void Test3Button_Click(object sender, EventArgs e)
        {
            Entity lastDeserialized = null;

            LogTestStarted("DynamicMethod + Delegate, Cached");

            for (int i = 0; i < outerLoops; i++)
            {
                var serializer = new Serializer(new CachedReflector());
                for (int j = 0; j < innerLoops; j++)
                    lastDeserialized = serializer.Deserialize<Entity>(lastSerialized = serializer.Serialize(entity));
            }

            LogTestCompleted();

            lastReserialized = (new Serializer(new CachedReflector())).Serialize(lastDeserialized);
            DumpSerializedObjects();
        }

        void DumpSerializedObjects()
        {
            SerializedText.Clear();
            SerializedText.Text += lastSerialized.Stringify();
            ReserializedText.Clear();
            ReserializedText.Text += lastReserialized.Stringify();
        }

        void LogTestStarted(string description)
        {
            ConsoleText.Text += string.Format("Test '{0}' Started... ", description);
            Application.DoEvents();

            stopWatch.Start();
        }

        void LogTestCompleted()
        {
            stopWatch.Stop();

            ConsoleText.Text += "Completed.\r\n"; 
            ConsoleText.Text += string.Format("Time Elapsed : {0}\r\n\r\n", stopWatch.Elapsed);

            stopWatch.Reset();
        }

        private void OuterLoopsChooser_ValueChanged(object sender, EventArgs e)
        {
            outerLoops = (int)OuterLoopsChooser.Value;
        }

        private void InnerLoopsChooser_ValueChanged(object sender, EventArgs e)
        {
            innerLoops = (int)InnerLoopsChooser.Value;
        }
    }
}
