
namespace State.Models
{
    public class BrushState : IState
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush State Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush State Mouse Up");
        }
    }
}
