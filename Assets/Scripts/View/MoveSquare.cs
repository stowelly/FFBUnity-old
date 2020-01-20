using Fumbbl.Model.Types;

namespace Fumbbl.View
{
    public class MoveSquare : IKeyedObject<MoveSquare>
    {
        public Coordinate Coordinate { get; set; }
        public int minimumRollDodge;
        public int minimumRollGoForIt;

        public object Key => Coordinate.X * 100 + Coordinate.Y;

        public MoveSquare(Ffb.Dto.ModelChanges.MoveSquare square)
        {
            Coordinate = Coordinate.Create(square.coordinate);
            minimumRollDodge = square.minimumRollDodge;
            minimumRollGoForIt = square.minimumRollGoForIt;
        }

        public void Refresh(MoveSquare square)
        {
            Coordinate = square.Coordinate;
            minimumRollDodge = square.minimumRollDodge;
            minimumRollGoForIt = square.minimumRollGoForIt;
        }
    }
}
