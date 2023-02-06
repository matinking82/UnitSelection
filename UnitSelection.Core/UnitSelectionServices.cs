using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSelection.Core
{
    public static class UnitSelectionServices
    {

        public static async Task<UnitSelectionResultDto> SelectUnitsAsync(RequestUnitSelectDto request)
        {
            return await Task.Run(() =>
            {
                return SelectUnits(request);
            });
        }

        public static UnitSelectionResultDto SelectUnits(RequestUnitSelectDto request)
        {

            
            List<IEnumerable<Unit>> unitGoups = new List<IEnumerable<Unit>>();

            int subjectsCount = request.Subjects.Count();

            int[] indexes = new int[subjectsCount];

            int firstCount = request.Subjects.ElementAt(0).Units.Count();

            while (indexes[0] < firstCount)
            {
                List<Unit> units = new List<Unit>();
                for (int i = 0; i < subjectsCount; i++)
                {
                    var unit = request.Subjects.ElementAt(i).Units.ElementAt(indexes[i]);
                    unit.SubjectName = request.Subjects.ElementAt(i).SubjectName;
                    units.Add(unit);
                }

                if (IsUnitsOk(units))
                {
                    unitGoups.Add(units.AsEnumerable());
                }

                bool IsInc = true;
                for (int i = subjectsCount - 1; i >= 0 && IsInc; i--)
                {
                    indexes[i]++;
                    IsInc = false;
                    if (indexes[i] >= request.Subjects.ElementAt(i).Units.Count())
                    {
                        if (i == 0)
                        {
                            break;
                        }
                        else
                        {
                            indexes[i] = 0;
                            IsInc = true;
                        }
                    }
                }
            }
            return new UnitSelectionResultDto()
            {
                UnitGroups = unitGoups
            };
        }

        private static bool IsUnitsOk(IEnumerable<Unit> units)
        {
            bool[,] Table = new bool[5, 5];

            foreach (var unit in units)
            {
                foreach (var unitDay in unit.DayOfUnit)
                {
                    if (Table[unitDay.Day, unitDay.Hour])
                    {
                        return false;
                    }

                    Table[unitDay.Day, unitDay.Hour] = true;
                }
            }

            return true;
        }
    }

    public record RequestUnitSelectDto
    {
        public IEnumerable<Subject> Subjects { get; set; }
    }

    public record UnitSelectionResultDto
    {
        public List<IEnumerable<Unit>> UnitGroups { get; set; }
    }

    public record Subject
    {
        public string SubjectName { get; set; }
        public IEnumerable<Unit> Units { get; set; }
    }

    public record Unit
    {
        public string ProfName { get; set; }
        public string SubjectName { get; set; }
        public IEnumerable<UnitDay> DayOfUnit { get; set; }
    }

    public record UnitDay
    {
        public int Day { get; set; }
        /*
         * 0: Saturday
         * 1: Sunday
         * 2: Monday
         * 3: Tuesday
         * 4: Wednesday
         */
        public int Hour { get; set; }
        /*
         * 0: 8
         * 1: 10
         * 2: 13
         * 3: 15
         * 4: 17
         */
    }
}
