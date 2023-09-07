using UnitSelection.Core;

namespace UnitSelection.Blazor.Types
{
    public record SaveItem
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
