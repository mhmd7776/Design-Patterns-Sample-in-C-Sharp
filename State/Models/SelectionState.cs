
namespace State.Models
{
    public class SelectionState : IState
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection State Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection State Mouse Up");
        }
    }
}
