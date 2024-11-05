using Basics.Concepts;

namespace Test.Concepts
{
    public class EventsTest
    {
        [Fact]
        public void Events_EventHandler()
        {
            var expected_result = @"Create Event
                Step 1: StartProcess
                Step 2: invoke bl_ProcessCompleted
                Step x: process bl_ProcessCompleted
                Step 3: invoke bl_ProcessCompleted
                Step x: process bl_ProcessCompleted
                Step 4: End Process
                End Event";

            Events events = new Events();

            var results = events.StartEvent();

            Assert.Equal(expected_result.Replace(" ", ""), results.Replace(" ", ""));
        }
   }
}