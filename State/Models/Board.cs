
namespace State.Models
{
    public class Board
    {
        public IState State { get; set; } = new SelectionState();

        public void MouseDown()
        {
            State.MouseDown();
        }

        public void MouseUp()
        {
            State.MouseUp();
        }
    }
}
