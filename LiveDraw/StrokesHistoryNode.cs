using System.Windows.Ink;

namespace Sweeney.LiveDraw
{
    public enum StrokesHistoryNodeType
    {
        Removed,
        Added
    }
    internal class StrokesHistoryNode
    {
        public StrokeCollection Strokes { get; private set; }
        public StrokesHistoryNodeType Type { get; private set; }

        public StrokesHistoryNode(StrokeCollection strokes, StrokesHistoryNodeType type)
        {
            Strokes = strokes;
            Type = type;
        }
    }
}
