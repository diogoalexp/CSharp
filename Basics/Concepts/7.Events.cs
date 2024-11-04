using System.Text;

namespace Basics.Concepts
{

    
    public class Events
    {
        public string StartEvent()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.steps = new StringBuilder();

            bl.steps.AppendLine("Create Event");

            bl.StartProcess();

            bl.steps.Append("End Event");

            return bl.steps.ToString();
        }
        public static void bl_ProcessCompleted(object sender, SampleEventArgs e)
        {
            e.internalSteps.AppendLine("Step x: process bl_ProcessCompleted");

            // some code here..
        }
    }

    // event handler
    public class ProcessBusinessLogic
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<SampleEventArgs> ProcessCompleted;
        public StringBuilder steps;

        public void StartProcess()
        {
            SampleEventArgs args = new SampleEventArgs() { internalSteps = steps};
            args.internalSteps.AppendLine("Step 1: StartProcess");

            // some code here..

            OnProcessCompleted(args);
        }

        protected virtual void OnProcessCompleted(SampleEventArgs e)
        {
            EventHandler<SampleEventArgs> handler = ProcessCompleted;

            if (handler != null)
            {
                e.internalSteps.AppendLine("Step 2: invoke bl_ProcessCompleted");
                handler(this, e); //invoke bl_ProcessCompleted
               
            }

            e.internalSteps.AppendLine("Step 3: invoke bl_ProcessCompleted");
            ProcessCompleted?.Invoke(this, e); //invoke bl_ProcessCompleted

            e.internalSteps.AppendLine("Step 4: End Process");
        }
    }

    public class SampleEventArgs : EventArgs
    {
        public StringBuilder internalSteps { get; set; }
    }
}
