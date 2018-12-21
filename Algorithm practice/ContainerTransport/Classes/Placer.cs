using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Placer
    {
        List<Row> Rows;
        ulong weightLeft = 0;
        ulong weightRight = 0;
        double difference;

        public ulong WeightLeft { get => weightLeft; set => weightLeft = value; }
        public ulong WeightRight { get => weightRight; set => weightRight = value; }
        public double Difference { get => difference; set => difference = value; }

        public Placer(List<Row> rows)
        {
            this.Rows = rows;
        }

        public List<Row> PlaceRows()
        {
            do
            {
                foreach (Row row in Rows)
                {
                    if (WeightRight <= WeightLeft && row.Place == Place.UnAssigned)
                    {
                        WeightRight += (ulong)row.Weight;
                        row.Set(Place.Right);
                    }
                    else if (row.Place == Place.UnAssigned)
                    {
                        WeightLeft += (ulong)row.Weight;
                        row.Set(Place.Left);
                    }
                }

            } while (Rows.Any(r => r.Place == Place.UnAssigned));

            PlaceMiddleRow();
            DifferenceCalculator();
            return Rows;
        }

        private void PlaceMiddleRow()
        {
            Row middleRow = MiddleRow();
            if (middleRow.Place == Place.Right)
            {
                WeightRight -= ((ulong)middleRow.Weight / 2);
                WeightLeft += ((ulong)middleRow.Weight / 2);
                middleRow.Place = Place.Middle;
            }
            else if (middleRow.Place == Place.Left)
            {
                WeightLeft -= ((ulong)middleRow.Weight / 2);
                WeightRight += ((ulong)middleRow.Weight / 2);
                middleRow.Place = Place.Middle;
            }
        }

        private Row MiddleRow()
        {
            Row middleRow;
            if (Rows.Count() % 2 == 0)
            {
                middleRow = Rows[Rows.Count() / 2];
            }
            else
            {
                middleRow = Rows[(Rows.Count() / 2) + 1];
            }
            return middleRow;
        }

        private double DifferenceCalculator()
        {
            difference = (((double)(weightLeft)/(weightLeft +weightRight)) * 100) - (((double)(weightRight) / (weightLeft + weightRight)) * 100);
            return Math.Round(difference, 2);
        }
    }
}
